using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo21
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo21_m manager = new model.Anexo21_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
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
