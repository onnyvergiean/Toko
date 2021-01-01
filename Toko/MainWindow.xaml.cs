using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Toko.Controller;
using Toko.Model;

namespace Toko
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,
        OnMenuChangedListener,
        onKeranjangBelanjaChangedListener
    {
        MainWindowController controller;

        public MainWindow()
        {
            InitializeComponent();
            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(this);
            controller = new MainWindowController(keranjangBelanja);

            listKeranjangBelanja.ItemsSource = controller.getItems();
        }

        public void addItemSucceed()
        {
            listKeranjangBelanja.Items.Refresh();
        }

        public void OnMenuSelected(Item item)
        {
            controller.addItem(item);
        }

        public void removeItemSucceed()
        {
            listKeranjangBelanja.Items.Refresh();
        }

        private void onDaftarMenuClicked(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.SetOnItemSelectedListener(this);
            menu.Show();
        }

        private void onlistKeranjangBelanjaDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Kamu ingin menghapus item ini?",
                   "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBox listBox = sender as ListBox;
                Item item = listBox.SelectedItem as Item;
                controller.removeItem(item);
            }
        }

        private void onBtnGantiPromoClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
