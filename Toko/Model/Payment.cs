using System;
using System.Collections.Generic;
using System.Text;

namespace Toko.Model
{
    class Payment
    {
        KeranjangBelanja keranjangBelanja;
        public Payment(KeranjangBelanja keranjangBelanja)
        {
            this.keranjangBelanja = keranjangBelanja;
        }


        public void promoAwaltahun(Diskon diskon)
        {
            if (diskon.Any(attrib => attrib.diskon() == "Owner"))
            {

            }
        }
    }
}
