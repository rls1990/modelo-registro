using ModeloRegistro.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModeloRegistro.views.dashboard.modelos.anexo10
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo10_m manager = new model.Anexo10_m(Global.sqlite);
        private model.Anexo10_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo10());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        private bool ValidarAnexo( model.Anexo10_e anexo )
        {
            // Verificar si cada campo de la entidad no es un string vacío
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
