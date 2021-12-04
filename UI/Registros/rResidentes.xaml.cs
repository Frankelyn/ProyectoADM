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
    /// Interaction logic for rResidentes.xaml
    /// </summary>
    public partial class rResidentes : Window
    {
        private Residentes Residente = new Residentes();
        public rResidentes()
        {
            InitializeComponent();
            this.DataContext = Residente;

            SexoCombobox.ItemsSource = SexosBLL.GetSexos();
            SexoCombobox.SelectedValuePath = "SexoId";
            SexoCombobox.DisplayMemberPath = "Descripcion";

            EstadoCivilCombobox.ItemsSource = EstadosCivilesBLL.GetEstadosCiviles();
            EstadoCivilCombobox.SelectedValuePath = " EstadoCivilId";
            EstadoCivilCombobox.DisplayMemberPath = "Descripcion";

        }


        private void Limpiar()
        {
            this.Residente = new Residentes();
            this.DataContext = Residente;
        }

        private bool Validar()
        {
            bool esValido = true;

            if (NombresTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Nombres", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (CedulaTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Cedula", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TelefonoTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Telefono", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (SexoCombobox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Sexo", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (EstadoCivilCombobox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Estado Civil", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;

        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var residente = ResidentesBLL.Buscar(Residente.ResidenteId);

            if (residente != null)
            {
                this.Residente = residente;
                this.DataContext = Residente;
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

            var residente = ResidentesBLL.Guardar(Residente);

            if (residente)
            {
                Limpiar();
                MessageBox.Show("Transaccion Exitosa!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ResidentesBLL.Eliminar(Residente.ResidenteId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible eliminar!", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
