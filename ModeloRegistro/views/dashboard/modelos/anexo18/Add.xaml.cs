using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo18
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo18_m manager = new model.Anexo18_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo18());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo18_e()
            {
                nombre_hombre=nombre_hombre.Text,
                nombre_mujer=nombre_mujer.Text,
                ciudadania_hombre=ciudadania_hombre.Text,
                ciudadania_mujer=ciudadania_mujer.Text,
                lugar_nacimiento_hombre=lugar_nacimiento_hombre.Text,
                lugar_nacimiento_mujer=lugar_nacimiento_mujer.Text,
                fecha_nacimiento_hombre=fecha_nacimiento_hombre.SelectedDate?.ToString("yyyy-MM-dd"),
                fecha_nacimiento_mujer=fecha_nacimiento_mujer.SelectedDate?.ToString("yyyy-MM-dd"),
                pasaporte_hombre=pasaporte_hombre.Text,
                pasaporte_mujer=pasaporte_mujer.Text,
                nombre_hijo_menor=nombre_hijo_menor.Text,
                ciudadania_hijo_menor=ciudadania_hijo_menor.Text,
                lugar_nacimineto_hijo_menor=lugar_nacimineto_hijo_menor.Text,
                fecha_nacimiento_hijo_menor=fecha_nacimiento_hijo_menor.SelectedDate?.ToString("yyyy-MM-dd"),
                pasaporte_hijo_menor=pasaporte_hijo_menor.Text,
                padre=padre.Text,
                ciudadania_padre=ciudadania_padre.Text,
                madre=madre.Text,
                ciudadania_madre=ciudadania_madre.Text,
                ultima_direccion_cuba=ultima_direccion_cuba.Text,
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

        private bool ValidarAnexo( model.Anexo18_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.nombre_hombre)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_mujer)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_hombre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_mujer)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_hombre)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_mujer)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_hombre)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_mujer)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte_hombre)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte_mujer)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_hijo_menor)&&
                   //!string.IsNullOrWhiteSpace(anexo.ciudadania_hijo_menor)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto_hijo_menor)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_hijo_menor)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte_hijo_menor)&&
                   !string.IsNullOrWhiteSpace(anexo.padre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.madre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_madre)&&
                   !string.IsNullOrWhiteSpace(anexo.ultima_direccion_cuba)&&
                   //!string.IsNullOrWhiteSpace(anexo.recidir_cuba)&&
                   //!string.IsNullOrWhiteSpace(anexo.recidir_en_exterior)&&
                   !string.IsNullOrWhiteSpace(anexo.razones_personales)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_funcionario)&&
                   !string.IsNullOrWhiteSpace(anexo.telefono)&&
                   !string.IsNullOrWhiteSpace(anexo.email);
        }

    }
}
