using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Toko.Model
{
    public class Diskon
    {
        public string diskon { get; set; }

        public Diskon(string diskon)
        {
            this.diskon = diskon;
           
        }
    }
}
