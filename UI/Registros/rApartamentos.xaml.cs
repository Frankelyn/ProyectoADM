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
    /// Interaction logic for rApartamentos.xaml
    /// </summary>
    public partial class rApartamentos : Window
    {
        private Apartamentos Apartamento = new Apartamentos();
        public rApartamentos()
        {
            InitializeComponent();
            this.DataContext = Apartamento;
        }

        private void Limpiar()
        {
            this.Apartamento = new Apartamentos();
            this.DataContext = Apartamento;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NumeroTextBox.Text == "0")
            {
                esValido = false;
                MessageBox.Show("Falta el campo Numero", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (NumeroTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Numero", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (HabitacionesTextBox.Text == "0")
            {
                esValido = false;
                MessageBox.Show("Falta el campo Habitaciones", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (HabitacionesTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Habitaciones", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (PrecioRentaTextBox.Text == "0.00")
            {
                esValido = false;
                MessageBox.Show("Falta el campo Precio de Renta", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (PrecioRentaTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Precio de Renta", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var apartamento = ApartamentosBLL.Buscar(Apartamento.ApartamentoId);

            if (apartamento != null)
            {
                this.Apartamento = apartamento;
                this.DataContext = Apartamento;
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
            if (!Validar())
                return;

            var apartamento = ApartamentosBLL.Guardar(Apartamento);

            if (apartamento)
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
            if (ApartamentosBLL.Eliminar(Apartamento.ApartamentoId))
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
