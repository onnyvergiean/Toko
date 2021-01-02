using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Toko.Controller;
using Toko.Model;

namespace Toko
{
    /// <summary>
    /// Interaction logic for Promo.xaml
    /// </summary>
    public partial class Promo : Window
    {
        PromoController promoController;
        public Promo()
        {
            InitializeComponent();
            promoController = new PromoController();
        }

        private void onlistBoxDaftarMenuClicked(object sender, MouseButtonEventArgs e)
        {

        }

        private void generateContentPromo()
        {
            Diskon diskon1 = new Diskon("Promo Natal");
        }
    }

    public interface OnPromoChangedListener
    {
        void OnPromoSelected(Diskon diskon);
    }
}
