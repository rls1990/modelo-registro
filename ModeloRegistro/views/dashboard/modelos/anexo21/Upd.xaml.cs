using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo21
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo21_m manager = new model.Anexo21_m(Global.sqlite);
        private model.Anexo21_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo21_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            fecha_solicitud.Text=entity.fecha_solicitud;
            nombre_padre.Text=entity.nombre_padre;
            ciudadania_padre.Text=entity.ciudadania_padre;
            estado_civil_padre.Text=entity.estado_civil_padre;
            minicipio_nacimineto_padre.Text=entity.minicipio_nacimineto_padre;
            provincia_nacimineto_padre.Text=entity.provincia_nacimineto_padre;
            fecha_nacimiento_padre.Text=entity.fecha_nacimiento_padre;
            profecion_padre.Text=entity.profecion_padre;
            carnet_pasaporte_padre.Text=entity.carnet_pasaporte_padre;
            categoria_migratoria_padre.Text=entity.categoria_migratoria_padre;
            direccion_eu_padre.Text=entity.direccion_eu_padre;
            correo.Text=entity.correo;
            celular.Text=entity.celular;

            nombre_menor.Text=entity.nombre_menor;
            municipio_nacimiento_menor.Text=entity.municipio_nacimiento_menor;
            provincia_nacimiento_menor.Text=entity.provincia_nacimiento_menor;
            fecha_nacimiento_menor.Text=entity.fecha_nacimiento_menor;
            registro_estado_nacimiento_menor.Text=entity.registro_estado_nacimiento_menor;

            tomo.Text=entity.tomo;
            folio.Text=entity.folio;

            tarjeta_menor.Text=entity.tarjeta_menor;

            direccion_menor_cuba.Text=entity.direccion_menor_cuba;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo21());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo21_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.nombre_padre)||
                string.IsNullOrEmpty(model.ciudadania_padre)||
                string.IsNullOrEmpty(model.estado_civil_padre)||
                string.IsNullOrEmpty(model.minicipio_nacimineto_padre)||
                string.IsNullOrEmpty(model.provincia_nacimineto_padre)||
                string.IsNullOrEmpty(model.fecha_nacimiento_padre)||
                string.IsNullOrEmpty(model.profecion_padre)||
                string.IsNullOrEmpty(model.carnet_pasaporte_padre)||
                string.IsNullOrEmpty(model.categoria_migratoria_padre)||
                string.IsNullOrEmpty(model.direccion_eu_padre)||
                string.IsNullOrEmpty(model.correo)||
                string.IsNullOrEmpty(model.celular)||
                string.IsNullOrEmpty(model.nombre_menor)||
                string.IsNullOrEmpty(model.municipio_nacimiento_menor)||
                string.IsNullOrEmpty(model.provincia_nacimiento_menor)||
                string.IsNullOrEmpty(model.fecha_nacimiento_menor)||
                string.IsNullOrEmpty(model.registro_estado_nacimiento_menor)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.tarjeta_menor)||
                string.IsNullOrEmpty(model.direccion_menor_cuba))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo21_e es válida
        }
    }
}
