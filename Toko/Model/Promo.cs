using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Toko.Model
{
    public class Promo
    {
        public string promo { get; set; }

        public Promo(string promo)
        {
            this.promo = promo;
           
        }
    }
}
