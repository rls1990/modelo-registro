using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo12
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo12_m manager = new model.Anexo12_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo12());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo12_e()
            {
                ciudad=ciudad.Text,
                pais=pais.Text,
                nombre_apellidos=nombre_apellidos.Text,
                ciudadano=ciudadano.Text,
                carnet_identidad=carnet_identidad.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                lugar_nacimineto=lugar_nacimineto.Text,
                registro_civil=registro_civil.Text,
                vecino_de=vecino_de.Text,
                nombre_apellido_apoderado=nombre_apellido_apoderado.Text,
                si=si.IsChecked.ToString(),
                no=no.IsChecked.ToString(),
                numero=numero.Text,
                fecha_poder_especial=fecha_poder_especial.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre_apellido_notario=nombre_apellido_notario.Text,
                competencia=competencia.Text,
                sede=sede.Text,
                legalizacion_minrex=legalizacion_minrex.Text,
                legalizacion_embajada=legalizacion_embajada.Text,
                fecha_de_solicitud=fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd")
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

    private bool ValidarAnexo( model.Anexo12_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
                   !string.IsNullOrWhiteSpace(anexo.pais)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadano)&&
                   !string.IsNullOrWhiteSpace(anexo.carnet_identidad)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.vecino_de)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_apoderado)&&
                   !string.IsNullOrWhiteSpace(anexo.si)&&
                   !string.IsNullOrWhiteSpace(anexo.no)&&
                   !string.IsNullOrWhiteSpace(anexo.numero)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_poder_especial)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_notario)&&
                   !string.IsNullOrWhiteSpace(anexo.competencia)&&
                   !string.IsNullOrWhiteSpace(anexo.sede)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
        }

    }
}
