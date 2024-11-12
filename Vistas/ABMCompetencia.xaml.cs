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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class ABMCompetencia : Window
    {
        private Window ventanaAnterior { get; set; }
        public ABMCompetencia(Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
            CargarCompetencias();
        }

        private void CargarCompetencias()
        {

            DataTable dtCompetencias = TrabajarCompetencia.TraerCompetencias();
            dataGridCompetencias.ItemsSource = dtCompetencias.DefaultView;
        }

        private void ButtonCerrar_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
          
        }

        private void ButtonEstados_Click(object sender, RoutedEventArgs e)
        {
            EstadosCompetencias estadosCompetencias = new EstadosCompetencias(this);
            estadosCompetencias.Show();
            this.Hide();
        }
    }
}
