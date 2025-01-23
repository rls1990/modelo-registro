using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo22
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo22_m manager = new model.Anexo22_m(Global.sqlite);
        private model.Anexo22_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo22_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            fecha_solicitud.Text=entity.fecha_solicitud;
            nombre.Text=entity.nombre;
            ciudadania.Text=entity.ciudadania;
            estado_civil.Text=entity.estado_civil;
            fecha_nacimiento.Text=entity.fecha_nacimiento;
            profecion.Text=entity.profecion;
            carnet_pasaporte.Text=entity.carnet_pasaporte;
            categoria_migratoria.Text=entity.categoria_migratoria;
            direccion_estados_unidos.Text=entity.direccion_estados_unidos;
            correo.Text=entity.correo;
            celular.Text=entity.celular;
            documento_legalizar.Text=entity.documento_legalizar;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo22());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo22_e()
            {
                id=entity.id,
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                nombre=nombre.Text,
                ciudadania=ciudadania.Text,
                estado_civil=estado_civil.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                profecion=profecion.Text,
                carnet_pasaporte=carnet_pasaporte.Text,
                categoria_migratoria=categoria_migratoria.Text,
                direccion_estados_unidos=direccion_estados_unidos.Text,
                correo=correo.Text,
                celular=celular.Text,
                documento_legalizar=documento_legalizar.Text
            };

            if(ValidarAnexo(anexo))
            {
                manager.update(anexo);
                MessageBox.Show("Anexo guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo22_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.nombre)||
                string.IsNullOrEmpty(model.ciudadania)||
                string.IsNullOrEmpty(model.estado_civil)||
                string.IsNullOrEmpty(model.fecha_nacimiento)||
                string.IsNullOrEmpty(model.profecion)||
                string.IsNullOrEmpty(model.carnet_pasaporte)||
                string.IsNullOrEmpty(model.categoria_migratoria)||
                string.IsNullOrEmpty(model.direccion_estados_unidos)||
                string.IsNullOrEmpty(model.correo)||
                string.IsNullOrEmpty(model.celular)||
                string.IsNullOrEmpty(model.documento_legalizar))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo22_e es válida
        }
    }
}
