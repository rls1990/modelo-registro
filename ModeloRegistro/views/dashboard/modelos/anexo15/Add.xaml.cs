using ModeloRegistro.model;
using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo15
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo15_m manager = new model.Anexo15_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo15());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo15_e()
            {
                nombre_fallecido=ValidarCampo(nombre_fallecido.Text),
                m=ValidarCampo(m.IsChecked.ToString()),
                f=ValidarCampo(f.IsChecked.ToString()),
                primer_apellido_fallecido=ValidarCampo(primer_apellido_fallecido.Text),
                segundo_apellido_fallecido=ValidarCampo(segundo_apellido_fallecido.Text),
                hora_fallecido=ValidarCampo(hora_fallecido.Text),
                fecha_fallecimineto=ValidarCampo(fecha_fallecimineto.SelectedDate?.ToString("yyyy-MM-dd")),
                lugar_nacimineto_fallecido=ValidarCampo(lugar_nacimineto_fallecido.Text),
                municipio_provincia_pais_fallecido=ValidarCampo(municipio_provincia_pais_fallecido.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                pasaporte_fallecido=ValidarCampo(pasaporte_fallecido.Text),
                edad_fallecido=ValidarCampo(edad_fallecido.Text),
                registro_civil_fallecido=ValidarCampo(registro_civil_fallecido.Text),
                tomo_fallecido=ValidarCampo(tomo_fallecido.Text),
                folio_fallecido=ValidarCampo(folio_fallecido.Text),
                estado_civil_fallecido=ValidarCampo(estado_civil_fallecido.Text),
                ocupacion_fallecido=ValidarCampo(ocupacion_fallecido.Text),
                padre_fallecido=ValidarCampo(padre_fallecido.Text),
                madre_fallecido=ValidarCampo(madre_fallecido.Text),
                domicilio_fallecido=ValidarCampo(domicilio_fallecido.Text),

                fecha_defuncion=ValidarCampo(fecha_defuncion.SelectedDate?.ToString("yyyy-MM-dd")),
                hora_defuncion=ValidarCampo(hora_defuncion.Text),
                lugar_fallecimiento=ValidarCampo(lugar_fallecimiento.Text),
                causa_muerte_fallecimiento=ValidarCampo(causa_muerte_fallecimiento.Text),
                enfermedad_causa_fallecimiento=ValidarCampo(enfermedad_causa_fallecimiento.Text),

                nombre_medico_certifica_fallecimiento=ValidarCampo(nombre_medico_certifica_fallecimiento.Text),
                lugar_cepultura=ValidarCampo(lugar_cepultura.Text),

                registro_civil=ValidarCampo(registro_civil.Text),
                tomo=ValidarCampo(tomo.Text),
                folio=ValidarCampo(folio.Text),

                fecha_certificado=ValidarCampo(fecha_certificado.SelectedDate?.ToString("yyyy-MM-dd")),

                nombre_apellido_solicita=ValidarCampo(nombre_apellido_solicita.Text),
                nro_pasaporte_carnet=ValidarCampo(nro_pasaporte_carnet.Text),

                parentesco_fallecido=ValidarCampo(parentesco_fallecido.Text),
                direccion_solicita=ValidarCampo(direccion_solicita.Text),

                nombre_apellido_funcionario_consular=ValidarCampo(nombre_apellido_funcionario_consular.Text)
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
        private bool ValidarAnexo( Anexo15_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            //return !string.IsNullOrWhiteSpace(anexo.nombre_fallecido)&&
            //       //!string.IsNullOrWhiteSpace(anexo.m)&&
            //       //!string.IsNullOrWhiteSpace(anexo.f)&&
            //       !string.IsNullOrWhiteSpace(anexo.primer_apellido_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.segundo_apellido_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.hora_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_fallecimineto)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.municipio_provincia_pais_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.edad_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.registro_civil_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.tomo_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.folio_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.estado_civil_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.ocupacion_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.padre_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.madre_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.domicilio_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_defuncion)&&
            //       !string.IsNullOrWhiteSpace(anexo.hora_defuncion)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_fallecimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.causa_muerte_fallecimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.enfermedad_causa_fallecimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_medico_certifica_fallecimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_cepultura)&&
            //       !string.IsNullOrWhiteSpace(anexo.registro_civil)&&
            //       !string.IsNullOrWhiteSpace(anexo.tomo)&&
            //       !string.IsNullOrWhiteSpace(anexo.folio)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellido_solicita)&&
            //       !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_carnet)&&
            //       !string.IsNullOrWhiteSpace(anexo.parentesco_fallecido)&&
            //       !string.IsNullOrWhiteSpace(anexo.direccion_solicita)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellido_funcionario_consular);

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
