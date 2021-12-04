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
    /// Interaction logic for cArriendaParqueos.xaml
    /// </summary>
    public partial class cArriendaParqueos : Window
    {
        public cArriendaParqueos()
        {
            InitializeComponent();
            if (!Utilidades.ok)
            {
                AgregarButton.IsEnabled = false;
            }
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<ArriendaParqueos>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ArriendaParqueosBLL.GetList(
                                    c => c.FechaInicio.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaInicio.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.ArriendaParqueosId == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = ArriendaParqueosBLL.GetList(e => e.ArriendaParqueosId == Utilidades.ToInt(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;
                    case 1:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ArriendaParqueosBLL.GetList(
                                    c => c.FechaInicio.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaInicio.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.NombreResidente.ToLower().Contains(Criterio_TextBox.Text)
                                );
                            else
                                listado = ArriendaParqueosBLL.GetList(e => e.NombreResidente.ToLower().Contains(Criterio_TextBox.Text));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 2:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ArriendaParqueosBLL.GetList(
                                    c => c.FechaInicio.Date >= Desde_DataPicker.SelectedDate &&
                                    c.FechaInicio.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.NumeroParqueo == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = ArriendaParqueosBLL.GetList(e => e.NumeroParqueo == Utilidades.ToInt(Criterio_TextBox.Text));
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
                if (Desde_DataPicker.SelectedDate != null)
                    listado = ArriendaParqueosBLL.GetList(e => e.FechaInicio.Date >= Desde_DataPicker.SelectedDate);

                if (Hasta_DatePicker.SelectedDate != null)
                    listado = ArriendaParqueosBLL.GetList(e => e.FechaInicio.Date <= Hasta_DatePicker.SelectedDate);

                if (Desde_DataPicker.SelectedDate == null && Hasta_DatePicker.SelectedDate == null)
                    listado = ArriendaParqueosBLL.GetList(c => true);

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
                Utilidades.ArriendaP = (ArriendaParqueos)DatosDataGrid.SelectedItem;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Parqueo", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
