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
            var anexo = new model.Anexo14_e()
            {
                quien_suscribe=quien_suscribe.Text,
                nombre_contrayente=nombre_contrayente.Text,
                ciudadania_contrayente=ciudadania_contrayente.Text,
                primer_apellido_contrayente=primer_apellido_contrayente.Text,
                segundo_apellido_contrayente=segundo_apellido_contrayente.Text,
                registro_civil_contrayente=registro_civil_contrayente.Text,
                tomo_contrayente=tomo_contrayente.Text,
                folio_contrayente=folio_contrayente.Text,
                lugar_nacimiento_contrayente=lugar_nacimiento_contrayente.Text,
                fecha_nacimiento_contrayente=fecha_nacimiento_contrayente.SelectedDate?.ToString("yyyy-MM-dd"),
                nro_pasaporte_identidad_contrayente=nro_pasaporte_identidad_contrayente.Text,
                estado_civil_antes_matrimonio_contrayente=estado_civil_antes_matrimonio_contrayente.Text,
                ocupacion_contrayente=ocupacion_contrayente.Text,
                padre_contrayente=padre_contrayente.Text,
                madre_contrayente=madre_contrayente.Text,
                domicilio_contrayente=domicilio_contrayente.Text,

                nombre_la_contrayente=nombre_la_contrayente.Text,
                ciudadania_la_contrayente=ciudadania_la_contrayente.Text,
                primer_apellido_la_contrayente=primer_apellido_la_contrayente.Text,
                segundo_apellido_la_contrayente=segundo_apellido_la_contrayente.Text,
                registro_civil_la_contrayente=registro_civil_la_contrayente.Text,
                tomo_la_contrayente=tomo_la_contrayente.Text,
                folio_la_contrayente=folio_la_contrayente.Text,
                lugar_nacimiento_la_contrayente=lugar_nacimiento_la_contrayente.Text,
                fecha_nacimiento_la_contrayente=fecha_nacimiento_la_contrayente.SelectedDate?.ToString("yyyy-MM-dd"),
                nro_pasaporte_identidad_la_contrayente=nro_pasaporte_identidad_la_contrayente.Text,
                estado_civil_antes_matrimonio_la_contrayente=estado_civil_antes_matrimonio_la_contrayente.Text,
                ocupacion_la_contrayente=ocupacion_la_contrayente.Text,
                padre_la_contrayente=padre_la_contrayente.Text,
                madre_la_contrayente=madre_la_contrayente.Text,
                domicilio_la_contrayente=domicilio_la_contrayente.Text,

                observaciones_la_contrayente=observaciones_la_contrayente.Text,

                lugar_certificado=lugar_certificado.Text,
                tomo_certificado=tomo_certificado.Text,
                folio_certificado=folio_certificado.Text,

                fecha_formalizacion=fecha_formalizacion.SelectedDate?.ToString("yyyy-MM-dd"),

                nombre_funcionario_expidió_certificado=nombre_funcionario_expidió_certificado.Text,
                cargo_funcionario_expidió_certificado=cargo_funcionario_expidió_certificado.Text,

                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")
            };

            if(ValidarAnexo(anexo))
            {
                manager.save(anexo);
                MessageBox.Show("Anexo guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
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
