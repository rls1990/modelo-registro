using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo18
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo18_m manager = new model.Anexo18_m(Global.sqlite);
        private model.Anexo18_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo18_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            nombre_hombre.Text=entity.nombre_hombre;
            nombre_mujer.Text=entity.nombre_mujer;
            ciudadania_hombre.Text=entity.ciudadania_hombre;
            ciudadania_mujer.Text=entity.ciudadania_mujer;

            lugar_nacimiento_hombre.Text=entity.lugar_nacimiento_hombre;
            lugar_nacimiento_mujer.Text=entity.lugar_nacimiento_mujer;

            fecha_nacimiento_hombre.Text=entity.fecha_nacimiento_hombre;
            fecha_nacimiento_mujer.Text=entity.fecha_nacimiento_mujer;

            pasaporte_hombre.Text=entity.pasaporte_hombre;
            pasaporte_mujer.Text=entity.pasaporte_mujer;

            nombre_hijo_menor.Text=entity.nombre_hijo_menor;
            ciudadania_hijo_menor.Text=entity.ciudadania_hijo_menor;

            lugar_nacimineto_hijo_menor.Text=entity.lugar_nacimineto_hijo_menor;
            fecha_nacimiento_hijo_menor.Text=entity.fecha_nacimiento_hijo_menor;

            pasaporte_hijo_menor.Text=entity.pasaporte_hijo_menor;

            padre.Text=entity.padre;
            ciudadania_padre.Text=entity.ciudadania_padre;

            madre.Text=entity.madre;
            ciudadania_madre.Text=entity.ciudadania_madre;

            ultima_direccion_cuba.Text=entity.ultima_direccion_cuba;

            recidir_cuba.IsChecked=entity.recidir_cuba=="True";
            recidir_en_exterior.IsChecked=entity.recidir_en_exterior=="True";

            razones_personales.Text=entity.razones_personales;

            nombre_funcionario.Text=entity.nombre_funcionario;

            telefono.Text=entity.telefono;

            email.Text=entity.email;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo18());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo18_e()
            {
                id=entity.id,
                nombre_hombre=ValidarCampo(nombre_hombre.Text),
                nombre_mujer=ValidarCampo(nombre_mujer.Text),
                ciudadania_hombre=ValidarCampo(ciudadania_hombre.Text),
                ciudadania_mujer=ValidarCampo(ciudadania_mujer.Text),
                lugar_nacimiento_hombre=ValidarCampo(lugar_nacimiento_hombre.Text),
                lugar_nacimiento_mujer=ValidarCampo(lugar_nacimiento_mujer.Text),
                fecha_nacimiento_hombre=ValidarCampo(fecha_nacimiento_hombre.SelectedDate?.ToString("yyyy-MM-dd")),
                fecha_nacimiento_mujer=ValidarCampo(fecha_nacimiento_mujer.SelectedDate?.ToString("yyyy-MM-dd")),
                pasaporte_hombre=ValidarCampo(pasaporte_hombre.Text),
                pasaporte_mujer=ValidarCampo(pasaporte_mujer.Text),
                nombre_hijo_menor=ValidarCampo(nombre_hijo_menor.Text),
                ciudadania_hijo_menor=ValidarCampo(ciudadania_hijo_menor.Text),
                lugar_nacimineto_hijo_menor=ValidarCampo(lugar_nacimineto_hijo_menor.Text),
                fecha_nacimiento_hijo_menor=ValidarCampo(fecha_nacimiento_hijo_menor.SelectedDate?.ToString("yyyy-MM-dd")),
                pasaporte_hijo_menor=ValidarCampo(pasaporte_hijo_menor.Text),
                padre=ValidarCampo(padre.Text),
                ciudadania_padre=ValidarCampo(ciudadania_padre.Text),
                madre=ValidarCampo(madre.Text),
                ciudadania_madre=ValidarCampo(ciudadania_madre.Text),
                ultima_direccion_cuba=ValidarCampo(ultima_direccion_cuba.Text),
                recidir_cuba=ValidarCampo(recidir_cuba.IsChecked.ToString()),
                recidir_en_exterior=ValidarCampo(recidir_en_exterior.IsChecked.ToString()),
                razones_personales=ValidarCampo(razones_personales.Text),
                nombre_funcionario=ValidarCampo(nombre_funcionario.Text),
                telefono=ValidarCampo(telefono.Text),
                email=ValidarCampo(email.Text)
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
        private bool ValidarAnexo( model.Anexo18_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            //return !string.IsNullOrWhiteSpace(anexo.nombre_hombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_mujer)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_hombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_mujer)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_hombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento_mujer)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_hombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_mujer)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte_hombre)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte_mujer)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_hijo_menor)&&
            //       //!string.IsNullOrWhiteSpace(anexo.ciudadania_hijo_menor)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto_hijo_menor)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento_hijo_menor)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte_hijo_menor)&&
            //       !string.IsNullOrWhiteSpace(anexo.padre)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_padre)&&
            //       !string.IsNullOrWhiteSpace(anexo.madre)&&
            //       !string.IsNullOrWhiteSpace(anexo.ciudadania_madre)&&
            //       !string.IsNullOrWhiteSpace(anexo.ultima_direccion_cuba)&&
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
