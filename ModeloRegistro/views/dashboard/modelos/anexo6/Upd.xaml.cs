using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo6
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo6_m manager = new model.Anexo6_m(Global.sqlite);
        private model.Anexo6_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo6());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo6_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.nombre_apellido_hombre)||
                string.IsNullOrEmpty(model.nombre_apellido_mujer)||
                string.IsNullOrEmpty(model.tribunal_dicto_sentencia)||
                string.IsNullOrEmpty(model.nombre_secretario_actuante)||
                string.IsNullOrEmpty(model.fecha_dicto_sentencia)||
                string.IsNullOrEmpty(model.fecha_firmeza_sentencia)||
                string.IsNullOrEmpty(model.no_sentencia)||
                string.IsNullOrEmpty(model.no_radicacion)||
                string.IsNullOrEmpty(model.legalizacion_minred)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo6_e es válida
        }
    }
}
