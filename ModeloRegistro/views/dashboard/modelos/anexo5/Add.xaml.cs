using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo5
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo5_m manager = new model.Anexo5_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo5());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo5 = new model.Anexo5_e()
            {
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                nombre_apellido_hombre=ValidarCampo(nombre_apellido_hombre.Text),
                nombre_apellido_mujer=ValidarCampo(nombre_apellido_mujer.Text),
                fecha_matrimonio=ValidarCampo(fecha_matrimonio.SelectedDate?.ToString("yyyy-MM-dd")),
                ciudad_matrimonio=ValidarCampo(ciudad_matrimonio.Text),
                provincia_matrimonio=ValidarCampo(provincia_matrimonio.Text),
                pais_matrimonio=ValidarCampo(pais_matrimonio.Text),
                registro=ValidarCampo(registro.Text),
                municipio_registro=ValidarCampo(municipio_registro.Text),
                provincia_registro=ValidarCampo(provincia_registro.Text),
                tomo=ValidarCampo(tomo.Text),
                folio=ValidarCampo(folio.Text),
                legalizacion_minred=ValidarCampo(legalizacion_minred.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
            };

            if(ValidarAnexo(anexo5))
            {
                manager.save(anexo5);
                MessageBox.Show("Anexo 5 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo5_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.ciudad)||
            //    string.IsNullOrEmpty(model.pais)||
            //    string.IsNullOrEmpty(model.nombre_apellido_hombre)||
            //    string.IsNullOrEmpty(model.nombre_apellido_mujer)||
            //    string.IsNullOrEmpty(model.fecha_matrimonio)||
            //    string.IsNullOrEmpty(model.ciudad_matrimonio)||
            //    string.IsNullOrEmpty(model.provincia_matrimonio)||
            //    string.IsNullOrEmpty(model.pais_matrimonio)||
            //    string.IsNullOrEmpty(model.registro)||
            //    string.IsNullOrEmpty(model.municipio_registro)||
            //    string.IsNullOrEmpty(model.provincia_registro)||
            //    string.IsNullOrEmpty(model.tomo)||
            //    string.IsNullOrEmpty(model.folio)||
            //    string.IsNullOrEmpty(model.legalizacion_minred)||
            //    string.IsNullOrEmpty(model.legalizacion_embajada)||
            //    string.IsNullOrEmpty(model.fecha_solicitud))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo5_e es válida
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
