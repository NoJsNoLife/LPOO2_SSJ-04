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
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para AltaCategoria.xaml
    /// </summary>
    public partial class AltaCategoria : Window
    {
        private Window ventanaAnterior { get; set; }
        public AltaCategoria(Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
        }



        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }

        private void btnCargarDatosCategoria_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Capturar los datos ingresados por el usuario para la categoría
                string nombreCategoria = txtNombreCategoria.Text;  // Suponiendo que hay un TextBox llamado txtNombreCategoria
                string descripcionCategoria = txtDescripcionCategoria.Text;  // Suponiendo que hay un TextBox llamado txtDescripcionCategoria

                // Llamar al método para dar de alta la categoría (debes definir este método)
                TrabajarCategoria.altaCategoria(nombreCategoria, descripcionCategoria);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Mostrar un mensaje con los datos ingresados
                string mensaje = $"Categoría agregada correctamente con los siguientes datos:\n\n" +
                                 $"Nombre de la categoría: {nombreCategoria}\n" +
                                 $"Descripción: {descripcionCategoria}";

                MessageBox.Show(mensaje, "Datos de la Categoría", MessageBoxButton.OK, MessageBoxImage.Information);

                // Volver a la ventana principal o realizar otra acción
                this.Hide();
                Principal principal = new Principal(1, this);  // Suponiendo que hay una clase Principal
                principal.Show();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra
                MessageBox.Show($"Error al agregar categoría: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.btnAtras_Click(sender, e);
        }
    }
}
