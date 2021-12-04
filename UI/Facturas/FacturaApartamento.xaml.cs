using CondominioADM.BLL;
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

namespace CondominioADM.UI.Facturas
{
    /// <summary>
    /// Interaction logic for FacturaApartamento.xaml
    /// </summary>
    public partial class FacturaApartamento : Window
    {
        public FacturaApartamento()
        {
            InitializeComponent();


            UserTextBlock.Text = Utilidades.user.Nombres;
            UserEmailTextBlock.Text = Utilidades.user.Email;

            ResidenteTextBlock.Text = Utilidades.Pago.Arrienda.NombreResidente;
            FechaTextBlock.Text = Utilidades.Pago.Fecha.ToString();
            IdTextBlock.Text = Utilidades.Pago.PagoApartamentoId.ToString();
            NumApTextBlock.Text = Utilidades.Pago.Arrienda.NumeroApartamento.ToString();
            PrecioTextBlock.Text = Utilidades.Pago.Arrienda.MontoRenta.ToString("N2");
            SubtotalTextblock.Text = Utilidades.Pago.Arrienda.MontoRenta.ToString("N2");
            MontoPagoTextBlock.Text = Utilidades.Pago.MontoPago.ToString("N2");
            CambioTextblock.Text = Utilidades.ToFloat(Utilidades.Devuelta).ToString("N2");
            TotalTextblock.Text = Utilidades.Pago.Arrienda.MontoRenta.ToString("N2");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(print, "Factura");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
