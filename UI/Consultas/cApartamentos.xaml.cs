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

namespace CondominioADM.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cApartamentos.xaml
    /// </summary>
    public partial class cApartamentos : Window
    {
        public cApartamentos()
        {
            InitializeComponent();

            if (!Utilidades.ok)
            {
                AgregarButton.IsEnabled = false;
            }

        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Apartamentos>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            listado = ApartamentosBLL.GetList(e => e.ApartamentoId == Utilidades.ToInt(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                    case 1:
                        try
                        {
                            listado = ApartamentosBLL.GetList(e => e.Numero == Utilidades.ToInt(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 2:
                        try
                        {
                            listado = ApartamentosBLL.GetList(e => e.Habitaciones == Utilidades.ToInt(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 3:
                        try
                        {
                            listado = ApartamentosBLL.GetList(e => e.PrecioRenta == Utilidades.ToFloat(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                }
            }
            else
            {
                if(!Criterio_TextBox.IsEnabled)
                    listado = ApartamentosBLL.GetList(e => e.Disponible == true);
                else
                    listado = ApartamentosBLL.GetList(c => true);
            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;


            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            if (DatosDataGrid.SelectedItem != null)
            {
                Utilidades.Apartamento = (Apartamentos)DatosDataGrid.SelectedItem;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Apartamento", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Filtro_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filtro_ComboBox.SelectedIndex == 4)
            {
                Criterio_TextBox.IsEnabled = false;
            }
        }
    }
}
