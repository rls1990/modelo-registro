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
            var anexo = new model.Anexo2_e()
            {
                pasaporte_1ra_vez=ValidarCampo(pasaporte_1ra_vez.IsChecked.ToString()),
                prorrogas=ValidarCampo(prorrogas.IsChecked.ToString()),
                he_1=ValidarCampo(he_1.IsChecked.ToString()),
                he_4=ValidarCampo(he_4.IsChecked.ToString()),
                dvt=ValidarCampo(dvt.IsChecked.ToString()),
                renovacion_pasaporte=ValidarCampo(renovacion_pasaporte.IsChecked.ToString()),
                habilitacion_de_entrada=ValidarCampo(habilitacion_de_entrada.IsChecked.ToString()),
                he_3=ValidarCampo(he_3.IsChecked.ToString()),
                he_11=ValidarCampo(he_11.IsChecked.ToString()),
                ccv=ValidarCampo(ccv.IsChecked.ToString()),
                fecha_de_solicitud=ValidarCampo(fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd")),
                no_pasaporte=ValidarCampo(no_pasaporte.Text),
                carnet=ValidarCampo(carnet.Text),
                primer_apellido=ValidarCampo(primer_apellido.Text),
                segundo_apellido=ValidarCampo(segundo_apellido.Text),
                primer_nombre=ValidarCampo(primer_nombre.Text),
                segundo_nombre=ValidarCampo(segundo_nombre.Text),
                padre=ValidarCampo(padre.Text),
                madre=ValidarCampo(madre.Text),
                caracteristicas_especiales=ValidarCampo(caracteristicas_especiales.Text),
                estatura=ValidarCampo(estatura.Text),
                estado_civil=ValidarCampo(estado_civil.Text),
                sexo=ValidarCampo(sexo.Text),
                color_ojos=ValidarCampo(color_ojos.Text),
                color_piel=ValidarCampo(color_piel.Text),
                color_cabello=ValidarCampo(color_cabello.Text),
                permiso_emigracion=ValidarCampo(permiso_emigracion.IsChecked.ToString()),
                residente_en_el_exterior=ValidarCampo(residente_en_el_exterior.IsChecked.ToString()),
                asunto_oficial=ValidarCampo(asunto_oficial.IsChecked.ToString()),
                pve=ValidarCampo(pve.IsChecked.ToString()),
                psi=ValidarCampo(psi.IsChecked.ToString()),
                residencia_exterior=ValidarCampo(residencia_exterior.IsChecked.ToString()),
                pre=ValidarCampo(pre.IsChecked.ToString()),
                pvt=ValidarCampo(pvt.IsChecked.ToString()),
                pre_e=ValidarCampo(pre_e.IsChecked.ToString()),
                salida_ilegal=ValidarCampo(salida_ilegal.IsChecked.ToString()),
                fecha_de_salida=ValidarCampo(fecha_de_salida.SelectedDate?.ToString("yyyy-MM-dd")),
                pais=ValidarCampo(pais.Text),
                provincia=ValidarCampo(provincia.Text),
                municipio_ciudad=ValidarCampo(municipio_ciudad.Text),
                fecha_de_nacimiento=ValidarCampo(fecha_de_nacimiento.SelectedDate?.ToString("yyyy-MM-dd")),
                direccion=ValidarCampo(direccion.Text),
                codigo_postal=ValidarCampo(codigo_postal.Text),
                provincia_estado_region=ValidarCampo(provincia_estado_region.Text),
                pais_residencia_actual=ValidarCampo(pais_residencia_actual.Text),
                telefono_residencia=ValidarCampo(telefono_residencia.Text),
                fax_residencia=ValidarCampo(fax_residencia.Text),
                email_residencia=ValidarCampo(email_residencia.Text),


                nombre_centro_trabajo_estudio=ValidarCampo(nombre_centro_trabajo_estudio.Text),

                profesion=ValidarCampo(profesion.Text),

                ocupacion=ValidarCampo(ocupacion.Text),

                direccion_centro_estudio_trabajo=ValidarCampo(direccion_centro_estudio_trabajo.Text),

                codigo_postal_centro_estudio_trabajo=ValidarCampo(codigo_postal_centro_estudio_trabajo.Text),

                provincia_estado_region_centro_estudio_trabajo=ValidarCampo(provincia_estado_region_centro_estudio_trabajo.Text),

                pais_centro_estudio_trabajo=ValidarCampo(pais_centro_estudio_trabajo.Text),

                telefono_centro_estudio_trabajo=ValidarCampo(telefono_centro_estudio_trabajo.Text),

                fax_centro_estudio_trabajo=ValidarCampo(fax_centro_estudio_trabajo.Text),

                email_centro_estudio_trabajo=ValidarCampo(email_centro_estudio_trabajo.Text),

                nivel_de_escolaridad=ValidarCampo(nivel_de_escolaridad.Text),

                ocupacion_centro_estudio_trabajo=ValidarCampo(ocupacion_centro_estudio_trabajo.Text),

                profecion_oficio_centro_estudio_trabajo=ValidarCampo(profecion_oficio_centro_estudio_trabajo.Text),

                nombre_referencia_cuba=ValidarCampo(nombre_referencia_cuba.Text),

                direccion_referencia_cuba=ValidarCampo(direccion_referencia_cuba.Text),

                direccion1_referencia=ValidarCampo(direccion1_referencia.Text),

                fecha_direccion1_referencia_desde=ValidarCampo(fecha_direccion1_referencia_desde.SelectedDate?.ToString("yyyy-MM-dd")),

                fecha_direccion1_referencia_fecha_hasta=ValidarCampo(fecha_direccion1_referencia_fecha_hasta.SelectedDate?.ToString("yyyy-MM-dd")),

                direccion2_referencia=ValidarCampo(direccion2_referencia.Text),

                fecha_direccion2_referencia_desde=ValidarCampo(fecha_direccion2_referencia_desde.SelectedDate?.ToString("yyyy-MM-dd")),

                fecha_direccion2_referencia_fecha_hasta=ValidarCampo(fecha_direccion2_referencia_fecha_hasta.SelectedDate?.ToString("yyyy-MM-dd")),

                apellido_soltera_referencia=ValidarCampo(apellido_soltera_referencia.Text),

                otros_nombres_referencia=ValidarCampo(otros_nombres_referencia.Text),

                numero_residencia_referencia=ValidarCampo(numero_residencia_referencia.Text),

                pasaporte_extranjero_referencia=ValidarCampo(pasaporte_extranjero_referencia.Text),

                numero_pasaporte_vencido=ValidarCampo(numero_pasaporte_vencido.Text),

                fecha_expedicion_pasaporte_vencido=ValidarCampo(fecha_expedicion_pasaporte_vencido.SelectedDate?.ToString("yyyy-MM-dd")),

                lugar_pasaporte_vencido=ValidarCampo(lugar_pasaporte_vencido.Text),

                tomo_certificado_nacimiento=ValidarCampo(tomo_certificado_nacimiento.Text),

                folio_certificado_nacimiento=ValidarCampo(folio_certificado_nacimiento.Text),

                registro_civil_certificado_nacimiento=ValidarCampo(registro_civil_certificado_nacimiento.Text),

                numero_inscripcion_consular=ValidarCampo(numero_inscripcion_consular.Text),

                fecha_inscripcion_consular=ValidarCampo(fecha_inscripcion_consular.SelectedDate?.ToString("yyyy-MM-dd")),

                arancel_inscripcion_consular=ValidarCampo(arancel_inscripcion_consular.Text),

                valoracion_consular=ValidarCampo(valoracion_consular.Text)
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

        public bool ValidarAnexo( model.Anexo2_e model )
        {
            // Verificar si el modelo es nulo
            if(model==null)
            {
                return false; // El modelo es nulo
            }

            // Verificar si cada campo es nulo o vacío
            //if(
            //    //string.IsNullOrEmpty(model.pasaporte_1ra_vez)||
            //    //string.IsNullOrEmpty(model.prorrogas)||
            //    //string.IsNullOrEmpty(model.he_1)||
            //    //string.IsNullOrEmpty(model.he_4)||
            //    //string.IsNullOrEmpty(model.dvt)||
            //    //string.IsNullOrEmpty(model.renovacion_pasaporte)||
            //    //string.IsNullOrEmpty(model.habilitacion_de_entrada)||
            //    //string.IsNullOrEmpty(model.he_3)||
            //    //string.IsNullOrEmpty(model.he_11)||
            //    //string.IsNullOrEmpty(model.ccv)||
            //    string.IsNullOrEmpty(model.fecha_de_solicitud)||
            //    string.IsNullOrEmpty(model.no_pasaporte)||
            //    string.IsNullOrEmpty(model.carnet)||
            //    string.IsNullOrEmpty(model.primer_apellido)||
            //    string.IsNullOrEmpty(model.segundo_apellido)||
            //    string.IsNullOrEmpty(model.primer_nombre)||
            //    string.IsNullOrEmpty(model.segundo_nombre)||
            //    string.IsNullOrEmpty(model.padre)||
            //    string.IsNullOrEmpty(model.madre)||
            //    string.IsNullOrEmpty(model.caracteristicas_especiales)||
            //    string.IsNullOrEmpty(model.estatura)||
            //    string.IsNullOrEmpty(model.estado_civil)||
            //    string.IsNullOrEmpty(model.sexo)||
            //    string.IsNullOrEmpty(model.color_ojos)||
            //    string.IsNullOrEmpty(model.color_piel)||
            //    string.IsNullOrEmpty(model.color_cabello)||
            //    //string.IsNullOrEmpty(model.permiso_emigracion)||
            //    //string.IsNullOrEmpty(model.residente_en_el_exterior)||
            //    //string.IsNullOrEmpty(model.asunto_oficial)||
            //    //string.IsNullOrEmpty(model.pve)||
            //    //string.IsNullOrEmpty(model.psi)||
            //    //string.IsNullOrEmpty(model.residencia_exterior)||
            //    //string.IsNullOrEmpty(model.pre)||
            //    //string.IsNullOrEmpty(model.pvt)||
            //    //string.IsNullOrEmpty(model.pre_e)||
            //    //string.IsNullOrEmpty(model.salida_ilegal)||
            //    string.IsNullOrEmpty(model.fecha_de_salida)||
            //    string.IsNullOrEmpty(model.pais)||
            //    string.IsNullOrEmpty(model.provincia)||
            //    string.IsNullOrEmpty(model.municipio_ciudad)||
            //    string.IsNullOrEmpty(model.fecha_de_nacimiento)||
            //    string.IsNullOrEmpty(model.direccion)||
            //    string.IsNullOrEmpty(model.codigo_postal)||
            //    string.IsNullOrEmpty(model.provincia_estado_region)||
            //    string.IsNullOrEmpty(model.pais_residencia_actual)||
            //    string.IsNullOrEmpty(model.telefono_residencia)||
            //    string.IsNullOrEmpty(model.fax_residencia)||
            //    string.IsNullOrEmpty(model.email_residencia)||
            //    string.IsNullOrEmpty(model.nombre_centro_trabajo_estudio)||
            //    string.IsNullOrEmpty(model.profesion)||
            //    string.IsNullOrEmpty(model.ocupacion)||
            //    string.IsNullOrEmpty(model.direccion_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.codigo_postal_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.provincia_estado_region_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.pais_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.telefono_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.fax_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.email_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.nivel_de_escolaridad)||
            //    string.IsNullOrEmpty(model.ocupacion_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.profecion_oficio_centro_estudio_trabajo)||
            //    string.IsNullOrEmpty(model.nombre_referencia_cuba)||
            //    string.IsNullOrEmpty(model.direccion_referencia_cuba)||
            //    string.IsNullOrEmpty(model.direccion1_referencia)||
            //    string.IsNullOrEmpty(model.fecha_direccion1_referencia_desde)||
            //    string.IsNullOrEmpty(model.fecha_direccion1_referencia_fecha_hasta)||
            //    string.IsNullOrEmpty(model.direccion2_referencia)||
            //    string.IsNullOrEmpty(model.fecha_direccion2_referencia_desde)||
            //    string.IsNullOrEmpty(model.fecha_direccion2_referencia_fecha_hasta)||
            //    string.IsNullOrEmpty(model.apellido_soltera_referencia)||
            //    string.IsNullOrEmpty(model.otros_nombres_referencia)||
            //    string.IsNullOrEmpty(model.numero_residencia_referencia)||
            //    string.IsNullOrEmpty(model.pasaporte_extranjero_referencia)||
            //    string.IsNullOrEmpty(model.numero_pasaporte_vencido)||
            //    string.IsNullOrEmpty(model.fecha_expedicion_pasaporte_vencido)||
            //    string.IsNullOrEmpty(model.lugar_pasaporte_vencido)||
            //    string.IsNullOrEmpty(model.tomo_certificado_nacimiento)||
            //    string.IsNullOrEmpty(model.folio_certificado_nacimiento)||
            //    string.IsNullOrEmpty(model.registro_civil_certificado_nacimiento)||
            //    string.IsNullOrEmpty(model.numero_inscripcion_consular)||
            //    string.IsNullOrEmpty(model.fecha_inscripcion_consular)||
            //    string.IsNullOrEmpty(model.arancel_inscripcion_consular)||
            //    string.IsNullOrEmpty(model.valoracion_consular))
            //{
            //    return false; // Algún campo es nulo o vacío
            //}

            // Si todas las validaciones pasan
            return true; // La entidad Anexo2_e es válida
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
