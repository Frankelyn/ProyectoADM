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
    /// Interaction logic for cPagoParqueo.xaml
    /// </summary>
    public partial class cPagoParqueo : Window
    {
        public cPagoParqueo()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<PagoParqueo>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = PagoParqueosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.PagoParqueoId == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = PagoParqueosBLL.GetList(e => e.PagoParqueoId == Utilidades.ToInt(Criterio_TextBox.Text));
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
                                listado = PagoParqueosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Arrienda.NombreResidente.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = PagoParqueosBLL.GetList(d => d.Arrienda.NombreResidente.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
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
                                listado = PagoParqueosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Arrienda.NumeroParqueo == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = PagoParqueosBLL.GetList(e => e.Arrienda.NumeroParqueo == Utilidades.ToInt(Criterio_TextBox.Text));
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
                                listado = PagoParqueosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.MontoPago == Utilidades.ToFloat(Criterio_TextBox.Text)
                                );
                            else
                                listado = PagoParqueosBLL.GetList(e => e.MontoPago == Utilidades.ToFloat(Criterio_TextBox.Text));
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
                    listado = PagoParqueosBLL.GetList(e => e.Fecha.Date >= Desde_DataPicker.SelectedDate);

                if (Hasta_DatePicker.SelectedDate != null)
                    listado = PagoParqueosBLL.GetList(e => e.Fecha.Date <= Hasta_DatePicker.SelectedDate);

                if (Desde_DataPicker.SelectedDate == null && Hasta_DatePicker.SelectedDate == null)
                    listado = PagoParqueosBLL.GetList(c => true);

            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;


            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
        }
    }
}
