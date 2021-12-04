using CondominioADM.BLL;
using CondominioADM.Entidades;
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

namespace CondominioADM.UI.Registros
{
    /// <summary>
    /// Interaction logic for rParqueos.xaml
    /// </summary>
    public partial class rParqueos : Window
    {
        private Parqueos Parqueo = new Parqueos();
        public rParqueos()
        {
            InitializeComponent();
            this.DataContext = Parqueo;
        }

        private void Limpiar()
        {
            this.Parqueo = new Parqueos();
            this.DataContext = Parqueo;
        }

        private bool validar()
        {
            bool esValido = true;

            if(NumeroTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Numero", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (NumeroTextBox.Text == "0")
            {
                esValido = false;
                MessageBox.Show("Falta el campo Numero", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (PrecioRentaTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Precio de Renta", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (PrecioRentaTextBox.Text == "0.00")
            {
                esValido = false;
                MessageBox.Show("Falta el campo Precio de Renta", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;

        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var parqueo = ParqueosBLL.Buscar(Parqueo.ParqueoId);

            if(parqueo != null)
            {
                this.Parqueo = parqueo;
                this.DataContext = Parqueo;
            }
            else
            {
                Limpiar();
                MessageBox.Show("No existe en la base de datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!validar())
                return;

            var parqueo = ParqueosBLL.Guardar(Parqueo);

            if (parqueo)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ParqueosBLL.Eliminar(Parqueo.ParqueoId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
