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
    /// Interaction logic for cUsuarios.xaml
    /// </summary>
    public partial class cUsuarios : Window
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void Buscar_Button_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Usuarios>();

            if (Criterio_TextBox.Text.Trim().Length > 0)
            {
                switch (Filtro_ComboBox.SelectedIndex)
                {
                    case 0:
                        try
                        {
                            if (Desde_DataPicker.SelectedDate != null)
                                listado = UsuariosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.UsuarioId == Utilidades.ToInt(Criterio_TextBox.Text)
                                );
                            else
                                listado = UsuariosBLL.GetList(e => e.UsuarioId == Utilidades.ToInt(Criterio_TextBox.Text));
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
                                listado = UsuariosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Nombres.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = UsuariosBLL.GetList(d => d.Nombres.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
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
                                listado = UsuariosBLL.GetList(
                                    c => c.Fecha.Date >= Desde_DataPicker.SelectedDate &&
                                    c.Fecha.Date <= Hasta_DatePicker.SelectedDate &&
                                    c.Email.ToLower().Contains(Criterio_TextBox.Text.ToLower())
                                );
                            else
                                listado = UsuariosBLL.GetList(d => d.Email.ToLower().Contains(Criterio_TextBox.Text.ToLower()));
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
                    listado = UsuariosBLL.GetList(e => e.Fecha.Date >= Desde_DataPicker.SelectedDate);

                if (Hasta_DatePicker.SelectedDate != null)
                    listado = UsuariosBLL.GetList(e => e.Fecha.Date <= Hasta_DatePicker.SelectedDate);

                if (Desde_DataPicker.SelectedDate == null && Hasta_DatePicker.SelectedDate == null)
                    listado = UsuariosBLL.GetList(c => true);

            }

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;


            var conteo = listado.Count;
            ConteoTextbox.Text = conteo.ToString();
        }
    }
}
