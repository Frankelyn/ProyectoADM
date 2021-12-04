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

namespace CondominioADM.UI
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            EmailTextBox.Focus();
        }

        Usuarios usuarios = new Usuarios();
        MainWindow Principal = new MainWindow();
        private void ContrasenaPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                IngresarButton_Click(sender, e);
            }
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            bool paso = LoginBLL.Validar(EmailTextBox.Text, ContrasenaPasswordBox.Password);

            if (paso)
            {
                Utilidades.user = UsuariosBLL.getUser(EmailTextBox.Text);
                this.Hide();
                Principal.Show();
            }
            else
            {
                MessageBox.Show("Error Email o Contraseña incorrecta!", "Error!");
                ContrasenaPasswordBox.Clear();
                EmailTextBox.Focus();
            }
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        

      

        private void EmailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ContrasenaPasswordBox.Focus();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
