using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo6
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo6_m manager = new model.Anexo6_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo6());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo6 = new model.Anexo6_e()
            {
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                nombre_apellido_hombre=ValidarCampo(nombre_apellido_hombre.Text),
                nombre_apellido_mujer=ValidarCampo(nombre_apellido_mujer.Text),
                tribunal_dicto_sentencia=ValidarCampo(tribunal_dicto_sentencia.Text),
                nombre_secretario_actuante=ValidarCampo(nombre_secretario_actuante.Text),
                fecha_dicto_sentencia=ValidarCampo(fecha_dicto_sentencia.SelectedDate?.ToString("yyyy-MM-dd")),
                fecha_firmeza_sentencia=ValidarCampo(fecha_firmeza_sentencia.SelectedDate?.ToString("yyyy-MM-dd")),
                no_sentencia=ValidarCampo(no_sentencia.Text),
                no_radicacion=ValidarCampo(no_radicacion.Text),
                legalizacion_minred=ValidarCampo(legalizacion_minred.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_solicitud=ValidarCampo(fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
            };

            if(ValidarAnexo(anexo6))
            {
                manager.save(anexo6);
                MessageBox.Show("Anexo 6 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo6_e model )
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
            //    string.IsNullOrEmpty(model.tribunal_dicto_sentencia)||
            //    string.IsNullOrEmpty(model.nombre_secretario_actuante)||
            //    string.IsNullOrEmpty(model.fecha_dicto_sentencia)||
            //    string.IsNullOrEmpty(model.fecha_firmeza_sentencia)||
            //    string.IsNullOrEmpty(model.no_sentencia)||
            //    string.IsNullOrEmpty(model.no_radicacion)||
            //    string.IsNullOrEmpty(model.legalizacion_minred)||
            //    string.IsNullOrEmpty(model.legalizacion_embajada)||
            //    string.IsNullOrEmpty(model.fecha_solicitud))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo6_e es válida
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
