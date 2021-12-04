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
    /// Interaction logic for cResidentes.xaml
    /// </summary>
    public partial class cResidentes : Window
    {
        public cResidentes()
        {
            InitializeComponent();

            if (!Utilidades.ok)
            {
                AgregarButton.IsEnabled = false;
            }

            

        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Residentes>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ResidentesBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.ResidenteId == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = ResidentesBLL.GetList(e => e.ResidenteId == Utilidades.ToInt(Criterio_TextBox.Text));
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
                                listado = ResidentesBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Nombres.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = ResidentesBLL.GetList(d => d.Nombres.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
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
                                listado = ResidentesBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Cedula.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = ResidentesBLL.GetList(d => d.Cedula.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 3:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ResidentesBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Telefono.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = ResidentesBLL.GetList(d => d.Telefono.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 4:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ResidentesBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Email.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = ResidentesBLL.GetList(d => d.Email.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Debes ingresar un Critero valido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        break;

                    case 5:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = ResidentesBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Sexo.Descripcion.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = ResidentesBLL.GetList(d => d.Sexo.Descripcion.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
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
                    listado = ResidentesBLL.GetList(e => e.Fecha.Date >= Desde_DataPicker.SelectedDate);

                if (Hasta_DatePicker.SelectedDate != null)
                    listado = ResidentesBLL.GetList(e => e.Fecha.Date <= Hasta_DatePicker.SelectedDate);

                if (!Criterio_TextBox.IsEnabled)
                {
                    listado = ResidentesBLL.GetList(e => e.Activo == true);
                }
                else
                {
                    if (Desde_DataPicker.SelectedDate == null && Hasta_DatePicker.SelectedDate == null)
                        listado = ResidentesBLL.GetList(c => true);
                }    

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
                Utilidades.Residente = (Residentes)DatosDataGrid.SelectedItem;
                Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Residente", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Filtro_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Filtro_ComboBox.SelectedIndex == 6)
            {
                Criterio_TextBox.IsEnabled = false;
            }
        }
    }
}
