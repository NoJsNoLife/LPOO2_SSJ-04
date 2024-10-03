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
    }
}
