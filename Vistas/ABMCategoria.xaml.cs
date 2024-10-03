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
    /// Lógica de interacción para ABMCategoria.xaml
    /// </summary>
    public partial class ABMCategoria : Window
    {   
        Window ventanaAnterior { get; set; }
        public ABMCategoria(Window referenciaVentana)
        {
            InitializeComponent();
            ventanaAnterior = referenciaVentana;
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }

        private void btnAgregarCategoria_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AltaCategoria altaCategoria = new AltaCategoria(this);
            altaCategoria.Show();
        }
    }
}
