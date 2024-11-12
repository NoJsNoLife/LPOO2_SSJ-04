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
    /// Lógica de interacción para AltaAtleta.xaml
    /// </summary>
    public partial class AltaAtleta : Window
    {

        private Window ventanaAnterior { get; set; }
        public AltaAtleta(Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
        }

        private void btnCargarDatos_Click(object sender, RoutedEventArgs e)
        {
            if (TrabajarAtleta.existe_atleta(txtDNI.Text))
            {
                MessageBox.Show("Ya existe un atleta con este DNI", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    // Capturar los datos ingresados por el usuario
                    string dni = txtDNI.Text;
                    string apellido = txtApellido.Text;
                    string nombre = txtNombre.Text;
                    string nacionalidad = txtNacionalidad.Text;
                    string entrenador = txtEntrenador.Text;
                    string genero = rbtMasculino.IsChecked == true ? "Masculino" :
                                    rbtFemenino.IsChecked == true ? "Femenino" :
                                    rbtNoBinario.IsChecked == true ? "No Binario" : "Prefiero no decirlo";
                    double altura = Convert.ToDouble(txtAltura.Text);
                    double peso = Convert.ToDouble(txtPeso.Text);
                    DateTime nacimiento = dpFechaNac.SelectedDate.Value;
                    string direccion = txtDireccion.Text;
                    string email = txtEmail.Text;

                    // Llamar al método alta_atleta
                    TrabajarAtleta.alta_atleta(dni, apellido, nombre, nacionalidad, entrenador, genero, altura, peso, nacimiento, direccion, email);

                    // Mostrar un mensaje de éxito
                    MessageBox.Show("Atleta agregado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Mostrar un mensaje de éxito con los datos ingresados
                    string mensaje = $"Atleta agregado correctamente con los siguientes datos:\n\n" +
                                     $"DNI: {dni}\n" +
                                     $"Apellido: {apellido}\n" +
                                     $"Nombre: {nombre}\n" +
                                     $"Nacionalidad: {nacionalidad}\n" +
                                     $"Entrenador: {entrenador}\n" +
                                     $"Género: {genero}\n" +
                                     $"Altura: {altura} cm\n" +
                                     $"Peso: {peso} kg\n" +
                                     $"Fecha de Nacimiento: {nacimiento.ToShortDateString()}\n" +
                                     $"Dirección: {direccion}\n" +
                                     $"Email: {email}";

                    MessageBox.Show(mensaje, "Datos del Atleta", MessageBoxButton.OK, MessageBoxImage.Information);

                    // Volver a la ventana principal
                    this.Hide();
                    Principal principal = new Principal(1, this);
                    principal.Show();
                }
                catch (Exception ex)
                {
                    // Manejar cualquier error que ocurra
                    MessageBox.Show($"Error al agregar atleta: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.btnAtras_Click(sender, e);
        }
    }
}
