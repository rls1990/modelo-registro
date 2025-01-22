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
                ciudad=ciudad.Text,
                pais=pais.Text,
                nombre_apellido=nombre_apellido.Text,
                fecha_defuncion=fecha_defuncion.SelectedDate?.ToString("yyyy-MM-dd"),
                municipio_fallecimineto=municipio_fallecimineto.Text,
                provincia_fallecimineto=provincia_fallecimineto.Text,
                donde_fue_velado=donde_fue_velado.Text,
                municipio_funeraria=municipio_funeraria.Text,
                provincia_funeraria=provincia_funeraria.Text,
                tomo=tomo.Text,
                folio=folio.Text,
                legalizacion_minrex=legalizacion_minrex.Text,
                legalizacion_embajada=legalizacion_embajada.Text,
                fecha_de_solicitud=fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd")
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
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.nombre_apellido)||
                string.IsNullOrEmpty(model.fecha_defuncion)||
                string.IsNullOrEmpty(model.municipio_fallecimineto)||
                string.IsNullOrEmpty(model.provincia_fallecimineto)||
                string.IsNullOrEmpty(model.donde_fue_velado)||
                string.IsNullOrEmpty(model.municipio_funeraria)||
                string.IsNullOrEmpty(model.provincia_funeraria)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.legalizacion_minrex)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_de_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo7_e es válida
        }

    }
}
