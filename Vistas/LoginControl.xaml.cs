using ClaseBase;
using ClasesBase;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Vistas
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
            txtUsuario.Text = "Auditor";
            txtContrasena.Password = "auditor";
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            String nombre = txtUsuario.Text;
            String contrasena = txtContrasena.Password;
            Usuario usuario = TrabajarUsuario.loginUsuario(nombre, contrasena);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido al sistema " + usuario.Usu_NombreUsuario, "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                Window.GetWindow(this).Hide();
                Principal principal = new(usuario.Rol_Codigo, Window.GetWindow(this));
                  principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
