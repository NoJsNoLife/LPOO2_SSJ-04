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
    /// Lógica de interacción para AltaDisciplina.xaml
    /// </summary>
    public partial class AltaDisciplina : Window
    {
        private Window ventanaAnterior { get; set; }
        public AltaDisciplina(Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
        }

        private void btnCargarDatosDisciplina_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Capturar los datos ingresados por el usuario
                string nombre = txtNombreDisciplina.Text;
                string descripcion = txtDescripcionDisciplina.Text;

                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(descripcion))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }


                // Llamar al método para agregar la disciplina
                TrabajarDisciplina.alta_disciplina(nombre, descripcion);

                MessageBox.Show("Disciplina agregada correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Mostrar un mensaje de éxito
                string mensaje = $"Disciplina agregada correctamente con los siguientes datos:\n\n" +
                                 $"Nombre: {nombre}\n" +
                                 $"Descripción: {descripcion}";
                MessageBox.Show(mensaje, "Datos de la Disciplina", MessageBoxButton.OK, MessageBoxImage.Information);

                // Limpiar los campos
                txtNombreDisciplina.Clear();
                txtDescripcionDisciplina.Clear();

                // Volver a la ventana principal o realizar otra acción
                this.Hide();
                Principal principal = new Principal(1, this);  // Suponiendo que hay una clase Principal
                principal.Show();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra
                MessageBox.Show($"Error al agregar disciplina: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.btnAtras_Click(sender, e);
        }
    }
}
