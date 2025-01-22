using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo9
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo9_m manager = new model.Anexo9_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo9());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo9_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.encargado_registro_civil)||
                string.IsNullOrEmpty(model.municipio_encargado)||
                string.IsNullOrEmpty(model.provincia_encargado)||
                string.IsNullOrEmpty(model.nombre)||
                string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.tomo_certificado)||
                string.IsNullOrEmpty(model.folio_certificado)||
                string.IsNullOrEmpty(model.fecha_nacimiento)||
                string.IsNullOrEmpty(model.municipio_persona)||
                string.IsNullOrEmpty(model.provincia_persona)||
                string.IsNullOrEmpty(model.padre)||
                string.IsNullOrEmpty(model.madre)||
                string.IsNullOrEmpty(model.legalizacion_minrex)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_de_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo9_e es válida
        }

    }
}
