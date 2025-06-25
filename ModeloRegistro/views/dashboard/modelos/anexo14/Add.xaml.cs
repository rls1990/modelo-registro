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
                quien_suscribe=ValidarCampo(quien_suscribe.Text),
                nombre_contrayente=ValidarCampo(nombre_contrayente.Text),
                ciudadania_contrayente=ValidarCampo(ciudadania_contrayente.Text),
                primer_apellido_contrayente=ValidarCampo(primer_apellido_contrayente.Text),
                segundo_apellido_contrayente=ValidarCampo(segundo_apellido_contrayente.Text),
                registro_civil_contrayente=ValidarCampo(registro_civil_contrayente.Text),
                tomo_contrayente=ValidarCampo(tomo_contrayente.Text),
                folio_contrayente=ValidarCampo(folio_contrayente.Text),
                lugar_nacimiento_contrayente=ValidarCampo(lugar_nacimiento_contrayente.Text),
                fecha_nacimiento_contrayente=ValidarCampo(fecha_nacimiento_contrayente.SelectedDate?.ToString("yyyy-MM-dd")),
                nro_pasaporte_identidad_contrayente=ValidarCampo(nro_pasaporte_identidad_contrayente.Text),
                estado_civil_antes_matrimonio_contrayente=ValidarCampo(estado_civil_antes_matrimonio_contrayente.Text),
                ocupacion_contrayente=ValidarCampo(ocupacion_contrayente.Text),
                padre_contrayente=ValidarCampo(padre_contrayente.Text),
                madre_contrayente=ValidarCampo(madre_contrayente.Text),
                domicilio_contrayente=ValidarCampo(domicilio_contrayente.Text),

                nombre_la_contrayente=ValidarCampo(nombre_la_contrayente.Text),
                ciudadania_la_contrayente=ValidarCampo(ciudadania_la_contrayente.Text),
                primer_apellido_la_contrayente=ValidarCampo(primer_apellido_la_contrayente.Text),
                segundo_apellido_la_contrayente=ValidarCampo(segundo_apellido_la_contrayente.Text),
                registro_civil_la_contrayente=ValidarCampo(registro_civil_la_contrayente.Text),
                tomo_la_contrayente=ValidarCampo(tomo_la_contrayente.Text),
                folio_la_contrayente=ValidarCampo(folio_la_contrayente.Text),
                lugar_nacimiento_la_contrayente=ValidarCampo(lugar_nacimiento_la_contrayente.Text),
                fecha_nacimiento_la_contrayente=ValidarCampo(fecha_nacimiento_la_contrayente.SelectedDate?.ToString("yyyy-MM-dd")),
                nro_pasaporte_identidad_la_contrayente=ValidarCampo(nro_pasaporte_identidad_la_contrayente.Text),
                estado_civil_antes_matrimonio_la_contrayente=ValidarCampo(estado_civil_antes_matrimonio_la_contrayente.Text),
                ocupacion_la_contrayente=ValidarCampo(ocupacion_la_contrayente.Text),
                padre_la_contrayente=ValidarCampo(padre_la_contrayente.Text),
                madre_la_contrayente=ValidarCampo(madre_la_contrayente.Text),
                domicilio_la_contrayente=ValidarCampo(domicilio_la_contrayente.Text),

                observaciones_la_contrayente=ValidarCampo(observaciones_la_contrayente.Text),

                lugar_certificado=ValidarCampo(lugar_certificado.Text),
                tomo_certificado=ValidarCampo(tomo_certificado.Text),
                folio_certificado=ValidarCampo(folio_certificado.Text),

                fecha_formalizacion=ValidarCampo(fecha_formalizacion.SelectedDate?.ToString("yyyy-MM-dd")),

                nombre_funcionario_expidió_certificado=ValidarCampo(nombre_funcionario_expidió_certificado.Text),
                cargo_funcionario_expidió_certificado=ValidarCampo(cargo_funcionario_expidió_certificado.Text),

                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
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
            //return !string.IsNullOrWhiteSpace(anexo.quien_suscribe)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.primer_apellido_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.segundo_apellido_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.registro_civil_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.tomo_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.folio_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_identidad_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.estado_civil_antes_matrimonio_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.ocupacion_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.padre_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.madre_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.domicilio_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.primer_apellido_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.segundo_apellido_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.registro_civil_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.tomo_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.folio_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_identidad_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.estado_civil_antes_matrimonio_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.ocupacion_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.padre_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.madre_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.domicilio_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.observaciones_la_contrayente)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.tomo_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.folio_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_formalizacion)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_funcionario_expidió_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.cargo_funcionario_expidió_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_solicitud);

            return true;
        }

        private string ValidarCampo( string val )
        {
            string res = "";
            if(!string.IsNullOrWhiteSpace(val))
                res=val;
            return res;
        }
    }
}
