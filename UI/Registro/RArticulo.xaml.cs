using RegistroArticulo.Entidades;
using RegistroArticulo.BLL;
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
using System.Windows.Shapes;

namespace RegistroArticulo.UI.Registro
{
    /// <summary>
    /// Interaction logic for RegistroV.xaml
    /// </summary>
    public partial class RegistroV : Window
    {
        private Articulos Articulos = new Articulos();
        public RegistroV()
        {
            InitializeComponent();

            this.DataContext = Articulos;
        }

        private void Limpiar()
        {
            this.Articulos = new Articulos();
            this.DataContext = Articulos;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (ArticuloIdTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var articulo = ArticuloBLL.Buscar(Utilidades.ToInt(ArticuloIdTextBox.Text));

            if (articulo != null)
                this.Articulos = articulo;
            else
                this.Articulos = new Articulos();

            this.DataContext = this.Articulos;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = ArticuloBLL.Guardar(Articulos);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado correctamente!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Transaccion Fallida", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ArticuloBLL.Eliminar(Utilidades.ToInt(ArticuloIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro eliminado!", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show("No fue posible eliminar", "Fallo",
                   MessageBoxButton.OK, MessageBoxImage.Error);
        }


    }
}
