using ClaseBase;
using ClasesBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para ABMUsuario.xaml
    /// </summary>
    public partial class ABMUsuario : Window
    {
        public ObservableCollection<Usuario> usuarios { get; set; }
        public ObservableCollection<Roles> roles { get; set; }
        private int currentIndex;
        private Window ventanaAnterior { get; set; }

        public ABMUsuario(Window referenciaVentana)
        {
            InitializeComponent();
            DataContext = this; // Establece el DataContext para el enlace
            ventanaAnterior = referenciaVentana;

            CargarRoles();
            CargarUsuarios();

            currentIndex = 0;  // Asegura que currentIndex tenga un valor inicial
            MostrarUsuario();
        }

        private void CargarUsuarios()
        {
            usuarios = TrabajarUsuario.TraerUsuario();
            currentIndex = 0;
        }

        private void CargarRoles()
        {
            roles = TrabajarUsuario.TraerRoles();
        }

        private void MostrarUsuario()
        {
            if (usuarios.Count > 0 && currentIndex >= 0 && currentIndex < usuarios.Count)
            {
                var usuario = usuarios[currentIndex];
                txtApellidoNombre.Text = usuario.Usu_ApellidoNombre;
                txtNombreUsuario.Text = usuario.Usu_NombreUsuario;
                txtContrasena.Password = usuario.Usu_Contraseña;
                cmbRoles.SelectedValue = usuario.Rol_Codigo;
            }
        }

        private void txtContrasena_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox && currentIndex >= 0 && currentIndex < usuarios.Count)
            {
                // Asigna la contraseña al usuario actual
                var usuario = usuarios[currentIndex];
                usuario.Usu_Contraseña = passwordBox.Password; // Actualiza la propiedad con la contraseña
            }
        }

        // Eventos de navegación
        private void btnPrimero_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = 0;
            MostrarUsuario();
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                MostrarUsuario();
            }
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex < usuarios.Count - 1)
            {
                currentIndex++;
                MostrarUsuario();
            }
        }

        private void btnUltimo_Click(object sender, RoutedEventArgs e)
        {
            currentIndex = usuarios.Count - 1;
            MostrarUsuario();
        }

        // Métodos de botones de acción (Nuevo, Eliminar, Cancelar, Guardar)
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            txtApellidoNombre.Clear();
            txtNombreUsuario.Clear();
            txtContrasena.Clear();
            currentIndex = usuarios.Count; // Ajustar el índice para el nuevo usuario
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < usuarios.Count)
            {
                var usuario = usuarios[currentIndex];

                if (usuario.Rol_Codigo == 1)
                {
                    MessageBox.Show("No se puede eliminar un usuario con rol de administrador.");
                    return;
                }

                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?",
                             "Confirmación de Eliminación",
                             MessageBoxButton.YesNo);
                if (result != MessageBoxResult.Yes)
                    return;

                TrabajarUsuario.borrar_usuario(usuario.Usu_NombreUsuario);

                // Elimina el usuario de la colección local y actualiza la interfaz
                usuarios.RemoveAt(currentIndex);
                if (currentIndex >= usuarios.Count)
                    currentIndex = usuarios.Count - 1;
                MostrarUsuario();
            }
            MessageBox.Show("Usuario eliminado exitosamente");
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MostrarUsuario();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el Rol_Codigo de la selección actual del ComboBox
            int rolCodigo = (int)cmbRoles.SelectedValue;

            // Verificar si ya existe un usuario con el mismo nombre de usuario solo en el caso de un nuevo usuario
            if (currentIndex == usuarios.Count)
            {
                bool existe = TrabajarUsuario.existe_usuario(txtNombreUsuario.Text);
                if (existe)
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre de usuario.");
                    return;
                }

                // Creación de un nuevo usuario
                Usuario nuevoUsuario = new Usuario
                {
                    Usu_ApellidoNombre = txtApellidoNombre.Text,
                    Usu_NombreUsuario = txtNombreUsuario.Text,
                    Usu_Contraseña = txtContrasena.Password,
                    Rol_Codigo = rolCodigo
                };

                // Obtenemos el ID del nuevo usuario
                nuevoUsuario.Usu_ID = TrabajarUsuario.alta_usuario(nuevoUsuario.Usu_NombreUsuario, nuevoUsuario.Usu_Contraseña, nuevoUsuario.Usu_ApellidoNombre, nuevoUsuario.Rol_Codigo);

                usuarios.Add(nuevoUsuario);
                currentIndex = usuarios.Count - 1;
                MessageBox.Show("Usuario guardado exitosamente");
            }
            else
            {
                var usuario = usuarios[currentIndex];

                // Verifica si el usuario actual es administrador y si el rol ha cambiado
                if (usuario.Rol_Codigo == 1 && rolCodigo != usuario.Rol_Codigo)
                {
                    MessageBox.Show("No se puede modificar el rol de un usuario administrador.");
                    return;
                }

                ModificarUsuario(usuario, txtApellidoNombre.Text, txtNombreUsuario.Text, txtContrasena.Password, rolCodigo);
            }

            MostrarUsuario();
        }


        private void ModificarUsuario(Usuario usuario, string apellidoNombre, string nombreUsuario, string contrasena, int rolCodigo)
        {
            // Verificar si el nombre de usuario ya existe para otro usuario
            bool existe = TrabajarUsuario.ExisteUsuarioConMismoNombre(nombreUsuario, usuario.Usu_ID);
            if (existe)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre de usuario.");
                return;
            }

            usuario.Usu_ApellidoNombre = apellidoNombre;
            usuario.Usu_NombreUsuario = nombreUsuario;
            usuario.Usu_Contraseña = contrasena;
            usuario.Rol_Codigo = rolCodigo;

            TrabajarUsuario.modificar_usuario(usuario.Usu_ID, usuario.Usu_NombreUsuario, usuario.Usu_Contraseña, usuario.Usu_ApellidoNombre, usuario.Rol_Codigo);
            MessageBox.Show("Usuario modificado exitosamente");
        }




        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }

        private void btnListadoUsuarios_Click(object sender, RoutedEventArgs e)
        {
            // Obtener la colección de usuarios
            ObservableCollection<Usuario> usuarios = TrabajarUsuario.TraerUsuario();

            this.Hide();
            ListadoUsuarios listadoUsuarios = new ListadoUsuarios(usuarios, this);
            listadoUsuarios.Show();
        }
    }
}
