using System;
using System.Collections.Generic;
using System.Text;

namespace Toko.Model
{
    class Payment
    {
        private double balance = 0;
        public List<Diskon> diskonDipakai;
        OnPaymentChangedListener paymentListener;
        public Payment(OnPaymentChangedListener paymentListener)
        {
            
            this.paymentListener = paymentListener;
            this.diskonDipakai = new List<Diskon>();

        }
        public List<Diskon> getDiskon()
        {
            return this.diskonDipakai;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return this.balance;
        }
    
        public void updateTotal(Diskon diskon,double subTotal)
        {
            double total = 0;
            if(diskon.potongan == 0.25)
            {
                total = (100 - 25) * subTotal / 100;
            }else if (diskon.potongan == 30000)
            {
                if(total <= 30000)
                {
                    total = (100 - 30) * subTotal / 100;
                }
                else
                {
                    total = subTotal - 30000;
                }
            }else if (diskon.potongan == 10000)
            {
                total = subTotal - 10000;
            }
            this.balance = this.balance - total;
            this.paymentListener.onPriceUpdated(subTotal, total, balance);
        }
        public void addDiskon(Diskon diskon)
        {
            this.diskonDipakai.Clear();
            this.diskonDipakai.Add(diskon);
            this.paymentListener.addPromoSucceed();
        }
        
    }

    interface OnPaymentChangedListener
    {
        void onPriceUpdated(double subtTotal, double total, double balance);

        void addPromoSucceed();
    }
}
