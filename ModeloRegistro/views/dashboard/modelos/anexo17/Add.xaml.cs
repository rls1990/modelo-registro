using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo17
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo17_m manager = new model.Anexo17_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo17());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo17_e()
            {
                nombre_apellidos=ValidarCampo(nombre_apellidos.Text),
                ciudadano=ValidarCampo(ciudadano.Text),
                lugar_nacimiento=ValidarCampo(lugar_nacimiento.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                pasaporte=ValidarCampo(pasaporte.Text),
                padre=ValidarCampo(padre.Text),
                ciudadania_padre=ValidarCampo(ciudadania_padre.Text),
                madre=ValidarCampo(madre.Text),
                ciudadania_madre=ValidarCampo(ciudadania_madre.Text),
                recidir_cuba=ValidarCampo(recidir_cuba.IsChecked.ToString()),
                recidir_en_exterior=ValidarCampo(recidir_en_exterior.IsChecked.ToString()),
                razones_personales=ValidarCampo(razones_personales.Text),
                nombre_funcionario=ValidarCampo(nombre_funcionario.Text),
                telefono=ValidarCampo(telefono.Text),
                email=ValidarCampo(email.Text)
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

        private bool ValidarAnexo( model.Anexo17_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            //return !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadano)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
            //       !string.IsNullOrWhiteSpace(anexo.padre)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_padre)&&
            //       !string.IsNullOrWhiteSpace(anexo.madre)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_madre)&&
            //       //!string.IsNullOrWhiteSpace(anexo.recidir_cuba)&&
            //       //!string.IsNullOrWhiteSpace(anexo.recidir_en_exterior)&&
            //       !string.IsNullOrWhiteSpace(anexo.razones_personales)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_funcionario)&&
            //       !string.IsNullOrWhiteSpace(anexo.telefono)&&
            //       !string.IsNullOrWhiteSpace(anexo.email);

            return true;
        }

        private string ValidarCampo( string val )
        {
            string res = "";
            if(!string.IsNullOrWhiteSpace(val))
                res=val;
            return res;
        }
    }
}
