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

namespace ModeloRegistro.views.dashboard.modelos.anexo15
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo15_m manager = new model.Anexo15_m(Global.sqlite);
        private model.Anexo15_e entity;
        public Upd()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo15());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        private bool ValidarAnexo( model.Anexo15_e anexo )
        {
            if(anexo==null)
                return false; // Retorna false si el objeto es nulo

            // Verificar cada campo de la entidad
            return !string.IsNullOrWhiteSpace(anexo.nombre_fallecido)&&
                   //!string.IsNullOrWhiteSpace(anexo.m)&&
                   //!string.IsNullOrWhiteSpace(anexo.f)&&
                   !string.IsNullOrWhiteSpace(anexo.primer_apellido_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.segundo_apellido_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.hora_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_fallecimineto)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_nacimineto_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.municipio_provincia_pais_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_nacimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.pasaporte_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.edad_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.folio_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.estado_civil_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.ocupacion_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.padre_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.madre_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.domicilio_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_defuncion)&&
                   !string.IsNullOrWhiteSpace(anexo.hora_defuncion)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.causa_muerte_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.enfermedad_causa_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_medico_certifica_fallecimiento)&&
                   !string.IsNullOrWhiteSpace(anexo.lugar_cepultura)&&
                   !string.IsNullOrWhiteSpace(anexo.registro_civil)&&
                   !string.IsNullOrWhiteSpace(anexo.tomo)&&
                   !string.IsNullOrWhiteSpace(anexo.folio)&&
                   !string.IsNullOrWhiteSpace(anexo.fecha_certificado)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_solicita)&&
                   !string.IsNullOrWhiteSpace(anexo.nro_pasaporte_carnet)&&
                   !string.IsNullOrWhiteSpace(anexo.parentesco_fallecido)&&
                   !string.IsNullOrWhiteSpace(anexo.direccion_solicita)&&
                   !string.IsNullOrWhiteSpace(anexo.nombre_apellido_funcionario_consular);
        }
    }
}
