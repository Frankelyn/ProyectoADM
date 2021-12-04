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
    /// Interaction logic for rPagoParqueo.xaml
    /// </summary>
    public partial class rPagoParqueo : Window
    {
        private PagoParqueo Pago = new PagoParqueo();
        public rPagoParqueo()
        {
            InitializeComponent();
            this.DataContext = Pago;
        }

        private void Limpiar()
        {
            this.Pago = new PagoParqueo();
            this.DataContext = Pago;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (ParqueoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Numero de Parqueo", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (ResidenteTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Nombre del residente", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if(MontoPagoTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Monto a Pagar", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }
    
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var pago = PagoParqueosBLL.Buscar(Pago.PagoParqueoId);

            if (Pago != null)
            {
                this.Pago = pago;
                this.DataContext = Pago;
            }
            else
            {
                Limpiar();
                MessageBox.Show("Id no valido o No Existe en la base de datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BuscarRentaButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.ok = true;
            cArriendaParqueos cArrienda = new();
            cArrienda.ShowDialog();

            if (Utilidades.ArriendaP != null)
            {
                ParqueoTextBox.Text = Utilidades.ArriendaP.NumeroParqueo.ToString();
                MontoTextbox.Text = Utilidades.ArriendaP.MontoRenta.ToString("N2");
                ResidenteTextBox.Text = Utilidades.ArriendaP.NombreResidente;

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

            var paso = PagoParqueosBLL.Guardar(Pago);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (PagoParqueosBLL.Eliminar(Pago.PagoParqueoId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible elimianr", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MontoPagoTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var devuelta = Utilidades.ToFloat(MontoPagoTextbox.Text) - Utilidades.ToFloat(MontoTextbox.Text);
            DevueltaLabel.Content = devuelta.ToString();
        }
    }
}
