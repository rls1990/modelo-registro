using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo2
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add:Page
    {
        private model.Anexo2_m manager = new model.Anexo2_m(Global.sqlite);
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo2());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {

        }

        public bool ValidarAnexo( model.Anexo2_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            if(
                //string.IsNullOrEmpty(model.pasaporte_1ra_vez)||
                //string.IsNullOrEmpty(model.prorrogas)||
                //string.IsNullOrEmpty(model.he_1)||
                //string.IsNullOrEmpty(model.he_4)||
                //string.IsNullOrEmpty(model.dvt)||
                //string.IsNullOrEmpty(model.renovacion_pasaporte)||
                //string.IsNullOrEmpty(model.habilitacion_de_entrada)||
                //string.IsNullOrEmpty(model.he_3)||
                //string.IsNullOrEmpty(model.he_11)||
                //string.IsNullOrEmpty(model.ccv)||
                string.IsNullOrEmpty(model.fecha_de_solicitud)||
                string.IsNullOrEmpty(model.no_pasaporte)||
                string.IsNullOrEmpty(model.carnet)||
                string.IsNullOrEmpty(model.primer_apellido)||
                string.IsNullOrEmpty(model.segundo_apellido)||
                string.IsNullOrEmpty(model.primer_nombre)||
                string.IsNullOrEmpty(model.segundo_nombre)||
                string.IsNullOrEmpty(model.padre)||
                string.IsNullOrEmpty(model.madre)||
                string.IsNullOrEmpty(model.caracteristicas_especiales)||
                string.IsNullOrEmpty(model.estatura)||
                string.IsNullOrEmpty(model.estado_civil)||
                string.IsNullOrEmpty(model.sexo)||
                string.IsNullOrEmpty(model.color_ojos)||
                string.IsNullOrEmpty(model.color_piel)||
                string.IsNullOrEmpty(model.color_cabello)||
                //string.IsNullOrEmpty(model.permiso_emigracion)||
                //string.IsNullOrEmpty(model.residente_en_el_exterior)||
                //string.IsNullOrEmpty(model.asunto_oficial)||
                //string.IsNullOrEmpty(model.pve)||
                //string.IsNullOrEmpty(model.psi)||
                //string.IsNullOrEmpty(model.residencia_exterior)||
                //string.IsNullOrEmpty(model.pre)||
                //string.IsNullOrEmpty(model.pvt)||
                //string.IsNullOrEmpty(model.pre_e)||
                //string.IsNullOrEmpty(model.salida_ilegal)||
                string.IsNullOrEmpty(model.fecha_de_salida)||
                string.IsNullOrEmpty(model.pais)||
                string.IsNullOrEmpty(model.provincia)||
                string.IsNullOrEmpty(model.municipio_ciudad)||
                string.IsNullOrEmpty(model.fecha_de_nacimiento)||
                string.IsNullOrEmpty(model.direccion)||
                string.IsNullOrEmpty(model.codigo_postal)||
                string.IsNullOrEmpty(model.provincia_estado_region)||
                string.IsNullOrEmpty(model.pais_residencia_actual)||
                string.IsNullOrEmpty(model.telefono_residencia)||
                string.IsNullOrEmpty(model.fax_residencia)||
                string.IsNullOrEmpty(model.email_residencia)||
                string.IsNullOrEmpty(model.nombre_centro_trabajo_estudio)||
                string.IsNullOrEmpty(model.profesion)||
                string.IsNullOrEmpty(model.ocupacion)||
                string.IsNullOrEmpty(model.direccion_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.codigo_postal_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.provincia_estado_region_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.pais_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.telefono_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.fax_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.email_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.nivel_de_escolaridad)||
                string.IsNullOrEmpty(model.ocupacion_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.profecion_oficio_centro_estudio_trabajo)||
                string.IsNullOrEmpty(model.nombre_referencia_cuba)||
                string.IsNullOrEmpty(model.direccion_referencia_cuba)||
                string.IsNullOrEmpty(model.direccion1_referencia)||
                string.IsNullOrEmpty(model.fecha_direccion1_referencia_desde)||
                string.IsNullOrEmpty(model.fecha_direccion1_referencia_fecha_hasta)||
                string.IsNullOrEmpty(model.direccion2_referencia)||
                string.IsNullOrEmpty(model.fecha_direccion2_referencia_desde)||
                string.IsNullOrEmpty(model.fecha_direccion2_referencia_fecha_hasta)||
                string.IsNullOrEmpty(model.apellido_soltera_referencia)||
                string.IsNullOrEmpty(model.otros_nombres_referencia)||
                string.IsNullOrEmpty(model.numero_residencia_referencia)||
                string.IsNullOrEmpty(model.pasaporte_extranjero_referencia)||
                string.IsNullOrEmpty(model.numero_pasaporte_vencido)||
                string.IsNullOrEmpty(model.fecha_expedicion_pasaporte_vencido)||
                string.IsNullOrEmpty(model.lugar_pasaporte_vencido)||
                string.IsNullOrEmpty(model.tomo_certificado_nacimiento)||
                string.IsNullOrEmpty(model.folio_certificado_nacimiento)||
                string.IsNullOrEmpty(model.registro_civil_certificado_nacimiento)||
                string.IsNullOrEmpty(model.numero_inscripcion_consular)||
                string.IsNullOrEmpty(model.fecha_inscripcion_consular)||
                string.IsNullOrEmpty(model.arancel_inscripcion_consular)||
                string.IsNullOrEmpty(model.valoracion_consular))
            {
                return false; // Algún campo es nulo o vacío
            }

            // Si todas las validaciones pasan
            return true; // La entidad Anexo2_e es válida
        }

    }
}
