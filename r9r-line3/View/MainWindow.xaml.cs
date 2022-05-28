using r9r_line3.Model;
using r9r_line3.ViewModel;
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

namespace r9r_line3
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClientViewModel compteCli = new ClientViewModel();
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(compteCli.getLeClient(1).NOMCLIENT);
            MessageBox.Show(compteCli.getLeClient(1).PRENOMCLIENT);
            MessageBox.Show(compteCli.getLeClient(1).MAILCLIENT);

            DataContext = compteCli.getLeClient(1).NOMCLIENT;
        }
            public string nomcli()
        {
            return compteCli.getLeClient(1).NOMCLIENT;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           /* var query =
            from voyage in 
            where voyage.IDVOYAGE == "Red"
            orderby product.ListPrice
            select new { product.Name, product.Color, CategoryName = product.ProductCategory.Name, product.ListPrice };

            dataGrid1.ItemsSource = query.ToList();*/
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Lt_Voyage2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tb_nom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, RoutedEventArgs e)
        {
            client cli = compteCli.getLeClient(Nom.Text, Prenom.Text);
            listBox.ItemsSource = compteCli.GetVoyages(cli);
        }

        private void Nom_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}