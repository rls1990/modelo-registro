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
            var anexo = new model.Anexo21_e()
            {
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                nombre_padre=ValidarCampo(nombre_padre.Text),
                ciudadania_padre=ValidarCampo(ciudadania_padre.Text),
                estado_civil_padre=ValidarCampo(estado_civil_padre.Text),
                minicipio_nacimineto_padre=ValidarCampo(minicipio_nacimineto_padre.Text),
                provincia_nacimineto_padre=ValidarCampo(provincia_nacimineto_padre.Text),
                fecha_nacimiento_padre=ValidarCampo(fecha_nacimiento_padre.SelectedDate?.ToString("yyyy-MM-dd")),
                profecion_padre=ValidarCampo(profecion_padre.Text),
                carnet_pasaporte_padre=ValidarCampo(carnet_pasaporte_padre.Text),
                categoria_migratoria_padre=ValidarCampo(categoria_migratoria_padre.Text),
                direccion_eu_padre=ValidarCampo(direccion_eu_padre.Text),
                correo=ValidarCampo(correo.Text),
                celular=ValidarCampo(celular.Text),
                nombre_menor=ValidarCampo(nombre_menor.Text),
                municipio_nacimiento_menor=ValidarCampo(municipio_nacimiento_menor.Text),
                provincia_nacimiento_menor=ValidarCampo(provincia_nacimiento_menor.Text),
                fecha_nacimiento_menor=ValidarCampo(fecha_nacimiento_menor.SelectedDate?.ToString("yyyy-MM-dd")),
                registro_estado_nacimiento_menor=ValidarCampo(registro_estado_nacimiento_menor.Text),
                tomo=ValidarCampo(tomo.Text),
                folio=ValidarCampo(folio.Text),
                tarjeta_menor=ValidarCampo(tarjeta_menor.Text),
                direccion_menor_cuba=ValidarCampo(direccion_menor_cuba.Text)
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

        public bool ValidarAnexo( model.Anexo21_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.fecha_solicitud)||
            //    string.IsNullOrEmpty(model.nombre_padre)||
            //    string.IsNullOrEmpty(model.ciudadania_padre)||
            //    string.IsNullOrEmpty(model.estado_civil_padre)||
            //    string.IsNullOrEmpty(model.minicipio_nacimineto_padre)||
            //    string.IsNullOrEmpty(model.provincia_nacimineto_padre)||
            //    string.IsNullOrEmpty(model.fecha_nacimiento_padre)||
            //    string.IsNullOrEmpty(model.profecion_padre)||
            //    string.IsNullOrEmpty(model.carnet_pasaporte_padre)||
            //    string.IsNullOrEmpty(model.categoria_migratoria_padre)||
            //    string.IsNullOrEmpty(model.direccion_eu_padre)||
            //    string.IsNullOrEmpty(model.correo)||
            //    string.IsNullOrEmpty(model.celular)||
            //    string.IsNullOrEmpty(model.nombre_menor)||
            //    string.IsNullOrEmpty(model.municipio_nacimiento_menor)||
            //    string.IsNullOrEmpty(model.provincia_nacimiento_menor)||
            //    string.IsNullOrEmpty(model.fecha_nacimiento_menor)||
            //    string.IsNullOrEmpty(model.registro_estado_nacimiento_menor)||
            //    string.IsNullOrEmpty(model.tomo)||
            //    string.IsNullOrEmpty(model.folio)||
            //    string.IsNullOrEmpty(model.tarjeta_menor)||
            //    string.IsNullOrEmpty(model.direccion_menor_cuba))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo21_e es válida
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
