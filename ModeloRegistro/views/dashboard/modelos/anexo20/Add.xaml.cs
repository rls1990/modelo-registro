using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo20
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo20_m manager = new model.Anexo20_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo20());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo20_e()
            {
                nombre_apellidos=ValidarCampo(nombre_apellidos.Text),
                ciudadano=ValidarCampo(ciudadano.Text),
                nombre_apellidos_menor_edad=ValidarCampo(nombre_apellidos_menor_edad.Text),
                ciudadania_menor_edad=ValidarCampo(ciudadania_menor_edad.Text),
                lugar_nacimiento_menor=ValidarCampo(lugar_nacimiento_menor.Text),
                fecha_nacimiento_menor=ValidarCampo(fecha_nacimiento_menor.SelectedDate?.ToString("yyyy-MM-dd")),
                pasaporte_menor=ValidarCampo(pasaporte_menor.Text),
                padre=ValidarCampo(padre.Text),
                ciudadania_padre=ValidarCampo(ciudadania_padre.Text),
                madre=ValidarCampo(madre.Text),
                ciudadania_madre=ValidarCampo(ciudadania_madre.Text),
                ultima_direccion_padres=ValidarCampo(ultima_direccion_padres.Text),
                nombre_persona_representante_legal=ValidarCampo(nombre_persona_representante_legal.Text),
                recidir_cuba=ValidarCampo(recidir_cuba.IsChecked.ToString()),
                recidir_en_exterior=ValidarCampo(recidir_en_exterior.IsChecked.ToString()),
                razones_personales=ValidarCampo(razones_personales.Text),
                nombre_funcionario_consular=ValidarCampo(nombre_funcionario_consular.Text),
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

        public bool ValidarAnexo( model.Anexo20_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(string.IsNullOrEmpty(model.nombre_apellidos)||
            //    string.IsNullOrEmpty(model.ciudadano)||
            //    string.IsNullOrEmpty(model.nombre_apellidos_menor_edad)||
            //    string.IsNullOrEmpty(model.ciudadania_menor_edad)||
            //    string.IsNullOrEmpty(model.lugar_nacimiento_menor)||
            //    string.IsNullOrEmpty(model.fecha_nacimiento_menor)||
            //    string.IsNullOrEmpty(model.pasaporte_menor)||
            //    string.IsNullOrEmpty(model.padre)||
            //    string.IsNullOrEmpty(model.ciudadania_padre)||
            //    string.IsNullOrEmpty(model.madre)||
            //    string.IsNullOrEmpty(model.ciudadania_madre)||
            //    string.IsNullOrEmpty(model.ultima_direccion_padres)||
            //    string.IsNullOrEmpty(model.nombre_persona_representante_legal)||
            //    //string.IsNullOrEmpty(model.recidir_cuba)||
            //    //string.IsNullOrEmpty(model.recidir_en_exterior)||
            //    string.IsNullOrEmpty(model.razones_personales)||
            //    string.IsNullOrEmpty(model.nombre_funcionario_consular)||
            //    string.IsNullOrEmpty(model.telefono)||
            //    string.IsNullOrEmpty(model.email))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo20_e es válida
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
