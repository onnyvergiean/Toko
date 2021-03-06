﻿using System;
using System.Collections.Generic;
using System.Text;
using Toko.Model;

namespace Toko.Controller
{
    
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;


        public MainWindowController(KeranjangBelanja keranjangBelanja, Payment payment)
        {
            this.keranjangBelanja = keranjangBelanja;
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
            
            this.keranjangBelanja.addDiskon(diskon);
        }

        public void removeDiskon(Diskon diskon)
        {
            this.keranjangBelanja.removeDiskon(diskon);
        }
        public List<Diskon> getDiskon()
        {
            return this.keranjangBelanja.getDiskon();
        }


    }
}
