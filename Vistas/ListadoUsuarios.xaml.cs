using ClasesBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para ListadoUsuarios.xaml
    /// </summary>
    public partial class ListadoUsuarios : Window
    {
        private Window ventanaAnterior { get; set; }
        private ObservableCollection<Usuario> usuariosOriginales; // Lista de todos los usuarios
        public ListadoUsuarios(ObservableCollection<Usuario> usuarios, Window referenciaVentana)
        {
            InitializeComponent();

            ventanaAnterior = referenciaVentana;
            // Ordenar la colección por nombre de usuario en forma ascendente
            usuariosOriginales = new ObservableCollection<Usuario>(usuarios.OrderBy(u => u.Usu_NombreUsuario));
            dataGridUsuarios.ItemsSource = usuariosOriginales;
        }

        // Evento para filtrar la lista al cambiar el texto
        private void txtFiltro_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filtro = txtFiltro.Text.ToLower();

            // Filtrar usuarios cuyos nombres contienen el texto del filtro
            var usuariosFiltrados = new ObservableCollection<Usuario>(
                usuariosOriginales.Where(u => u.Usu_NombreUsuario.ToLower().Contains(filtro))
            );

            // Actualizar el DataGrid con la colección filtrada
            dataGridUsuarios.ItemsSource = usuariosFiltrados;
        }
        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            ventanaAnterior.Show();
            this.Close();
        }
    }
}
