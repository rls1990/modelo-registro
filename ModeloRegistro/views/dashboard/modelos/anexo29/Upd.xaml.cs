using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo29
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo29_m manager = new model.Anexo29_m(Global.sqlite);
        private model.Anexo29_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo29_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            fecha_solicitud.Text=entity.fecha_solicitud;
            nombre.Text=entity.nombre;
            sexo.Text=entity.sexo;

            lugar_nacimineto_municipio.Text=entity.lugar_nacimineto_municipio;
            lugar_nacimineto_provincia.Text=entity.lugar_nacimineto_provincia;

            fecha_nacimineto.Text=entity.fecha_nacimineto;
            estado_civil.Text=entity.estado_civil;

            ciudadania.Text=entity.ciudadania;
            ocupacion.Text=entity.ocupacion;

            direccion.Text=entity.direccion;
            carnet_pasaporte.Text=entity.carnet_pasaporte;

            condicion_migratoria.Text=entity.condicion_migratoria;

            correo.Text=entity.correo;
            celular.Text=entity.celular;

            nombre_apoderado.Text=entity.nombre_apoderado;
            sexo_apoderado.Text=entity.sexo_apoderado;

            lugar_nacimineto_municipio_apoderado.Text=entity.lugar_nacimineto_municipio_apoderado;
            lugar_nacimineto_provincia_apoderado.Text=entity.lugar_nacimineto_provincia_apoderado;

            fecha_nacimineto_apoderado.Text=entity.fecha_nacimineto_apoderado;
            estado_civil_apoderado.Text=entity.estado_civil_apoderado;

            ciudadania_apoderado.Text=entity.ciudadania_apoderado;
            ocupacion_apoderado.Text=entity.ocupacion_apoderado;

            direccion_apoderado.Text=entity.direccion_apoderado;
            carnet_pasaporte_apoderado.Text=entity.carnet_pasaporte_apoderado;

            condicion_migratoria_apoderado.Text=entity.condicion_migratoria_apoderado;

            nombre_menor.Text=entity.nombre_menor;

            natural_de.Text=entity.natural_de;

            fecha_nacimineto_menor.Text=entity.fecha_nacimineto_menor;

            edad.Text=entity.edad;

            tomo.Text=entity.tomo;

            folio.Text=entity.folio;

            registro_estado_civil.Text=entity.registro_estado_civil;

            tipo_tramites.Text=entity.tipo_tramites;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo29());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo29_e()
            {
                id=entity.id,
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre=nombre.Text,
                sexo=sexo.Text,
                lugar_nacimineto_municipio=lugar_nacimineto_municipio.Text,
                lugar_nacimineto_provincia=lugar_nacimineto_provincia.Text,
                fecha_nacimineto=fecha_nacimineto.SelectedDate?.ToString("yyyy-MM-dd"),
                estado_civil=estado_civil.Text,
                ciudadania=ciudadania.Text,
                ocupacion=ocupacion.Text,
                direccion=direccion.Text,
                carnet_pasaporte=carnet_pasaporte.Text,
                condicion_migratoria=condicion_migratoria.Text,
                correo=correo.Text,
                celular=celular.Text,

                nombre_apoderado=nombre_apoderado.Text,
                sexo_apoderado=sexo_apoderado.Text,
                lugar_nacimineto_municipio_apoderado=lugar_nacimineto_municipio_apoderado.Text,
                lugar_nacimineto_provincia_apoderado=lugar_nacimineto_provincia_apoderado.Text,
                fecha_nacimineto_apoderado=fecha_nacimineto_apoderado.SelectedDate?.ToString("yyyy-MM-dd"),
                estado_civil_apoderado=estado_civil_apoderado.Text,
                ciudadania_apoderado=ciudadania_apoderado.Text,
                ocupacion_apoderado=ocupacion_apoderado.Text,
                direccion_apoderado=direccion_apoderado.Text,
                carnet_pasaporte_apoderado=carnet_pasaporte_apoderado.Text,
                condicion_migratoria_apoderado=condicion_migratoria_apoderado.Text,

                nombre_menor=nombre_menor.Text,
                natural_de=natural_de.Text,
                fecha_nacimineto_menor=fecha_nacimineto_menor.SelectedDate?.ToString("yyyy-MM-dd"),
                edad=edad.Text,
                tomo=tomo.Text,
                folio=folio.Text,
                registro_estado_civil=registro_estado_civil.Text,
                tipo_tramites=tipo_tramites.Text
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

        public bool ValidarAnexo( model.Anexo29_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.nombre)||
                string.IsNullOrEmpty(model.sexo)||
                string.IsNullOrEmpty(model.lugar_nacimineto_municipio)||
                string.IsNullOrEmpty(model.lugar_nacimineto_provincia)||
                string.IsNullOrEmpty(model.fecha_nacimineto)||
                string.IsNullOrEmpty(model.estado_civil)||
                string.IsNullOrEmpty(model.ciudadania)||
                string.IsNullOrEmpty(model.ocupacion)||
                string.IsNullOrEmpty(model.direccion)||
                string.IsNullOrEmpty(model.carnet_pasaporte)||
                string.IsNullOrEmpty(model.condicion_migratoria)||
                string.IsNullOrEmpty(model.correo)||
                string.IsNullOrEmpty(model.celular)||
                string.IsNullOrEmpty(model.nombre_apoderado)||
                string.IsNullOrEmpty(model.sexo_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimineto_municipio_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimineto_provincia_apoderado)||
                string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
                string.IsNullOrEmpty(model.estado_civil_apoderado)||
                string.IsNullOrEmpty(model.ciudadania_apoderado)||
                string.IsNullOrEmpty(model.ocupacion_apoderado)||
                string.IsNullOrEmpty(model.direccion_apoderado)||
                string.IsNullOrEmpty(model.carnet_pasaporte_apoderado)||
                string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
                string.IsNullOrEmpty(model.nombre_menor)||
                string.IsNullOrEmpty(model.natural_de)||
                string.IsNullOrEmpty(model.fecha_nacimineto_menor)||
                string.IsNullOrEmpty(model.edad)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.registro_estado_civil)||
                string.IsNullOrEmpty(model.tipo_tramites))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo29_e es válida
        }
    }
}
