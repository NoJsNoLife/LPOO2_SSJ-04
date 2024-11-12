using ClasesBase;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para ABMAtleta.xaml
    /// </summary>
    public partial class ABMAtleta : Window
    {

        private Window ventanaAnterior { get; set; }
        public ABMAtleta(Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
        }

        private void CargarAtletaPorID(int id)
        {
            Atleta atleta = TrabajarAtleta.traer_atleta_por_id(id);

            if (atleta != null)
            {
                List<Atleta> listaAtleta = new List<Atleta> { atleta };
                dataGridAtletas.ItemsSource = listaAtleta;
            }
            else
            {
                MessageBox.Show("Atleta no encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnBuscarAtleta_Click(object sender, RoutedEventArgs e)
        {
            if (txtAtletaID.Text != "")
            {
                int id = Convert.ToInt32(txtAtletaID.Text);
                CargarAtletaPorID(id);
            }
            else
            {
                MessageBox.Show("Ingrese un ID", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }

        private void btnAgregarAtleta_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AltaAtleta altaAtleta = new AltaAtleta(this);
            altaAtleta.Show();
        }

        private void btnModificarAtleta_Click(object sender, RoutedEventArgs e)
        {


            if (int.TryParse(txtAtletaID.Text, out int atletaId))
            {
                Atleta atleta = TrabajarAtleta.traer_atleta_por_id(atletaId);
                if (atleta == null)
                {
                    MessageBox.Show("Atleta no encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                ModificarAtleta modificarAtleta = new ModificarAtleta(atletaId,this);
                modificarAtleta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }


    }
}

