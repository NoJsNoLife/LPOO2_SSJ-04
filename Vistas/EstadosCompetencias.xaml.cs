using ClasesBase;
using System.Windows;
using System.Windows.Controls;

namespace Vistas
{
    public partial class EstadosCompetencias : Window
    {
        private Window ventanaAnterior { get; set; }

        public EstadosCompetencias(Window ventanaAnterior)
        {
            InitializeComponent();
            this.ventanaAnterior = ventanaAnterior;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        public void Volver_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }
    }
}
