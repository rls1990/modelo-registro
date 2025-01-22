using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo7
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo7_m manager = new model.Anexo7_m(Global.sqlite);
        private model.Anexo7_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo7_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;

            nombre_apellido.Text=entity.nombre_apellido;
            fecha_defuncion.Text=entity.fecha_defuncion;

            municipio_fallecimineto.Text=entity.municipio_fallecimineto;
            provincia_fallecimineto.Text=entity.provincia_fallecimineto;

            donde_fue_velado.Text=entity.donde_fue_velado;

            municipio_funeraria.Text=entity.municipio_funeraria;
            provincia_funeraria.Text=entity.provincia_funeraria;

            tomo.Text=entity.tomo;
            folio.Text=entity.folio;

            legalizacion_minrex.Text=entity.legalizacion_minrex;
            legalizacion_embajada.Text=entity.legalizacion_embajada;

            fecha_de_solicitud.Text=entity.fecha_de_solicitud;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo7());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo7_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.nombre_apellido)||
                string.IsNullOrEmpty(model.fecha_defuncion)||
                string.IsNullOrEmpty(model.municipio_fallecimineto)||
                string.IsNullOrEmpty(model.provincia_fallecimineto)||
                string.IsNullOrEmpty(model.donde_fue_velado)||
                string.IsNullOrEmpty(model.municipio_funeraria)||
                string.IsNullOrEmpty(model.provincia_funeraria)||
                string.IsNullOrEmpty(model.tomo)||
                string.IsNullOrEmpty(model.folio)||
                string.IsNullOrEmpty(model.legalizacion_minrex)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_de_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo7_e es válida
        }
    }
}
