using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo28
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo28_m manager = new model.Anexo28_m(Global.sqlite);
        private model.Anexo28_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo28_e)Global.entity;

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

            //especificar_causa_representante.Text=entity.especificar_causa_representante;

            despacho_equipaje.Text=entity.despacho_equipaje;

            numero_contenedor.Text=entity.numero_contenedor;

            bl.Text=entity.bl; // Bill of Lading or similar

            total.Text=entity.total; // Total number of items or other relevant total

            numeracion.Text=entity.numeracion; // Any relevant numbering

            total_kg.Text=entity.total_kg; // Total weight in kilograms
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo28());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo28_e()
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

                //especificar_causa_representante=ValidarCampo("",
                despacho_equipaje=ValidarCampo(despacho_equipaje.Text),
                numero_contenedor=ValidarCampo(numero_contenedor.Text),
                bl=ValidarCampo(bl.Text),
                total=ValidarCampo(total.Text),
                numeracion=ValidarCampo(numeracion.Text),
                total_kg=ValidarCampo(total_kg.Text)
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

        public bool ValidarAnexo( model.Anexo28_e model )
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
            //    //string.IsNullOrEmpty(model.especificar_causa_representante)||
            //    string.IsNullOrEmpty(model.despacho_equipaje)||
            //    string.IsNullOrEmpty(model.numero_contenedor)||
            //    string.IsNullOrEmpty(model.bl)||
            //    string.IsNullOrEmpty(model.total)||
            //    string.IsNullOrEmpty(model.numeracion)||
            //    string.IsNullOrEmpty(model.total_kg))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo28_e es válida
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
