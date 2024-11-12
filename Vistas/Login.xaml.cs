using ClaseBase;
using ClasesBase;
using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //txtUsuario.Text = "Auditor";
            //txtContrasena.Text = "auditor";
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            String nombre = txtUsuario.Text;
            String contrasena = txtContrasena.Text;
            Usuario usuario = TrabajarUsuario.loginUsuario(nombre, contrasena);
            if (usuario != null)
            {
                MessageBox.Show("Bienvenido al sistema " + usuario.Usu_NombreUsuario, "Mensaje", MessageBoxButton.OK, MessageBoxImage.Information);
                Window.GetWindow(this).Hide();
                Principal principal = new (usuario.Rol_Codigo, this);
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }*/
    }
}