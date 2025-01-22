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
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo29());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

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
