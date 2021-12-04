using CondominioADM.BLL;
using CondominioADM.Entidades;
using CondominioADM.UI.Consultas;
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
    /// Interaction logic for rArriendaApartamentos.xaml
    /// </summary>
    public partial class rArriendaApartamentos : Window
    {
        private ArriendaApartamentos Arrienda = new ArriendaApartamentos();
        public rArriendaApartamentos()
        {
            InitializeComponent();
            
            Fecha_DatePicker.SelectedDate = DateTime.Now;
            FechaR_DatePicker.SelectedDate = DateTime.Now;

            this.DataContext = Arrienda;

            
        }

        private void Limpiar()
        {
            this.Arrienda = new ArriendaApartamentos();
            this.DataContext = Arrienda;
        }

        private bool Validar()
        {
            bool esValido = true;

            if(ApartamentoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Numero de Apartamento", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (ResidenteTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Nombre del Residente", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if(FechaR_DatePicker.SelectedDate <= Fecha_DatePicker.SelectedDate)
            {
                esValido = false;
                MessageBox.Show("La fecha de renovacion debe ser mayor a la fecha de inicio", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if(Fecha_DatePicker.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Fecha de inicio", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (FechaR_DatePicker.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Fecha de Renovacion", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var arrienda = ArriendaApartamentosBLL.Buscar(Arrienda.ArriendaApartamentoId);

            if(arrienda != null)
            {
                this.Arrienda = arrienda;
                this.DataContext = Arrienda;
            }
            else
            {
                Limpiar();
                MessageBox.Show("No existe en la base de datos", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
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

            var arrienda = ArriendaApartamentosBLL.Guardar(Arrienda);

            if (arrienda)
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
            if (ArriendaApartamentosBLL.Eliminar(Arrienda.ArriendaApartamentoId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ApartamentoButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.ok = true;
            cApartamentos cApartamentos = new();
            cApartamentos.ShowDialog();

            if(Utilidades.Apartamento != null)
            {
                ApartamentoTextBox.Text = Utilidades.Apartamento.Numero.ToString();
            }

        }

        private void ResidenteButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.ok = true;
            cResidentes cResidentes = new();
            cResidentes.ShowDialog();

            if(Utilidades.Residente != null)
            {
                ResidenteTextBox.Text = Utilidades.Residente.Nombres;
            }
        }
    }
}
