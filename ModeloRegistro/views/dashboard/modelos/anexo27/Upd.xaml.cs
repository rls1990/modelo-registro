using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo27
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo27_m manager = new model.Anexo27_m(Global.sqlite);
        private model.Anexo27_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo27_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            fecha_solicitud.Text=entity.fecha_solicitud;
            nombre_poderante.Text=entity.nombre_poderante;
            sexo_poderante.Text=entity.sexo_poderante;

            lugar_nacimiento_municipio_poderante.Text=entity.lugar_nacimiento_municipio_poderante;
            lugar_nacimiento_provincia_poderante.Text=entity.lugar_nacimiento_provincia_poderante;

            fecha_nacimineto_poderante.Text=entity.fecha_nacimineto_poderante;
            estado_civil_poderante.Text=entity.estado_civil_poderante;

            ciudadania_poderante.Text=entity.ciudadania_poderante;
            ocupacion_poderante.Text=entity.ocupacion_poderante;

            direccion_particular_poderante.Text=entity.direccion_particular_poderante;
            carne_pasaporte_poderante.Text=entity.carne_pasaporte_poderante;

            condicion_migratoria_poderante.Text=entity.condicion_migratoria_poderante;

            correo_poderante.Text=entity.correo_poderante;
            celular_poderante.Text=entity.celular_poderante;

            nombre_apoderado.Text=entity.nombre_apoderado;
            sexo_apoderado.Text=entity.sexo_apoderado;

            lugar_nacimiento_municipio_apoderado.Text=entity.lugar_nacimiento_municipio_apoderado;
            lugar_nacimiento_provincia_apoderado.Text=entity.lugar_nacimiento_provincia_apoderado;

            fecha_nacimineto_apoderado.Text=entity.fecha_nacimineto_apoderado;
            estado_civil_apoderado.Text=entity.estado_civil_apoderado;

            ciudadania_apoderado.Text=entity.ciudadania_apoderado;
            ocupacion_apoderado.Text=entity.ocupacion_apoderado;

            direccion_particular_apoderado.Text=entity.direccion_particular_apoderado;
            carne_pasaporte_apoderado.Text=entity.carne_pasaporte_apoderado;

            condicion_migratoria_apoderado.Text=entity.condicion_migratoria_apoderado;

            nombre_donatorio.Text=entity.nombre_donatorio;
            sexo_donatorio.Text=entity.sexo_donatorio;

            lugar_nacimiento_municipio_donatorio.Text=entity.lugar_nacimiento_municipio_donatorio;
            lugar_nacimiento_provincia_donatorio.Text=entity.lugar_nacimiento_provincia_donatorio;

            fecha_nacimineto_donatorio.Text=entity.fecha_nacimineto_donatorio;
            estado_civil_donatorio.Text=entity.estado_civil_donatorio;

            ciudadania_donatorio.Text=entity.ciudadania_donatorio;
            ocupacion_donatorio.Text=entity.ocupacion_donatorio;

            direccion_particular_donatorio.Text=entity.direccion_particular_donatorio;
            carne_pasaporte_donatorio.Text=entity.carne_pasaporte_donatorio;

            condicion_migratoria_donatorio.Text=entity.condicion_migratoria_donatorio;

            direccion_vivienda.Text=entity.direccion_vivienda;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo27());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo27_e()
            {
                id=entity.id,
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

                nombre_donatorio=ValidarCampo(nombre_donatorio.Text),
                sexo_donatorio=ValidarCampo(sexo_donatorio.Text),
                lugar_nacimiento_municipio_donatorio=ValidarCampo(lugar_nacimiento_municipio_donatorio.Text),
                lugar_nacimiento_provincia_donatorio=ValidarCampo(lugar_nacimiento_provincia_donatorio.Text),
                fecha_nacimineto_donatorio=ValidarCampo(fecha_nacimineto_donatorio.SelectedDate?.ToString("yyyy-MM-dd")),
                estado_civil_donatorio=ValidarCampo(estado_civil_donatorio.Text),
                ciudadania_donatorio=ValidarCampo(ciudadania_donatorio.Text),
                ocupacion_donatorio=ValidarCampo(ocupacion_donatorio.Text),
                direccion_particular_donatorio=ValidarCampo(direccion_particular_donatorio.Text),
                carne_pasaporte_donatorio=ValidarCampo(carne_pasaporte_donatorio.Text),
                condicion_migratoria_donatorio=ValidarCampo(condicion_migratoria_donatorio.Text),

                direccion_vivienda=ValidarCampo(direccion_vivienda.Text)
            };

            if(ValidarAnexo(anexo))
            {
                manager.update(anexo);
                MessageBox.Show("Anexo guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo27_e model )
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
            //    string.IsNullOrEmpty(model.nombre_donatorio)||
            //    string.IsNullOrEmpty(model.sexo_donatorio)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_municipio_donatorio)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_provincia_donatorio)||
            //    string.IsNullOrEmpty(model.fecha_nacimineto_donatorio)||
            //    string.IsNullOrEmpty(model.estado_civil_donatorio)||
            //    string.IsNullOrEmpty(model.ciudadania_donatorio)||
            //    string.IsNullOrEmpty(model.ocupacion_donatorio)||
            //    string.IsNullOrEmpty(model.direccion_particular_donatorio)||
            //    string.IsNullOrEmpty(model.carne_pasaporte_donatorio)||
            //    string.IsNullOrEmpty(model.condicion_migratoria_donatorio)||
            //    string.IsNullOrEmpty(model.direccion_vivienda))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo27_e es válida
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
