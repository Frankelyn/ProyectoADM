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
    /// Interaction logic for rArriendaParqueos.xaml
    /// </summary>
    public partial class rArriendaParqueos : Window
    {
        private ArriendaParqueos Arrienda = new ArriendaParqueos();
        public rArriendaParqueos()
        {
            InitializeComponent();
            this.DataContext = Arrienda;
        }

        private void Limpiar()
        {
            this.Arrienda = new ArriendaParqueos();
            this.DataContext = Arrienda;
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

            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var arrienda = ArriendaParqueosBLL.Buscar(Arrienda.ArriendaParqueosId);

            if (arrienda != null)
            {
                this.Arrienda = arrienda;
                this.DataContext = Arrienda;
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

            var arrienda = ArriendaParqueosBLL.Guardar(Arrienda);

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
            if (ArriendaParqueosBLL.Eliminar(Arrienda.ArriendaParqueosId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ParqueoButton_Click(object sender, RoutedEventArgs e)
        {
            Utilidades.ok = true;
            cParqueo cParqueo = new();
            
            cParqueo.ShowDialog();

            if(Utilidades.Parqueo != null)
            {
                ParqueoTextBox.Text = Utilidades.Parqueo.Numero.ToString();
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
