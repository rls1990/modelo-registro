using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo31
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo31_m manager = new model.Anexo31_m(Global.sqlite);
        private model.Anexo31_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo31_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            fecha_solicitud.Text=entity.fecha_solicitud;
            nombre_poderante.Text=entity.nombre_poderante;

            lugar_nacimiento_municipio_poderante.Text=entity.lugar_nacimiento_municipio_poderante;
            lugar_nacimiento_provincia_poderante.Text=entity.lugar_nacimiento_provincia_poderante;

            fecha_nacimineto_poderante.Text=entity.fecha_nacimineto_poderante;
            registro_estado_civil_poderante.Text=entity.registro_estado_civil_poderante;

            tomo_poderante.Text=entity.tomo_poderante;
            folio_poderante.Text=entity.folio_poderante;

            estado_civil_poderante.Text=entity.estado_civil_poderante;
            ciudadania_poderante.Text=entity.ciudadania_poderante;

            ocupacion_poderante.Text=entity.ocupacion_poderante;
            direccion_particular_poderante.Text=entity.direccion_particular_poderante;

            carne_pasaporte_poderante.Text=entity.carne_pasaporte_poderante;
            nombre_apellido_padres_poderante.Text=entity.nombre_apellido_padres_poderante;

            condicion_migratoria_poderante.Text=entity.condicion_migratoria_poderante;

            correo_poderante.Text=entity.correo_poderante;
            celular_poderante.Text=entity.celular_poderante;

            nombre_apoderado.Text=entity.nombre_apoderado;

            lugar_nacimiento_municipio_apoderado.Text=entity.lugar_nacimiento_municipio_apoderado;
            lugar_nacimiento_provincia_apoderado.Text=entity.lugar_nacimiento_provincia_apoderado;

            fecha_nacimineto_apoderado.Text=entity.fecha_nacimineto_apoderado;

            registro_estado_civil_apoderado.Text=entity.registro_estado_civil_apoderado;

            tomo_apoderado.Text=entity.tomo_apoderado;
            folio_apoderado.Text=entity.folio_apoderado;

            estado_civil_apoderado.Text=entity.estado_civil_apoderado;
            ciudadania_apoderado.Text=entity.ciudadania_apoderado;

            ocupacion_apoderado.Text=entity.ocupacion_apoderado;

            direccion_particular_apoderado.Text=entity.direccion_particular_apoderado;

            carne_pasaporte_apoderado.Text=entity.carne_pasaporte_apoderado;

            nombre_apellido_padres_apoderado.Text=entity.nombre_apellido_padres_apoderado;

            condicion_migratoria_apoderado.Text=entity.condicion_migratoria_apoderado;

            clausula.Text=entity.clausula; // Asegúrate de que este campo sea correcto
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo31());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo31 = new model.Anexo31_e()
            {
                id=entity.id,
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre_poderante=nombre_poderante.Text,
                lugar_nacimiento_municipio_poderante=lugar_nacimiento_municipio_poderante.Text,
                lugar_nacimiento_provincia_poderante=lugar_nacimiento_provincia_poderante.Text,
                fecha_nacimineto_poderante=fecha_nacimineto_poderante.SelectedDate?.ToString("yyyy-MM-dd"),
                registro_estado_civil_poderante=registro_estado_civil_poderante.Text,
                tomo_poderante=tomo_poderante.Text,
                folio_poderante=folio_poderante.Text,
                estado_civil_poderante=estado_civil_poderante.Text,
                ciudadania_poderante=ciudadania_poderante.Text,
                ocupacion_poderante=ocupacion_poderante.Text,
                direccion_particular_poderante=direccion_particular_poderante.Text,
                carne_pasaporte_poderante=carne_pasaporte_poderante.Text,
                nombre_apellido_padres_poderante=nombre_apellido_padres_poderante.Text,
                condicion_migratoria_poderante=condicion_migratoria_poderante.Text,
                correo_poderante=correo_poderante.Text,
                celular_poderante=celular_poderante.Text,
                nombre_apoderado=nombre_apoderado.Text,
                lugar_nacimiento_municipio_apoderado=lugar_nacimiento_municipio_apoderado.Text,
                lugar_nacimiento_provincia_apoderado=lugar_nacimiento_provincia_apoderado.Text,
                fecha_nacimineto_apoderado=fecha_nacimineto_apoderado.SelectedDate?.ToString("yyyy-MM-dd"),
                registro_estado_civil_apoderado=registro_estado_civil_apoderado.Text,
                tomo_apoderado=tomo_apoderado.Text,
                folio_apoderado=folio_apoderado.Text,
                estado_civil_apoderado=estado_civil_apoderado.Text,
                ciudadania_apoderado=ciudadania_apoderado.Text,
                ocupacion_apoderado=ocupacion_apoderado.Text,
                direccion_particular_apoderado=direccion_particular_apoderado.Text,
                carne_pasaporte_apoderado=carne_pasaporte_apoderado.Text,
                nombre_apellido_padres_apoderado=nombre_apellido_padres_apoderado.Text,
                condicion_migratoria_apoderado=condicion_migratoria_apoderado.Text,
                clausula=clausula.Text
            };

            if(ValidarAnexo(anexo31))
            {
                manager.update(anexo31);
                MessageBox.Show("Anexo 31 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo31_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.nombre_poderante)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_poderante)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_poderante)||
                string.IsNullOrEmpty(model.fecha_nacimineto_poderante)||
                string.IsNullOrEmpty(model.registro_estado_civil_poderante)||
                string.IsNullOrEmpty(model.tomo_poderante)||
                string.IsNullOrEmpty(model.folio_poderante)||
                string.IsNullOrEmpty(model.estado_civil_poderante)||
                string.IsNullOrEmpty(model.ciudadania_poderante)||
                string.IsNullOrEmpty(model.ocupacion_poderante)||
                string.IsNullOrEmpty(model.direccion_particular_poderante)||
                string.IsNullOrEmpty(model.carne_pasaporte_poderante)||
                string.IsNullOrEmpty(model.nombre_apellido_padres_poderante)||
                string.IsNullOrEmpty(model.condicion_migratoria_poderante)||
                string.IsNullOrEmpty(model.correo_poderante)||
                string.IsNullOrEmpty(model.celular_poderante)||
                string.IsNullOrEmpty(model.nombre_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_apoderado)||
                string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
                string.IsNullOrEmpty(model.registro_estado_civil_apoderado)||
                string.IsNullOrEmpty(model.tomo_apoderado)||
                string.IsNullOrEmpty(model.folio_apoderado)||
                string.IsNullOrEmpty(model.estado_civil_apoderado)||
                string.IsNullOrEmpty(model.ciudadania_apoderado)||
                string.IsNullOrEmpty(model.ocupacion_apoderado)||
                string.IsNullOrEmpty(model.direccion_particular_apoderado)||
                string.IsNullOrEmpty(model.carne_pasaporte_apoderado)||
                string.IsNullOrEmpty(model.nombre_apellido_padres_apoderado)||
                string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
                string.IsNullOrEmpty(model.clausula))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo31_e es válida
        }
    }
}
