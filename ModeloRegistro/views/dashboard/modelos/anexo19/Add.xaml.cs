using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo19
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo19_m manager = new model.Anexo19_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo19());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo19_e()
            {
                nombre_apellidos=nombre_apellidos.Text,
                ciudadano=ciudadano.Text,
                lugar_nacimiento=lugar_nacimiento.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                pasaporte=pasaporte.Text,
                nombre_menor=nombre_menor.Text,
                ciudadania_menor=ciudadania_menor.Text,
                lugar_nacimineto_menor=lugar_nacimineto_menor.Text,
                fecha_nacimiento_menor=fecha_nacimiento_menor.SelectedDate?.ToString("yyyy-MM-dd"),
                pasaporte_menor=pasaporte_menor.Text,
                ultima_direccion_pedres=ultima_direccion_pedres.Text,
                recidir_cuba=recidir_cuba.IsChecked.ToString(),
                recidir_en_exterior=recidir_en_exterior.IsChecked.ToString(),
                razones_personales=razones_personales.Text,
                nombre_funcionario=nombre_funcionario.Text,
                telefono=telefono.Text,
                email=email.Text
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

        public bool ValidarAnexo( model.Anexo19_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.nombre_apellidos)||
                string.IsNullOrEmpty(model.ciudadano)||
                string.IsNullOrEmpty(model.lugar_nacimiento)||
                string.IsNullOrEmpty(model.fecha_nacimiento)||
                string.IsNullOrEmpty(model.pasaporte)||
                string.IsNullOrEmpty(model.nombre_menor)||
                string.IsNullOrEmpty(model.ciudadania_menor)||
                string.IsNullOrEmpty(model.lugar_nacimineto_menor)||
                string.IsNullOrEmpty(model.fecha_nacimiento_menor)||
                string.IsNullOrEmpty(model.pasaporte_menor)||
                string.IsNullOrEmpty(model.ultima_direccion_pedres)||
                //string.IsNullOrEmpty(model.recidir_cuba)||
                //string.IsNullOrEmpty(model.recidir_en_exterior)||
                string.IsNullOrEmpty(model.razones_personales)||
                string.IsNullOrEmpty(model.nombre_funcionario)||
                string.IsNullOrEmpty(model.telefono)||
                string.IsNullOrEmpty(model.email))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo19_e es válida
        }

    }
}
