using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo12
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo12_m manager = new model.Anexo12_m(Global.sqlite);
        private model.Anexo12_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo12());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        private bool ValidarAnexo( model.Anexo12_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
                   !string.IsNullOrWhiteSpace(anexo.pais)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
                   !string.IsNullOrWhiteSpace(anexo.ciudadano)&&
                   !string.IsNullOrWhiteSpace(anexo.carnet_identidad)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.vecino_de)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_apoderado)&&
                   !string.IsNullOrWhiteSpace(anexo.si)&&
                   !string.IsNullOrWhiteSpace(anexo.no)&&
                   !string.IsNullOrWhiteSpace(anexo.numero)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_poder_especial)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_notario)&&
                   !string.IsNullOrWhiteSpace(anexo.competencia)&&
                   !string.IsNullOrWhiteSpace(anexo.sede)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
        }

    }
}
