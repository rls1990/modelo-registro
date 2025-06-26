using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo7
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo7_m manager = new model.Anexo7_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo7());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo7 = new model.Anexo7_e()
            {
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                nombre_apellido=ValidarCampo(nombre_apellido.Text),
                fecha_defuncion=ValidarCampo(fecha_defuncion.SelectedDate?.ToString("yyyy-MM-dd")),
                municipio_fallecimineto=ValidarCampo(municipio_fallecimineto.Text),
                provincia_fallecimineto=ValidarCampo(provincia_fallecimineto.Text),
                donde_fue_velado=ValidarCampo(donde_fue_velado.Text),
                municipio_funeraria=ValidarCampo(municipio_funeraria.Text),
                provincia_funeraria=ValidarCampo(provincia_funeraria.Text),
                tomo=ValidarCampo(tomo.Text),
                folio=ValidarCampo(folio.Text),
                legalizacion_minrex=ValidarCampo(legalizacion_minrex.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_de_solicitud=ValidarCampo(fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
            };

            if(ValidarAnexo(anexo7))
            {
                manager.save(anexo7);
                MessageBox.Show("Anexo 7 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo7_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.ciudad)||
            //    string.IsNullOrEmpty(model.pais)||
            //    string.IsNullOrEmpty(model.nombre_apellido)||
            //    string.IsNullOrEmpty(model.fecha_defuncion)||
            //    string.IsNullOrEmpty(model.municipio_fallecimineto)||
            //    string.IsNullOrEmpty(model.provincia_fallecimineto)||
            //    string.IsNullOrEmpty(model.donde_fue_velado)||
            //    string.IsNullOrEmpty(model.municipio_funeraria)||
            //    string.IsNullOrEmpty(model.provincia_funeraria)||
            //    string.IsNullOrEmpty(model.tomo)||
            //    string.IsNullOrEmpty(model.folio)||
            //    string.IsNullOrEmpty(model.legalizacion_minrex)||
            //    string.IsNullOrEmpty(model.legalizacion_embajada)||
            //    string.IsNullOrEmpty(model.fecha_de_solicitud))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo7_e es válida
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
