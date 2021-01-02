using System;
using System.Collections.Generic;
using System.Text;

namespace Toko.Model
{
    class KeranjangBelanja
    {
        List<Item> itemkeranjangBelanja;
        public List<Diskon> diskonDipakai;
        onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener;

        public KeranjangBelanja(onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener)
        {
            this.onKeranjangBelanjaChangedListener = onKeranjangBelanjaChangedListener;
            this.itemkeranjangBelanja = new List<Item>();
            this.diskonDipakai = new List<Diskon>();
        }
        public List<Item> getItems()
        {
            return this.itemkeranjangBelanja;
        }

        public List<Diskon> getDiskon()
        {
            return this.diskonDipakai;
        }

        public void addItem(Item item)
        {
            this.itemkeranjangBelanja.Add(item);
            this.onKeranjangBelanjaChangedListener.addItemSucceed();
            calculateSubTotal();
        }

        public void removeItem(Item item)
        {
            this.itemkeranjangBelanja.Remove(item);
            this.onKeranjangBelanjaChangedListener.removeItemSucceed();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subTotal = 0;
            foreach(Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;
            }
        }

        public void addDiskon(Diskon diskon)
        {
            this.diskonDipakai.Clear();
            this.diskonDipakai.Add(diskon);
            this.onKeranjangBelanjaChangedListener.addPromoSucceed();
        }
    }

   

    interface onKeranjangBelanjaChangedListener
    {
        void removeItemSucceed();
        void addItemSucceed();

        void addPromoSucceed();
    }
}
