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
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        private Window VentanaAnterior { get; set; }
        public Principal(int rol_codigo, Window ventanaAnterior)
        {
            InitializeComponent();
            this.VentanaAnterior = ventanaAnterior;
        }

        private void btnCategorias_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ABMCategoria abmCategoria = new ABMCategoria(this);
            abmCategoria.Show();
        }

        private void btnDisciplinas_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ABMDisciplina abMDisciplina = new ABMDisciplina(this);
            abMDisciplina.Show();

        }

        private void btnAtletas_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ABMAtleta abmAtleta = new ABMAtleta(this);
            abmAtleta.Show();
        }

        private void btnCompetencias_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ABMCompetencia abmCompetencia= new ABMCompetencia(this);
            abmCompetencia.Show();
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ABMUsuario abmUsuario = new ABMUsuario(this);
            abmUsuario.Show();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            VentanaAnterior.Show();
        }
    }
}
