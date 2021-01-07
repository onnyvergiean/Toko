using System;
using System.Collections.Generic;
using System.Text;
using Toko.Model;

namespace Toko.Controller
{
    
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;
        Payment payment;


        public MainWindowController(KeranjangBelanja keranjangBelanja, Payment payment)
        {
            this.keranjangBelanja = keranjangBelanja;
            this.payment = payment;
        }

        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }

        public void removeItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }

        public List<Item> getItems()
        {
            return this.keranjangBelanja.getItems();
        }

        public void addDiskon(Diskon diskon)
        {
            
            this.payment.addDiskon(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.payment.getDiskon();
        }


    }
}
