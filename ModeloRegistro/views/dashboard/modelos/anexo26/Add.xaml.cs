using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo26
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo26_m manager = new model.Anexo26_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo26());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo26_e()
            {
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                nombre_poderante=ValidarCampo(nombre_poderante.Text),
                sexo_poderante=ValidarCampo(sexo_poderante.Text),
                lugar_nacimiento_municipio_poderante=ValidarCampo(lugar_nacimiento_municipio_poderante.Text),
                lugar_nacimiento_provincia_poderante=ValidarCampo(lugar_nacimiento_provincia_poderante.Text),
                fecha_nacimineto_poderante=ValidarCampo(fecha_nacimineto_poderante.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_poderante=ValidarCampo(estado_civil_poderante.Text),
                ciudadania_poderante=ValidarCampo(ciudadania_poderante.Text),
                ocupacion_poderante=ValidarCampo(ocupacion_poderante.Text),
                direccion_particular_poderante=ValidarCampo(direccion_particular_poderante.Text),
                carne_pasaporte_poderante=ValidarCampo(carne_pasaporte_poderante.Text),
                condicion_migratoria_poderante=ValidarCampo(condicion_migratoria_poderante.Text),
                correo_poderante=ValidarCampo(correo_poderante.Text),
                celular_poderante=ValidarCampo(celular_poderante.Text),

                nombre_apoderado=ValidarCampo(nombre_apoderado.Text),
                sexo_apoderado=ValidarCampo(sexo_apoderado.Text),
                lugar_nacimiento_municipio_apoderado=ValidarCampo(lugar_nacimiento_municipio_apoderado.Text),
                lugar_nacimiento_provincia_apoderado=ValidarCampo(lugar_nacimiento_provincia_apoderado.Text),
                fecha_nacimineto_apoderado=ValidarCampo(fecha_nacimineto_apoderado.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_apoderado=ValidarCampo(estado_civil_apoderado.Text),
                ciudadania_apoderado=ValidarCampo(ciudadania_apoderado.Text),
                ocupacion_apoderado=ValidarCampo(ocupacion_apoderado.Text),
                direccion_particular_apoderado=ValidarCampo(direccion_particular_apoderado.Text),
                carne_pasaporte_apoderado=ValidarCampo(carne_pasaporte_apoderado.Text),
                condicion_migratoria_apoderado=ValidarCampo(condicion_migratoria_apoderado.Text),

                nombre_contrayente=ValidarCampo(nombre_contrayente.Text),
                sexo_contrayente=ValidarCampo(sexo_contrayente.Text),
                lugar_nacimiento_municipio_contrayente=ValidarCampo(lugar_nacimiento_municipio_contrayente.Text),
                lugar_nacimiento_provincia_contrayente=ValidarCampo(lugar_nacimiento_provincia_contrayente.Text),
                fecha_nacimineto_contrayente=ValidarCampo(fecha_nacimineto_contrayente.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_contrayente=ValidarCampo(estado_civil_contrayente.Text),
                ciudadania_contrayente=ValidarCampo(ciudadania_contrayente.Text),
                ocupacion_contrayente=ValidarCampo(ocupacion_contrayente.Text),
                direccion_particular_contrayente=ValidarCampo(direccion_particular_contrayente.Text),
                carne_pasaporte_contrayente=ValidarCampo(carne_pasaporte_contrayente.Text),
                condicion_migratoria_contrayente=ValidarCampo(condicion_migratoria_contrayente.Text),

                fecha_celebracion=ValidarCampo(fecha_celebracion.SelectedDate?.ToString("yyyy-MM-dd")),
                tomo=ValidarCampo(tomo.Text),
                folio=ValidarCampo(folio.Text),
                registro_civil_municipio=ValidarCampo(registro_civil_municipio.Text),

                patria_potestad=ValidarCampo(patria_potestad.Text),

                nombre_apellido_menor=ValidarCampo(nombre_apellido_menor.Text),

                pension_alimenticia=ValidarCampo(pension_alimenticia.Text),

                regimen_comunicacion=ValidarCampo(regimen_comunicacion.Text)
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

        public bool ValidarAnexo( model.Anexo26_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.fecha_solicitud)||
            //    string.IsNullOrEmpty(model.nombre_poderante)||
            //    string.IsNullOrEmpty(model.sexo_poderante)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_poderante)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_poderante)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_poderante)||
            //    string.IsNullOrEmpty(model.estado_civil_poderante)||
            //    string.IsNullOrEmpty(model.ciudadania_poderante)||
            //    string.IsNullOrEmpty(model.ocupacion_poderante)||
            //    string.IsNullOrEmpty(model.direccion_particular_poderante)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_poderante)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_poderante)||
            //    string.IsNullOrEmpty(model.correo_poderante)||
            //    string.IsNullOrEmpty(model.celular_poderante)||
            //    string.IsNullOrEmpty(model.nombre_apoderado)||
            //    string.IsNullOrEmpty(model.sexo_apoderado)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_apoderado)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_apoderado)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
            //    string.IsNullOrEmpty(model.estado_civil_apoderado)||
            //    string.IsNullOrEmpty(model.ciudadania_apoderado)||
            //    string.IsNullOrEmpty(model.ocupacion_apoderado)||
            //    string.IsNullOrEmpty(model.direccion_particular_apoderado)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_apoderado)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
            //    string.IsNullOrEmpty(model.nombre_contrayente)||
            //    string.IsNullOrEmpty(model.sexo_contrayente)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_contrayente)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_contrayente)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_contrayente)||
            //    string.IsNullOrEmpty(model.estado_civil_contrayente)||
            //    string.IsNullOrEmpty(model.ciudadania_contrayente)||
            //    string.IsNullOrEmpty(model.ocupacion_contrayente)||
            //    string.IsNullOrEmpty(model.direccion_particular_contrayente)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_contrayente)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_contrayente)||
            //    string.IsNullOrEmpty(model.fecha_celebracion)||
            //    string.IsNullOrEmpty(model.tomo)||
            //    string.IsNullOrEmpty(model.folio)||
            //    string.IsNullOrEmpty(model.registro_civil_municipio)||
            //    string.IsNullOrEmpty(model.patria_potestad)||
            //    string.IsNullOrEmpty(model.nombre_apellido_menor)||
            //    string.IsNullOrEmpty(model.pension_alimenticia)||
            //    string.IsNullOrEmpty(model.regimen_comunicacion))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo26_e es válida
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
