using System;
using System.Collections.Generic;
using System.Linq;
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
    
        

        public void addDiskon(Diskon diskon)
        {
            this.diskonDipakai.Clear();
            this.diskonDipakai.Add(diskon);
            this.paymentListener.addPromoSucceed();
        }

       

        public void updateTotal(double subTotal)
        {
            double promo = 0;

            foreach (Diskon diskon in diskonDipakai)
            {
                if (diskon.potongan == 10000)
                {
                    promo = 10000;
                }
                else if (diskon.potongan == 30000)
                {
                   
                    promo = (subTotal * 30 / 100);

                    if(promo > 30000)
                    {
                        promo = 30000;
                    }
                    else
                    {
                        promo = (subTotal * 30 / 100);
                    }
                   
                }
                else if (diskon.potongan == 25000)
                {
                    promo = (subTotal * 25 / 100);
                    
                }
                
            }

            double total = subTotal - promo;
            this.paymentListener.onPriceUpdated(subTotal, total);
            
        }
    }

    interface OnPaymentChangedListener
    {
        void onPriceUpdated(double subtTotal, double total);

        void addPromoSucceed();
    }
}
