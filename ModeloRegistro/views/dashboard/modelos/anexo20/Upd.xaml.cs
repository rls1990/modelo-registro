using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo20
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo20_m manager = new model.Anexo20_m(Global.sqlite);
        private model.Anexo20_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo20());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo20_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.nombre_apellidos)||
                string.IsNullOrEmpty(model.ciudadano)||
                string.IsNullOrEmpty(model.nombre_apellidos_menor_edad)||
                string.IsNullOrEmpty(model.ciudadania_menor_edad)||
                string.IsNullOrEmpty(model.lugar_nacimiento_menor)||
                string.IsNullOrEmpty(model.fecha_nacimiento_menor)||
                string.IsNullOrEmpty(model.pasaporte_menor)||
                string.IsNullOrEmpty(model.padre)||
                string.IsNullOrEmpty(model.ciudadania_padre)||
                string.IsNullOrEmpty(model.madre)||
                string.IsNullOrEmpty(model.ciudadania_madre)||
                string.IsNullOrEmpty(model.ultima_direccion_padres)||
                string.IsNullOrEmpty(model.nombre_persona_representante_legal)||
                //string.IsNullOrEmpty(model.recidir_cuba)||
                //string.IsNullOrEmpty(model.recidir_en_exterior)||
                string.IsNullOrEmpty(model.razones_personales)||
                string.IsNullOrEmpty(model.nombre_funcionario_consular)||
                string.IsNullOrEmpty(model.telefono)||
                string.IsNullOrEmpty(model.email))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo20_e es válida
        }
    }
}
