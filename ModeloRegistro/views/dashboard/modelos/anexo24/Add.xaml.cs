using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo24
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo24_m manager = new model.Anexo24_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,System.Windows.RoutedEventArgs e )
        {
            PageService.toPage(new Anexo24());
        }

        private void Button_Click_1( object sender,System.Windows.RoutedEventArgs e )
        {
            var anexo = new model.Anexo24_e()
            {
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                nombre=ValidarCampo(nombre.Text),
                lugar_nacimineto_municipio=ValidarCampo(lugar_nacimineto_municipio.Text),
                lugar_nacimineto_provincia=ValidarCampo(lugar_nacimineto_provincia.Text),
                fecha_nacimineto=ValidarCampo(fecha_nacimineto.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil=ValidarCampo(estado_civil.Text),
                ciudadania=ValidarCampo(ciudadania.Text),
                ocupacion=ValidarCampo(ocupacion.Text),
                direccion=ValidarCampo(direccion.Text),
                carnet_pasaporte=ValidarCampo(carnet_pasaporte.Text),
                nombre_apellido_padres=ValidarCampo(nombre_apellido_padres.Text),
                condicion_migratoria=ValidarCampo(condicion_migratoria.Text),
                correo=ValidarCampo(correo.Text),
                celular=ValidarCampo(celular.Text),
                nombre_apoderado=ValidarCampo(nombre_apoderado.Text),
                lugar_nacimineto_municipio_apoderado=ValidarCampo(lugar_nacimineto_municipio_apoderado.Text),
                lugar_nacimineto_provincia_apoderado=ValidarCampo(lugar_nacimineto_provincia_apoderado.Text),
                fecha_nacimineto_apoderado=ValidarCampo(fecha_nacimineto_apoderado.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_apoderado=ValidarCampo(estado_civil_apoderado.Text),
                ciudadania_apoderado=ValidarCampo(ciudadania_apoderado.Text),
                ocupacion_apoderado=ValidarCampo(ocupacion_apoderado.Text),
                direccion_apoderado=ValidarCampo(direccion_apoderado.Text),
                carnet_pasaporte_apoderado=ValidarCampo(carnet_pasaporte_apoderado.Text),
                nombre_padres_apoderado=ValidarCampo(nombre_padres_apoderado.Text),
                condicion_migratoria_apoderado=ValidarCampo(condicion_migratoria_apoderado.Text),

                marca=ValidarCampo(marca.Text),

                modelo=ValidarCampo(modelo.Text),

                anno=ValidarCampo(anno.Text),

                color=ValidarCampo(color.Text),

                nro_motor=ValidarCampo(nro_motor.Text),

                nro_chasis=ValidarCampo(nro_chasis.Text),

                matricula=ValidarCampo(matricula.Text)
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

        public bool ValidarAnexo( model.Anexo24_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.fecha_solicitud)||
            //    string.IsNullOrEmpty(model.nombre)||
            //    string.IsNullOrEmpty(model.lugar_nacimineto_municipio)||
            //    string.IsNullOrEmpty(model.lugar_nacimineto_provincia)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto)||
            //    string.IsNullOrEmpty(model.estado_civil)||
            //    string.IsNullOrEmpty(model.ciudadania)||
            //    string.IsNullOrEmpty(model.ocupacion)||
            //    string.IsNullOrEmpty(model.direccion)||
            //    string.IsNullOrEmpty(model.carnet_pasaporte)||
            //    string.IsNullOrEmpty(model.nombre_apellido_padres)||
            //    string.IsNullOrEmpty(model.condicion_migratoria)||
            //    string.IsNullOrEmpty(model.correo)||
            //    string.IsNullOrEmpty(model.celular)||
            //    string.IsNullOrEmpty(model.nombre_apoderado)||
            //    string.IsNullOrEmpty(model.lugar_nacimineto_municipio_apoderado)||
            //    string.IsNullOrEmpty(model.lugar_nacimineto_provincia_apoderado)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
            //    string.IsNullOrEmpty(model.estado_civil_apoderado)||
            //    string.IsNullOrEmpty(model.ciudadania_apoderado)||
            //    string.IsNullOrEmpty(model.ocupacion_apoderado)||
            //    string.IsNullOrEmpty(model.direccion_apoderado)||
            //    string.IsNullOrEmpty(model.carnet_pasaporte_apoderado)||
            //     string.IsNullOrEmpty(model.nombre_padres_apoderado)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
            //    string.IsNullOrEmpty(model.marca)||
            //    string.IsNullOrEmpty(model.modelo)||
            //    string.IsNullOrEmpty(model.anno)||
            //    string.IsNullOrEmpty(model.color)||
            //    string.IsNullOrEmpty(model.nro_motor)||
            //    string.IsNullOrEmpty(model.nro_chasis)||
            //    string.IsNullOrEmpty(model.matricula))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo24_e es válida
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
