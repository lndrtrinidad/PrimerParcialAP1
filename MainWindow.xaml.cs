using RegistroArticulo.Entidades;
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
using RegistroArticulo.UI.Registro;

namespace RegistroArticulo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Id_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            RegistroV RegistroV = new RegistroV();
            RegistroV.Show();
        }
    }
}
