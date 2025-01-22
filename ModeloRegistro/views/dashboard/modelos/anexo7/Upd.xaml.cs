using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo7
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo7_m manager = new model.Anexo7_m(Global.sqlite);
        private model.Anexo7_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo7());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo7_e model )
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
                string.IsNullOrEmpty(model.fecha_defuncion)||
                string.IsNullOrEmpty(model.municipio_fallecimineto)||
                string.IsNullOrEmpty(model.provincia_fallecimineto)||
                string.IsNullOrEmpty(model.donde_fue_velado)||
                string.IsNullOrEmpty(model.municipio_funeraria)||
                string.IsNullOrEmpty(model.provincia_funeraria)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.legalizacion_minrex)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_de_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo7_e es válida
        }
    }
}
