using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo9
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo9_m manager = new model.Anexo9_m(Global.sqlite);
        private model.Anexo9_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo9_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            ciudad.Text=entity.ciudad;
            pais.Text=entity.pais;

            encargado_registro_civil.Text=entity.encargado_registro_civil;
            municipio_encargado.Text=entity.municipio_encargado;
            provincia_encargado.Text=entity.provincia_encargado;

            nombre.Text=entity.nombre;
            fecha_solicitud.Text=entity.fecha_solicitud;

            tomo_certificado.Text=entity.tomo_certificado;
            folio_certificado.Text=entity.folio_certificado;

            fecha_nacimiento.Text=entity.fecha_nacimiento;

            municipio_persona.Text=entity.municipio_persona;
            provincia_persona.Text=entity.provincia_persona;

            padre.Text=entity.padre;
            madre.Text=entity.madre;

            legalizacion_minrex.Text=entity.legalizacion_minrex;
            legalizacion_embajada.Text=entity.legalizacion_embajada;

            fecha_de_solicitud.Text=entity.fecha_de_solicitud;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo9());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo9 = new model.Anexo9_e()
            {
                id=entity.id,
                ciudad=ciudad.Text,
                pais=pais.Text,
                encargado_registro_civil=encargado_registro_civil.Text,
                municipio_encargado=municipio_encargado.Text,
                provincia_encargado=provincia_encargado.Text,
                nombre=nombre.Text,
                fecha_solicitud=fecha_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                tomo_certificado=tomo_certificado.Text,
                folio_certificado=folio_certificado.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                municipio_persona=municipio_persona.Text,
                provincia_persona=provincia_persona.Text,
                padre=padre.Text,
                madre=madre.Text,
                legalizacion_minrex=legalizacion_minrex.Text,
                legalizacion_embajada=legalizacion_embajada.Text
            };

            if(ValidarAnexo(anexo9))
            {
                manager.update(anexo9);
                MessageBox.Show("Anexo 9 guardado exitosamente.");
            } else
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.","Errores de Validación",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        public bool ValidarAnexo( model.Anexo9_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(string.IsNullOrEmpty(model.ciudad)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.encargado_registro_civil)||
                string.IsNullOrEmpty(model.municipio_encargado)||
                string.IsNullOrEmpty(model.provincia_encargado)||
                string.IsNullOrEmpty(model.nombre)||
                string.IsNullOrEmpty(model.fecha_solicitud)||
                string.IsNullOrEmpty(model.tomo_certificado)||
                string.IsNullOrEmpty(model.folio_certificado)||
                string.IsNullOrEmpty(model.fecha_nacimiento)||
                string.IsNullOrEmpty(model.municipio_persona)||
                string.IsNullOrEmpty(model.provincia_persona)||
                string.IsNullOrEmpty(model.padre)||
                string.IsNullOrEmpty(model.madre)||
                string.IsNullOrEmpty(model.legalizacion_minrex)||
                string.IsNullOrEmpty(model.legalizacion_embajada)||
                string.IsNullOrEmpty(model.fecha_de_solicitud))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo9_e es válida
        }
    }
}
