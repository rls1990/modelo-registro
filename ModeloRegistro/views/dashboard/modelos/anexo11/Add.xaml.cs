using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo11
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo11_m manager = new model.Anexo11_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo11());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo11_e()
            {
                ciudad=ciudad.Text,
                pais=pais.Text,
                solicito_certificado=solicito_certificado.Text,
                de_mi=de_mi.Text,
                nombre_apellidos=nombre_apellidos.Text,
                fecha_nacimiento=fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                lugar_nacimiento=lugar_nacimiento.Text,
                nombre_padres=nombre_padres.Text,
                lugar_vivio_cuba=lugar_vivio_cuba.Text,
                fecha_fallecimiento=fecha_fallecimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                otros_datos_interes=otros_datos_interes.Text,
                nombre_apellidos_solicitante=nombre_apellidos_solicitante.Text,
                doc_identidad=doc_identidad.Text,
                pasaporte=pasaporte.Text,
                direccion=direccion.Text,
                telefono=telefono.Text,
                email=email.Text,
                legalizacion_minrex=legalizacion_minrex.Text,
                legalizacion_embajada=legalizacion_embajada.Text,
                fecha_de_solicitud=fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd")
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

        private bool ValidarAnexo( model.Anexo11_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
                   !string.IsNullOrWhiteSpace(anexo.pais)&&
                   !string.IsNullOrWhiteSpace(anexo.solicito_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.de_mi)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_padres)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_vivio_cuba)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.otros_datos_interes)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellidos_solicitante)&&
                   !string.IsNullOrWhiteSpace(anexo.doc_identidad)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
                   !string.IsNullOrWhiteSpace(anexo.direccion)&&
                   !string.IsNullOrWhiteSpace(anexo.telefono)&&
                   !string.IsNullOrWhiteSpace(anexo.email)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
                   !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
        }

    }
}
