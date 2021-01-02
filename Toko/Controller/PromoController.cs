using System;
using System.Collections.Generic;
using System.Text;

namespace Toko.Controller
{
    class PromoController
    {
        private List<Promo> promo;

        public PromoController()
        {
            promo = new List<Promo>();
        }

        public void addPromo(Promo promo)
        {
            this.promo.Add(promo);
        }

        public List<Promo> getPromo()
        {
            return this.promo;
        }
    }
}
