using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo27
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo27_m manager = new model.Anexo27_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo27());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo27_e()
            {
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre_poderante=nombre_poderante.Text,
                sexo_poderante=sexo_poderante.Text,
                lugar_nacimiento_municipio_poderante=lugar_nacimiento_municipio_poderante.Text,
                lugar_nacimiento_provincia_poderante=lugar_nacimiento_provincia_poderante.Text,
                fecha_nacimineto_poderante=fecha_nacimineto_poderante.SelectedDate?.ToString("yyyy-MM-dd"),
                estado_civil_poderante=estado_civil_poderante.Text,
                ciudadania_poderante=ciudadania_poderante.Text,
                ocupacion_poderante=ocupacion_poderante.Text,
                direccion_particular_poderante=direccion_particular_poderante.Text,
                carne_pasaporte_poderante=carne_pasaporte_poderante.Text,
                condicion_migratoria_poderante=condicion_migratoria_poderante.Text,
                correo_poderante=correo_poderante.Text,
                celular_poderante=celular_poderante.Text,

                nombre_apoderado=nombre_apoderado.Text,
                sexo_apoderado=sexo_apoderado.Text,
                lugar_nacimiento_municipio_apoderado=lugar_nacimiento_municipio_apoderado.Text,
                lugar_nacimiento_provincia_apoderado=lugar_nacimiento_provincia_apoderado.Text,
                fecha_nacimineto_apoderado=fecha_nacimineto_apoderado.SelectedDate?.ToString("yyyy-MM-dd"),
                estado_civil_apoderado=estado_civil_apoderado.Text,
                ciudadania_apoderado=ciudadania_apoderado.Text,
                ocupacion_apoderado=ocupacion_apoderado.Text,
                direccion_particular_apoderado=direccion_particular_apoderado.Text,
                carne_pasaporte_apoderado=carne_pasaporte_apoderado.Text,
                condicion_migratoria_apoderado=condicion_migratoria_apoderado.Text,

                nombre_donatorio=nombre_donatorio.Text,
                sexo_donatorio=sexo_donatorio.Text,
                lugar_nacimiento_municipio_donatorio=lugar_nacimiento_municipio_donatorio.Text,
                lugar_nacimiento_provincia_donatorio=lugar_nacimiento_provincia_donatorio.Text,
                fecha_nacimineto_donatorio=fecha_nacimineto_donatorio.SelectedDate?.ToString("yyyy-MM-dd"),
                estado_civil_donatorio=estado_civil_donatorio.Text,
                ciudadania_donatorio=ciudadania_donatorio.Text,
                ocupacion_donatorio=ocupacion_donatorio.Text,
                direccion_particular_donatorio=direccion_particular_donatorio.Text,
                carne_pasaporte_donatorio=carne_pasaporte_donatorio.Text,
                condicion_migratoria_donatorio=condicion_migratoria_donatorio.Text,

                direccion_vivienda=direccion_vivienda.Text
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

        public bool ValidarAnexo( model.Anexo27_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.nombre_poderante)||
                string.IsNullOrEmpty(model.sexo_poderante)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_poderante)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_poderante)||
                string.IsNullOrEmpty(model.fecha_nacimineto_poderante)||
                string.IsNullOrEmpty(model.estado_civil_poderante)||
                string.IsNullOrEmpty(model.ciudadania_poderante)||
                string.IsNullOrEmpty(model.ocupacion_poderante)||
                string.IsNullOrEmpty(model.direccion_particular_poderante)||
                string.IsNullOrEmpty(model.carne_pasaporte_poderante)||
                string.IsNullOrEmpty(model.condicion_migratoria_poderante)||
                string.IsNullOrEmpty(model.correo_poderante)||
                string.IsNullOrEmpty(model.celular_poderante)||
                string.IsNullOrEmpty(model.nombre_apoderado)||
                string.IsNullOrEmpty(model.sexo_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_apoderado)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_apoderado)||
                string.IsNullOrEmpty(model.fecha_nacimineto_apoderado)||
                string.IsNullOrEmpty(model.estado_civil_apoderado)||
                string.IsNullOrEmpty(model.ciudadania_apoderado)||
                string.IsNullOrEmpty(model.ocupacion_apoderado)||
                string.IsNullOrEmpty(model.direccion_particular_apoderado)||
                string.IsNullOrEmpty(model.carne_pasaporte_apoderado)||
                string.IsNullOrEmpty(model.condicion_migratoria_apoderado)||
                string.IsNullOrEmpty(model.nombre_donatorio)||
                string.IsNullOrEmpty(model.sexo_donatorio)||
                string.IsNullOrEmpty(model.lugar_nacimiento_municipio_donatorio)||
                string.IsNullOrEmpty(model.lugar_nacimiento_provincia_donatorio)||
                string.IsNullOrEmpty(model.fecha_nacimineto_donatorio)||
                string.IsNullOrEmpty(model.estado_civil_donatorio)||
                string.IsNullOrEmpty(model.ciudadania_donatorio)||
                string.IsNullOrEmpty(model.ocupacion_donatorio)||
                string.IsNullOrEmpty(model.direccion_particular_donatorio)||
                string.IsNullOrEmpty(model.carne_pasaporte_donatorio)||
                string.IsNullOrEmpty(model.condicion_migratoria_donatorio)||
                string.IsNullOrEmpty(model.direccion_vivienda))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo27_e es válida
        }

    }
}
