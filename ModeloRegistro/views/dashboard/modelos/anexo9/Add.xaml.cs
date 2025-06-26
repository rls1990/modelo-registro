using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo9
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo9_m manager = new model.Anexo9_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo9());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo9 = new model.Anexo9_e()
            {
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                encargado_registro_civil=ValidarCampo(encargado_registro_civil.Text),
                municipio_encargado=ValidarCampo(municipio_encargado.Text),
                provincia_encargado=ValidarCampo(provincia_encargado.Text),
                nombre=ValidarCampo(nombre.Text),
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                tomo_certificado=ValidarCampo(tomo_certificado.Text),
                folio_certificado=ValidarCampo(folio_certificado.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                municipio_persona=ValidarCampo(municipio_persona.Text),
                provincia_persona=ValidarCampo(provincia_persona.Text),
                padre=ValidarCampo(padre.Text),
                madre=ValidarCampo(madre.Text),
                legalizacion_minrex=ValidarCampo(legalizacion_minrex.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_de_solicitud=ValidarCampo(fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
            };

            if(ValidarAnexo(anexo9))
            {
                manager.save(anexo9);
                MessageBox.Show("Anexo 9 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo9_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.ciudad)||
            //    string.IsNullOrEmpty(model.pais)||
            //    string.IsNullOrEmpty(model.encargado_registro_civil)||
            //    string.IsNullOrEmpty(model.municipio_encargado)||
            //    string.IsNullOrEmpty(model.provincia_encargado)||
            //    string.IsNullOrEmpty(model.nombre)||
            //    string.IsNullOrEmpty(model.fecha_solicitud)||
            //    string.IsNullOrEmpty(model.tomo_certificado)||
            //    string.IsNullOrEmpty(model.folio_certificado)||
            //    string.IsNullOrEmpty(model.fecha_nacimiento)||
            //    string.IsNullOrEmpty(model.municipio_persona)||
            //    string.IsNullOrEmpty(model.provincia_persona)||
            //    string.IsNullOrEmpty(model.padre)||
            //    string.IsNullOrEmpty(model.madre)||
            //    string.IsNullOrEmpty(model.legalizacion_minrex)||
            //    string.IsNullOrEmpty(model.legalizacion_embajada)||
            //    string.IsNullOrEmpty(model.fecha_de_solicitud))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo9_e es válida
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
