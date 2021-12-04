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
    /// Interaction logic for rDepositoParqueo.xaml
    /// </summary>
    public partial class rDepositoParqueo : Window
    {
        private DepositoParqueo Deposito = new DepositoParqueo();
        public rDepositoParqueo()
        {
            InitializeComponent();
            this.DataContext = Deposito;
        }

        private void Limpiar()
        {
            this.Deposito = new DepositoParqueo();
            this.DataContext = Deposito;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (ParqueoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Numero de Parqueo", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (ResidenteTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Nombre del Residente", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if(MontoTextbox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el Campo Monto", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var deposito = DepositoParqueosBLL.Buscar(Deposito.DepositoParqueoId);

            if (deposito != null)
            {
                this.Deposito = deposito;
                this.DataContext = Deposito;
            }
            else
            {
                Limpiar();
                MessageBox.Show("No existe en la base de datos");
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

            var deposito = DepositoParqueosBLL.Guardar(Deposito);

            if (deposito)
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
            if (DepositoParqueosBLL.Eliminar(Deposito.DepositoParqueoId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        

        private void ResidenteButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.ok = true;
            cResidentes cResidentes = new();
            cResidentes.ShowDialog();

            if (Utilidades.Residente != null)
            {
                ResidenteTextBox.Text = Utilidades.Residente.Nombres;
            }
        }

        private void ParqueoButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.ok = true;
            cParqueo cParqueo = new();
            cParqueo.ShowDialog();

            if (Utilidades.Parqueo != null)
            {
                ParqueoTextBox.Text = Utilidades.Parqueo.Numero.ToString();
            }
        }
    }
}
