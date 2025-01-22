using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo17
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo17_m manager = new model.Anexo17_m(Global.sqlite);
        private model.Anexo17_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo17_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            nombre_apellidos.Text=entity.nombre_apellidos;
            ciudadano.Text=entity.ciudadano;
            lugar_nacimiento.Text=entity.lugar_nacimiento;
            fecha_nacimiento.Text=entity.fecha_nacimiento;
            pasaporte.Text=entity.pasaporte;

            padre.Text=entity.padre;
            ciudadania_padre.Text=entity.ciudadania_padre;

            madre.Text=entity.madre;
            ciudadania_madre.Text=entity.ciudadania_madre;

            recidir_cuba.IsChecked=entity.recidir_cuba=="True";
            recidir_en_exterior.IsChecked=entity.recidir_en_exterior=="True";

            razones_personales.Text=entity.razones_personales;

            nombre_funcionario.Text=entity.nombre_funcionario;
            telefono.Text=entity.telefono;
            email.Text=entity.email;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo17());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        private bool ValidarAnexo( model.Anexo17_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadano)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
                   !string.IsNullOrWhiteSpace(anexo.padre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_padre)&&
                   !string.IsNullOrWhiteSpace(anexo.madre)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadania_madre)&&
                   //!string.IsNullOrWhiteSpace(anexo.recidir_cuba)&&
                   //!string.IsNullOrWhiteSpace(anexo.recidir_en_exterior)&&
                   !string.IsNullOrWhiteSpace(anexo.razones_personales)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_funcionario)&&
                   !string.IsNullOrWhiteSpace(anexo.telefono)&&
                   !string.IsNullOrWhiteSpace(anexo.email);
        }
    }
}
