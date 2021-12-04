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
    /// Interaction logic for rUsuarios.xaml
    /// </summary>
    public partial class rUsuarios : Window
    {
        private Usuarios Usuario = new Usuarios();
        public rUsuarios()
        {
            InitializeComponent();
            this.DataContext = Usuario;
        }

        private void Limpiar()
        {
            this.Usuario = new Usuarios();
            this.DataContext = Usuario;
        }

        private bool validar()
        {
            bool esValido = true;
            
            if(NombreUsuarioTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Nombres", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (ClavePasswordBox.Password.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Clave", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            if (EmailTextBox.Text.Length == 0)
            {
                esValido = false;
                MessageBox.Show("Falta el campo Email", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return esValido;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var usuario = UsuariosBLL.Buscar(Usuario.UsuarioId);

            if(usuario != null)
            {
                this.Usuario = usuario;
                this.DataContext = Usuario;
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
            if (!validar())
                return;

            var usuario = UsuariosBLL.Guardar(Usuario);

            if (usuario)
            {
                Limpiar();
                MessageBox.Show("Transaccion exitosa", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Transaccion Fallida", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsuariosBLL.Eliminar(Usuario.UsuarioId))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado!", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
