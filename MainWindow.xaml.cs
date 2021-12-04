using CondominioADM.BLL;
using CondominioADM.UI.Consultas;
using CondominioADM.UI.Registros;
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



namespace CondominioADM
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

        private void ResidentesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rResidentes rResidentes = new();
            rResidentes.Show();
        }

        private void ApartamentosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rApartamentos rApartamentos = new();
            rApartamentos.Show();
        }

        private void ParqueosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rParqueos rParqueos = new();
            rParqueos.Show();
        }

        private void UsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios rUsuarios = new();
            rUsuarios.Show();
        }

        private void RentaApartamentosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rArriendaApartamentos rArriendaApartamentos = new();
            rArriendaApartamentos.Show();
        }

        private void RentaParqueosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rArriendaParqueos rArriendaParqueos = new();
            rArriendaParqueos.Show();
        }

        private void DepositoApartamentoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rDepositoApartamentos rDepositoApartamentos = new();
            rDepositoApartamentos.Show();
        }

        private void DepositoParqueoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rDepositoParqueo rDepositoParqueo = new();
            rDepositoParqueo.Show();
        }

        private void PagoApartamentoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rPagoApartamento rPagoApartamento = new();
            rPagoApartamento.Show();
        }

        private void PagoParqueoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rPagoParqueo rPagoParqueo = new();
            rPagoParqueo.Show();
        }

        private void cResidentesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cResidentes cResidentes = new();
            Utilidades.ok = false;
            cResidentes.Show();
        }

        private void cApartamentosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cApartamentos cApartamentos = new();
            Utilidades.ok = false;
            cApartamentos.Show();
        }

        private void cParqueosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cParqueo cParqueo = new();
            Utilidades.ok = false;
            cParqueo.Show();
        }

        private void cUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios cUsuarios = new();
            cUsuarios.Show();
        }

        private void cRentaApartamentosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cArriendaApartamentos cArriendaApartamentos = new();
            Utilidades.ok = false;
            cArriendaApartamentos.Show();
        }

        private void cRentaParqueosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cArriendaParqueos cArriendaParqueos = new();
            Utilidades.ok = false;
            cArriendaParqueos.Show();
        }

        private void cDepositoApartamentoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cDepositoApartamentos cDepositoApartamentos = new();
            cDepositoApartamentos.Show();
        }

        private void cDepositoParqueoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cDepositoParqueo cDepositoParqueo = new();
            cDepositoParqueo.Show();
        }

        private void cPagoApartamentoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cPagoApartamento cPagoApartamento = new();
            cPagoApartamento.Show();
        }

        private void cPagoParqueoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cPagoParqueo cPagoParqueo = new();
            cPagoParqueo.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
