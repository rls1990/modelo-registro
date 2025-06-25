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
                ciudad=ValidarCampo(ciudad.Text),
                pais=ValidarCampo(pais.Text),
                solicito_certificado=ValidarCampo(solicito_certificado.Text),
                de_mi=ValidarCampo(de_mi.Text),
                nombre_apellidos=ValidarCampo(nombre_apellidos.Text),
                fecha_nacimiento=ValidarCampo(fecha_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                lugar_nacimiento=ValidarCampo(lugar_nacimiento.Text),
                nombre_padres=ValidarCampo(nombre_padres.Text),
                lugar_vivio_cuba=ValidarCampo(lugar_vivio_cuba.Text),
                fecha_fallecimiento=ValidarCampo(fecha_fallecimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                otros_datos_interes=ValidarCampo(otros_datos_interes.Text),
                nombre_apellidos_solicitante=ValidarCampo(nombre_apellidos_solicitante.Text),
                doc_identidad=ValidarCampo(doc_identidad.Text),
                pasaporte=ValidarCampo(pasaporte.Text),
                direccion=ValidarCampo(direccion.Text),
                telefono=ValidarCampo(telefono.Text),
                email=ValidarCampo(email.Text),
                legalizacion_minrex=ValidarCampo(legalizacion_minrex.Text),
                legalizacion_embajada=ValidarCampo(legalizacion_embajada.Text),
                fecha_de_solicitud=ValidarCampo(fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd"))
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
            //return !string.IsNullOrWhiteSpace(anexo.ciudad)&&
            //       !string.IsNullOrWhiteSpace(anexo.pais)&&
            //       !string.IsNullOrWhiteSpace(anexo.solicito_certificado)&&
            //       !string.IsNullOrWhiteSpace(anexo.de_mi)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellidos)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_nacimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_padres)&&
            //       !string.IsNullOrWhiteSpace(anexo.lugar_vivio_cuba)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_fallecimiento)&&
            //       !string.IsNullOrWhiteSpace(anexo.otros_datos_interes)&&
            //       !string.IsNullOrWhiteSpace(anexo.nombre_apellidos_solicitante)&&
            //       !string.IsNullOrWhiteSpace(anexo.doc_identidad)&&
            //       !string.IsNullOrWhiteSpace(anexo.pasaporte)&&
            //       !string.IsNullOrWhiteSpace(anexo.direccion)&&
            //       !string.IsNullOrWhiteSpace(anexo.telefono)&&
            //       !string.IsNullOrWhiteSpace(anexo.email)&&
            //       !string.IsNullOrWhiteSpace(anexo.legalizacion_minrex)&&
            //       !string.IsNullOrWhiteSpace(anexo.legalizacion_embajada)&&
            //       !string.IsNullOrWhiteSpace(anexo.fecha_de_solicitud);
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
