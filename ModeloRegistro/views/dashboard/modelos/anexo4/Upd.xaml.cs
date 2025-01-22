using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo4
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo4_m manager = new model.Anexo4_m(Global.sqlite);
        private model.Anexo4_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo4());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo4_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.f_name)||
                string.IsNullOrEmpty(model.s_name)||
                string.IsNullOrEmpty(model.f_apellido)||
                string.IsNullOrEmpty(model.s_apellido)||
                string.IsNullOrEmpty(model.lugar_nacimiento)||
                string.IsNullOrEmpty(model.ciudadania)||
                string.IsNullOrEmpty(model.nacionalidad)||
                string.IsNullOrEmpty(model.estado_civil)||
                string.IsNullOrEmpty(model.fecha_nacimiento)||
                string.IsNullOrEmpty(model.sexo)||
                string.IsNullOrEmpty(model.color_piel)||
                string.IsNullOrEmpty(model.profecion_oficio_ocupacion)||
                string.IsNullOrEmpty(model.nombre_padre)||
                string.IsNullOrEmpty(model.nombre_madre)||
                string.IsNullOrEmpty(model.carnet_identidad)||
                string.IsNullOrEmpty(model.pasaporte)||
                string.IsNullOrEmpty(model.calle)||
                string.IsNullOrEmpty(model.numero)||
                string.IsNullOrEmpty(model.entre)||
                string.IsNullOrEmpty(model.y)||
                string.IsNullOrEmpty(model.barrio)||
                string.IsNullOrEmpty(model.municipio)||
                string.IsNullOrEmpty(model.provincia)||
                string.IsNullOrEmpty(model.legalizacion_minred)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo4_e es válida
        }
    }
}
