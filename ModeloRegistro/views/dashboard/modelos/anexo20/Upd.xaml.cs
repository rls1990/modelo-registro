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
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo20_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            nombre_apellidos.Text=entity.nombre_apellidos;
            ciudadano.Text=entity.ciudadano;

            nombre_apellidos_menor_edad.Text=entity.nombre_apellidos_menor_edad;
            ciudadania_menor_edad.Text=entity.ciudadania_menor_edad;

            lugar_nacimiento_menor.Text=entity.lugar_nacimiento_menor;
            fecha_nacimiento_menor.Text=entity.fecha_nacimiento_menor;

            pasaporte_menor.Text=entity.pasaporte_menor;

            padre.Text=entity.padre;
            ciudadania_padre.Text=entity.ciudadania_padre;

            madre.Text=entity.madre;
            ciudadania_madre.Text=entity.ciudadania_madre;

            ultima_direccion_padres.Text=entity.ultima_direccion_padres;

            nombre_persona_representante_legal.Text=entity.nombre_persona_representante_legal;

            recidir_cuba.IsChecked=entity.recidir_cuba=="True";
            recidir_en_exterior.IsChecked=entity.recidir_en_exterior=="True";

            razones_personales.Text=entity.razones_personales;

            nombre_funcionario_consular.Text=entity.nombre_funcionario_consular;

            telefono.Text=entity.telefono;

            email.Text=entity.email;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo20());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo20_e()
            {
                id=entity.id,
                nombre_apellidos=nombre_apellidos.Text,
                ciudadano=ciudadano.Text,
                nombre_apellidos_menor_edad=nombre_apellidos_menor_edad.Text,
                ciudadania_menor_edad=ciudadania_menor_edad.Text,
                lugar_nacimiento_menor=lugar_nacimiento_menor.Text,
                fecha_nacimiento_menor=fecha_nacimiento_menor.SelectedDate?.ToString("yyyy-MM-dd"),
                pasaporte_menor=pasaporte_menor.Text,
                padre=padre.Text,
                ciudadania_padre=ciudadania_padre.Text,
                madre=madre.Text,
                ciudadania_madre=ciudadania_madre.Text,
                ultima_direccion_padres=ultima_direccion_padres.Text,
                nombre_persona_representante_legal=nombre_persona_representante_legal.Text,
                recidir_cuba=recidir_cuba.IsChecked.ToString(),
                recidir_en_exterior=recidir_en_exterior.IsChecked.ToString(),
                razones_personales=razones_personales.Text,
                nombre_funcionario_consular=nombre_funcionario_consular.Text,
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
