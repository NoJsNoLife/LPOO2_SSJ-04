using System.Net;
using System.Windows;
using ClasesBase;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vistas
{
    public partial class ModificarAtleta : Window
    {
        private int atletaId;
        private Window ventanaAnterior { get; set; }

        public ModificarAtleta(int id, Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            atletaId = id;
            CargarDatosAtleta();
        }

        private void CargarDatosAtleta()
        {
            Atleta atleta = TrabajarAtleta.traer_atleta_por_id(atletaId);
            if (atleta != null)
            {
                txtDNI.Text = atleta.Atl_DNI;
                txtApellido.Text = atleta.Atl_Apellido;
                txtNombre.Text = atleta.Atl_Nombre;
                txtNacionalidad.Text = atleta.Atl_Nacionalidad;
                txtEntrenador.Text = atleta.Atl_Entrenador;
                txtAltura.Text = atleta.Atl_Altura.ToString();
                txtPeso.Text = atleta.Atl_Peso.ToString();
                dpFechaNac.Text = atleta.Atl_FechaNac.ToString();
                txtDireccion.Text = atleta.Atl_Direccion;
                txtEmail.Text = atleta.Atl_email;

                // Seleccionar el RadioButton correspondiente al género
                switch (atleta.Atl_Genero)
                {
                    case 'M':
                        rbtMasculino.IsChecked = true;
                        break;
                    case 'F':
                        rbtFemenino.IsChecked = true;
                        break;
                    case 'N':
                        rbtNoBinario.IsChecked = true;
                        break;
                    case 'P':
                        rbtPrefieroNoDecirlo.IsChecked = true;
                        break;
                    default:
                        // Manejar el caso en que el género no sea reconocido
                        rbtMasculino.IsChecked = false;
                        rbtFemenino.IsChecked = false;
                        rbtNoBinario.IsChecked = false;
                        rbtPrefieroNoDecirlo.IsChecked = false;
                        break;
                }
            }
            else
            {
                MessageBox.Show("Atleta no encontrado");
            }
        }


        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validar si todos los campos necesarios están llenos
                if (string.IsNullOrWhiteSpace(txtDNI.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                    string.IsNullOrWhiteSpace(txtEntrenador.Text) || string.IsNullOrWhiteSpace(txtAltura.Text) ||
                    string.IsNullOrWhiteSpace(txtPeso.Text) || string.IsNullOrWhiteSpace(dpFechaNac.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos.", "Campos incompletos", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Convertir los datos necesarios
                double altura, peso;
                if (!double.TryParse(txtAltura.Text, out altura) || !double.TryParse(txtPeso.Text, out peso))
                {
                    MessageBox.Show("Altura y peso deben ser valores numéricos válidos.", "Datos inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                DateTime fechaNacimiento;
                if (!DateTime.TryParse(dpFechaNac.Text, out fechaNacimiento))
                {
                    MessageBox.Show("Fecha de nacimiento inválida.", "Datos inválidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Capturar el valor del género y convertirlo a char
                char genero = rbtMasculino.IsChecked == true ? 'M' :
                              rbtFemenino.IsChecked == true ? 'F' :
                              rbtNoBinario.IsChecked == true ? 'N' : 'P'; // 'N' para No Binario y 'P' para Prefiero no decirlo

                // Crear objeto Atleta con los datos del formulario
                Atleta atleta = new Atleta()
                {
                    Atl_ID = atletaId,
                    Atl_DNI = txtDNI.Text,
                    Atl_Apellido = txtApellido.Text,
                    Atl_Nombre = txtNombre.Text,
                    Atl_Nacionalidad = txtNacionalidad.Text,
                    Atl_Entrenador = txtEntrenador.Text,
                    Atl_Genero = genero,
                    Atl_Altura = altura,
                    Atl_Peso = peso,
                    Atl_FechaNac = fechaNacimiento,
                    Atl_Direccion = txtDireccion.Text,
                    Atl_email = txtEmail.Text,
                };

                TrabajarAtleta.ActualizarAtleta(atleta);

                // Mostrar un mensaje de éxito
                MessageBox.Show("Atleta actualizado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                // Volver a la ventana anterior
                ventanaAnterior.Show();
                Close();
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que ocurra
                MessageBox.Show($"Error al actualizar atleta: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }





        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            Close();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            Close();
        }

    }
}
