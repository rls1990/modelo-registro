using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo5
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo5_m manager = new model.Anexo5_m(Global.sqlite);
        private model.Anexo5_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo5());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo5_e model )
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
                string.IsNullOrEmpty(model.fecha_matrimonio)||
                string.IsNullOrEmpty(model.ciudad_matrimonio)||
                string.IsNullOrEmpty(model.provincia_matrimonio)||
                string.IsNullOrEmpty(model.pais_matrimonio)||
                string.IsNullOrEmpty(model.registro)||
                string.IsNullOrEmpty(model.municipio_registro)||
                string.IsNullOrEmpty(model.provincia_registro)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.legalizacion_minred)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo5_e es válida
        }
    }
}
