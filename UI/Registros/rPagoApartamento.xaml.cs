using CondominioADM.BLL;
using CondominioADM.Entidades;
using CondominioADM.UI.Consultas;
using CondominioADM.UI.Facturas;
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
    /// Interaction logic for rPagoApartamento.xaml
    /// </summary>
    public partial class rPagoApartamento : Window
    {
        private PagoApartamentos Pago = new PagoApartamentos();
        public rPagoApartamento()
        {
            InitializeComponent();
            this.DataContext = Pago;
        }

        private void Limpiar()
        {
            this.Pago = new PagoApartamentos();
            this.DataContext = Pago;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (ApartamentoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Numero de Apartamento", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (ResidenteTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Nombre del residente", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (MontoPagoTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Monto a Pagar", "Adverencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var pago = PagoApartamentosBLL.Buscar(Pago.PagoApartamentoId);

            if(Pago != null)
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
            cArriendaApartamentos cArriendaApartamentos = new();
            cArriendaApartamentos.ShowDialog();

            if(Utilidades.ArriendaA != null)
            {
                ApartamentoTextBox.Text = Utilidades.ArriendaA.NumeroApartamento.ToString();
                ResidenteTextBox.Text = Utilidades.ArriendaA.NombreResidente;
                MontoTextbox.Text = Utilidades.ArriendaA.MontoRenta.ToString("N2");
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

            var paso = PagoApartamentosBLL.Guardar(Pago);

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
            if (PagoApartamentosBLL.Eliminar(Pago.PagoApartamentoId))
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
            var devuelta = Utilidades.ToFloat(MontoTextbox.Text) - Utilidades.ToFloat(MontoPagoTextbox.Text);
            DevueltaLabel.Content = devuelta.ToString("N2");
        }

        private void ImprimirButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.Pago.Arrienda = Utilidades.ArriendaA;
            Utilidades.Pago.Arrienda.NombreResidente = ResidenteTextBox.Text;
            Utilidades.Pago.Arrienda.NumeroApartamento = Utilidades.ToInt(ApartamentoTextBox.Text);
            Utilidades.Pago.MontoPago = Utilidades.ToFloat(MontoPagoTextbox.Text);
            Utilidades.Pago.Arrienda.MontoRenta = Utilidades.ToFloat(MontoTextbox.Text);
            Utilidades.Pago.Fecha = (DateTime)Fecha_DatePicker.SelectedDate;
            Utilidades.Pago.PagoApartamentoId = Utilidades.ToInt(PagoApartamentoIdTextBox.Text);
            Utilidades.Devuelta = (string)DevueltaLabel.Content;

            FacturaApartamento factura = new();
            factura.Show();


        }
    }
}
