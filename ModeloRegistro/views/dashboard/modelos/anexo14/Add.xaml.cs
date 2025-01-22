using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo14
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo14_m manager = new model.Anexo14_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo14());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }
        private bool ValidarAnexo( model.Anexo14_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.quien_suscribe)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.folio_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_identidad_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.estado_civil_antes_matrimonio_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.ocupacion_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.padre_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.madre_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.domicilio_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.folio_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_identidad_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.estado_civil_antes_matrimonio_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.ocupacion_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.padre_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.madre_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.domicilio_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.observaciones_la_contrayente)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.folio_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_formalizacion)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_funcionario_expidió_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.cargo_funcionario_expidió_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_solicitud);
        }

    }
}
