using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo6
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo6_m manager = new model.Anexo6_m(Global.sqlite);
        private model.Anexo6_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo6_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;

            nombre_apellido_hombre.Text=entity.nombre_apellido_hombre;
            nombre_apellido_mujer.Text=entity.nombre_apellido_mujer;

            tribunal_dicto_sentencia.Text=entity.tribunal_dicto_sentencia;
            nombre_secretario_actuante.Text=entity.nombre_secretario_actuante;

            fecha_dicto_sentencia.Text=entity.fecha_dicto_sentencia;
            fecha_firmeza_sentencia.Text=entity.fecha_firmeza_sentencia;

            no_sentencia.Text=entity.no_sentencia;
            no_radicacion.Text=entity.no_radicacion;

            legalizacion_minred.Text=entity.legalizacion_minred;
            legalizacion_embajada.Text=entity.legalizacion_embajada;

            fecha_solicitud.Text=entity.fecha_solicitud;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo6());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo6 = new model.Anexo6_e()
            {
                id=entity.id,
                ciudad=ciudad.Text,
                pais=pais.Text,
                nombre_apellido_hombre=nombre_apellido_hombre.Text,
                nombre_apellido_mujer=nombre_apellido_mujer.Text,
                tribunal_dicto_sentencia=tribunal_dicto_sentencia.Text,
                nombre_secretario_actuante=nombre_secretario_actuante.Text,
                fecha_dicto_sentencia=fecha_dicto_sentencia.SelectedDate?.ToString("yyyy-MM-dd"),
                fecha_firmeza_sentencia=fecha_firmeza_sentencia.SelectedDate?.ToString("yyyy-MM-dd"),
                no_sentencia=no_sentencia.Text,
                no_radicacion=no_radicacion.Text,
                legalizacion_minred=legalizacion_minred.Text,
                legalizacion_embajada=legalizacion_embajada.Text,
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd")
            };

            if(ValidarAnexo(anexo6))
            {
                manager.update(anexo6);
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
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.nombre_apellido_hombre)||
                string.IsNullOrEmpty(model.nombre_apellido_mujer)||
                string.IsNullOrEmpty(model.tribunal_dicto_sentencia)||
                string.IsNullOrEmpty(model.nombre_secretario_actuante)||
                string.IsNullOrEmpty(model.fecha_dicto_sentencia)||
                string.IsNullOrEmpty(model.fecha_firmeza_sentencia)||
                string.IsNullOrEmpty(model.no_sentencia)||
                string.IsNullOrEmpty(model.no_radicacion)||
                string.IsNullOrEmpty(model.legalizacion_minred)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo6_e es válida
        }
    }
}
