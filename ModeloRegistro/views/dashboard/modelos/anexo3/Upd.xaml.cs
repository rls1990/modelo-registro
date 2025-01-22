using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo3
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo3_m manager = new model.Anexo3_m(Global.sqlite);
        private model.Anexo3_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo3());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo3_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.nombre_apellido)||
                string.IsNullOrEmpty(model.fecha_nacimiento)||
                string.IsNullOrEmpty(model.municipio)||
                string.IsNullOrEmpty(model.provincia)||
                string.IsNullOrEmpty(model.registro)||
                string.IsNullOrEmpty(model.municipio_registro)||
                string.IsNullOrEmpty(model.provincia_registro)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.fecha_asiento)||
                string.IsNullOrEmpty(model.nombre_padre)||
                string.IsNullOrEmpty(model.nombre_madre)||
                string.IsNullOrEmpty(model.legalizacion_minred)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo3_e es válida
        }
    }
}
