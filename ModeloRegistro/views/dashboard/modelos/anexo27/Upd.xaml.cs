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
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo27());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo27_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.nombre_poderante)||
                string.IsNullOrEmpty(model.sexo_poderante)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_poderante)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_poderante)||
                string.IsNullOrEmpty(model.fecha_nacimineto_poderante)||
                string.IsNullOrEmpty(model.estado_civil_poderante)||
                string.IsNullOrEmpty(model.ciudadania_poderante)||
                string.IsNullOrEmpty(model.ocupacion_poderante)||
                string.IsNullOrEmpty(model.direccion_particular_poderante)||
                string.IsNullOrEmpty(model.carne_pasaporte_poderante)||
                string.IsNullOrEmpty(model.condicion_migratoria_poderante)||
                string.IsNullOrEmpty(model.correo_poderante)||
                string.IsNullOrEmpty(model.celular_poderante)||
                string.IsNullOrEmpty(model.nombre_apoderado)||
                string.IsNullOrEmpty(model.sexo_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_apoderado)||
                string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
                string.IsNullOrEmpty(model.estado_civil_apoderado)||
                string.IsNullOrEmpty(model.ciudadania_apoderado)||
                string.IsNullOrEmpty(model.ocupacion_apoderado)||
                string.IsNullOrEmpty(model.direccion_particular_apoderado)||
                string.IsNullOrEmpty(model.carne_pasaporte_apoderado)||
                string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
                string.IsNullOrEmpty(model.nombre_donatorio)||
                string.IsNullOrEmpty(model.sexo_donatorio)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_donatorio)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_donatorio)||
                string.IsNullOrEmpty(model.fecha_nacimineto_donatorio)||
                string.IsNullOrEmpty(model.estado_civil_donatorio)||
                string.IsNullOrEmpty(model.ciudadania_donatorio)||
                string.IsNullOrEmpty(model.ocupacion_donatorio)||
                string.IsNullOrEmpty(model.direccion_particular_donatorio)||
                string.IsNullOrEmpty(model.carne_pasaporte_donatorio)||
                string.IsNullOrEmpty(model.condicion_migratoria_donatorio)||
                string.IsNullOrEmpty(model.direccion_vivienda))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo27_e es válida
        }
    }
}
