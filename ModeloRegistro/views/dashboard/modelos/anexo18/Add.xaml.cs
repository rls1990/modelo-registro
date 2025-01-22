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
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_hijo_menor)&&
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
