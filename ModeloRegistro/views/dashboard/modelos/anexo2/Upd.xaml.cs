using ModeloRegistro.services;
using System.Windows;
using System.Windows.Controls;

namespace ModeloRegistro.views.dashboard.modelos.anexo2
{
    /// <summary>
    /// Interaction logic for Upd.xaml
    /// </summary>
    public partial class Upd:Page
    {
        private model.Anexo2_m manager = new model.Anexo2_m(Global.sqlite);
        private model.Anexo2_e entity;
        public Upd()
        {
            InitializeComponent();
            InitCampos();
        }

        private void InitCampos()
        {
            // Obtener la entidad seleccionada
            entity=(model.Anexo2_e)Global.entity;

            // Asignar cada propiedad de la entidad a su respectivo campo visual
            pasaporte_1ra_vez.IsChecked=entity.pasaporte_1ra_vez=="True";
            prorrogas.IsChecked=entity.prorrogas=="True";
            he_1.IsChecked=entity.he_1=="True";
            he_4.IsChecked=entity.he_4=="True";
            dvt.IsChecked=entity.dvt=="True";
            renovacion_pasaporte.IsChecked=entity.renovacion_pasaporte=="True";
            habilitacion_de_entrada.IsChecked=entity.habilitacion_de_entrada=="True";
            he_3.IsChecked=entity.he_3=="True";
            he_11.IsChecked=entity.he_11=="True";
            ccv.IsChecked=entity.ccv=="True";

            fecha_de_solicitud.Text=entity.fecha_de_solicitud;
            no_pasaporte.Text=entity.no_pasaporte;
            carnet.Text=entity.carnet;

            primer_apellido.Text=entity.primer_apellido;
            segundo_apellido.Text=entity.segundo_apellido;
            primer_nombre.Text=entity.primer_nombre;
            segundo_nombre.Text=entity.segundo_nombre;

            padre.Text=entity.padre;
            madre.Text=entity.madre;

            caracteristicas_especiales.Text=entity.caracteristicas_especiales;
            estatura.Text=entity.estatura;

            estado_civil.Text=entity.estado_civil;
            sexo.Text=entity.sexo;

            color_ojos.Text=entity.color_ojos;
            color_piel.Text=entity.color_piel;
            color_cabello.Text=entity.color_cabello;

            permiso_emigracion.IsChecked=entity.permiso_emigracion=="True";
            residente_en_el_exterior.IsChecked=entity.residente_en_el_exterior=="True";

            asunto_oficial.IsChecked=entity.asunto_oficial=="True";

            pve.IsChecked=entity.pve=="True"; // Asegúrate de que este campo sea correcto
            psi.IsChecked=entity.psi=="True"; // Igual que el anterior
            residencia_exterior.IsChecked=entity.residencia_exterior=="True";

            pre.IsChecked=entity.pre=="True"; // Asegúrate de que este campo sea correcto
            pvt.IsChecked=entity.pvt=="True"; // Igual que el anterior
            pre_e.IsChecked=entity.pre_e=="True"; // Asegúrate de que este campo sea correcto

            salida_ilegal.IsChecked=entity.salida_ilegal=="True";

            fecha_de_salida.Text=entity.fecha_de_salida;

            pais.Text=entity.pais;

            provincia.Text=entity.provincia;

            municipio_ciudad.Text=entity.municipio_ciudad;

            fecha_de_nacimiento.Text=entity.fecha_de_nacimiento;

            direccion.Text=entity.direccion;

            codigo_postal.Text=entity.codigo_postal;

            provincia_estado_region.Text=entity.provincia_estado_region;

            pais_residencia_actual.Text=entity.pais_residencia_actual;

            telefono_residencia.Text=entity.telefono_residencia;

            fax_residencia.Text=entity.fax_residencia;

            email_residencia.Text=entity.email_residencia;

            nombre_centro_trabajo_estudio.Text=entity.nombre_centro_trabajo_estudio;

            profesion.Text=entity.profesion; // Asegúrate de que este campo sea correcto
            ocupacion.Text=entity.ocupacion;

            direccion_centro_estudio_trabajo.Text=entity.direccion_centro_estudio_trabajo;

            codigo_postal_centro_estudio_trabajo.Text=entity.codigo_postal_centro_estudio_trabajo;

            provincia_estado_region_centro_estudio_trabajo.Text=
                entity.provincia_estado_region_centro_estudio_trabajo;

            pais_centro_estudio_trabajo.Text=entity.pais_centro_estudio_trabajo;

            telefono_centro_estudio_trabajo.Text=
                entity.telefono_centro_estudio_trabajo;

            fax_centro_estudio_trabajo.Text=entity.fax_centro_estudio_trabajo;

            email_centro_estudio_trabajo.Text=entity.email_centro_estudio_trabajo;

            nivel_de_escolaridad.Text=entity.nivel_de_escolaridad;

            ocupacion_centro_estudio_trabajo.Text=entity.ocupacion_centro_estudio_trabajo;

            profecion_oficio_centro_estudio_trabajo.Text=entity.profecion_oficio_centro_estudio_trabajo;

            nombre_referencia_cuba.Text=entity.nombre_referencia_cuba;

            direccion_referencia_cuba.Text=entity.direccion_referencia_cuba;

            direccion1_referencia.Text=entity.direccion1_referencia;

            fecha_direccion1_referencia_desde.Text=entity.fecha_direccion1_referencia_desde;

            fecha_direccion1_referencia_fecha_hasta.Text=entity.fecha_direccion1_referencia_fecha_hasta;

            direccion2_referencia.Text=entity.direccion2_referencia;

            fecha_direccion2_referencia_desde.Text=entity.fecha_direccion2_referencia_desde;

            fecha_direccion2_referencia_fecha_hasta.Text=entity.fecha_direccion2_referencia_fecha_hasta;

            apellido_soltera_referencia.Text=entity.apellido_soltera_referencia;

            otros_nombres_referencia.Text=entity.otros_nombres_referencia;

            numero_residencia_referencia.Text=entity.numero_residencia_referencia;

            pasaporte_extranjero_referencia.Text=entity.pasaporte_extranjero_referencia;

            numero_pasaporte_vencido.Text=entity.numero_pasaporte_vencido;

            fecha_expedicion_pasaporte_vencido.Text=entity.fecha_expedicion_pasaporte_vencido;

            lugar_pasaporte_vencido.Text=entity.lugar_pasaporte_vencido;

            tomo_certificado_nacimiento.Text=entity.tomo_certificado_nacimiento;

            folio_certificado_nacimiento.Text=entity.folio_certificado_nacimiento;

            registro_civil_certificado_nacimiento.Text=entity.registro_civil_certificado_nacimiento;

            numero_inscripcion_consular.Text=entity.numero_inscripcion_consular;

            fecha_inscripcion_consular.Text=entity.fecha_inscripcion_consular;

            arancel_inscripcion_consular.Text=entity.arancel_inscripcion_consular;

            valoracion_consular.Text=entity.valoracion_consular;
        }


        private void Button_Click( object sender,RoutedEventArgs e )
        {
            PageService.toPage(new Anexo2());
        }

        private void Button_Click_1( object sender,RoutedEventArgs e )
        {
            var anexo = new model.Anexo2_e()
            {
                id=entity.id,
                pasaporte_1ra_vez=pasaporte_1ra_vez.IsChecked.ToString(),
                prorrogas=prorrogas.IsChecked.ToString(),
                he_1=he_1.IsChecked.ToString(),
                he_4=he_4.IsChecked.ToString(),
                dvt=dvt.IsChecked.ToString(),
                renovacion_pasaporte=renovacion_pasaporte.IsChecked.ToString(),
                habilitacion_de_entrada=habilitacion_de_entrada.IsChecked.ToString(),
                he_3=he_3.IsChecked.ToString(),
                he_11=he_11.IsChecked.ToString(),
                ccv=ccv.IsChecked.ToString(),
                fecha_de_solicitud=fecha_de_solicitud.SelectedDate?.ToString("yyyy-MM-dd"),
                no_pasaporte=no_pasaporte.Text,
                carnet=carnet.Text,
                primer_apellido=primer_apellido.Text,
                segundo_apellido=segundo_apellido.Text,
                primer_nombre=primer_nombre.Text,
                segundo_nombre=segundo_nombre.Text,
                padre=padre.Text,
                madre=madre.Text,
                caracteristicas_especiales=caracteristicas_especiales.Text,
                estatura=estatura.Text,
                estado_civil=estado_civil.Text,
                sexo=sexo.Text,
                color_ojos=color_ojos.Text,
                color_piel=color_piel.Text,
                color_cabello=color_cabello.Text,
                permiso_emigracion=permiso_emigracion.IsChecked.ToString(),
                residente_en_el_exterior=residente_en_el_exterior.IsChecked.ToString(),
                asunto_oficial=asunto_oficial.IsChecked.ToString(),
                pve=pve.IsChecked.ToString(),
                psi=psi.IsChecked.ToString(),
                residencia_exterior=residencia_exterior.IsChecked.ToString(),
                pre=pre.IsChecked.ToString(),
                pvt=pvt.IsChecked.ToString(),
                pre_e=pre_e.IsChecked.ToString(),
                salida_ilegal=salida_ilegal.IsChecked.ToString(),
                fecha_de_salida=fecha_de_salida.SelectedDate?.ToString("yyyy-MM-dd"),
                pais=pais.Text,
                provincia=provincia.Text,
                municipio_ciudad=municipio_ciudad.Text,
                fecha_de_nacimiento=fecha_de_nacimiento.SelectedDate?.ToString("yyyy-MM-dd"),
                direccion=direccion.Text,
                codigo_postal=codigo_postal.Text,
                provincia_estado_region=provincia_estado_region.Text,
                pais_residencia_actual=pais_residencia_actual.Text,
                telefono_residencia=telefono_residencia.Text,
                fax_residencia=fax_residencia.Text,
                email_residencia=email_residencia.Text,


                nombre_centro_trabajo_estudio=nombre_centro_trabajo_estudio.Text,

                profesion=profesion.Text,

                ocupacion=ocupacion.Text,

                direccion_centro_estudio_trabajo=direccion_centro_estudio_trabajo.Text,

                codigo_postal_centro_estudio_trabajo=codigo_postal_centro_estudio_trabajo.Text,

                provincia_estado_region_centro_estudio_trabajo=provincia_estado_region_centro_estudio_trabajo.Text,

                pais_centro_estudio_trabajo=pais_centro_estudio_trabajo.Text,

                telefono_centro_estudio_trabajo=telefono_centro_estudio_trabajo.Text,

                fax_centro_estudio_trabajo=fax_centro_estudio_trabajo.Text,

                email_centro_estudio_trabajo=email_centro_estudio_trabajo.Text,

                nivel_de_escolaridad=nivel_de_escolaridad.Text,

                ocupacion_centro_estudio_trabajo=ocupacion_centro_estudio_trabajo.Text,

                profecion_oficio_centro_estudio_trabajo=profecion_oficio_centro_estudio_trabajo.Text,

                nombre_referencia_cuba=nombre_referencia_cuba.Text,

                direccion_referencia_cuba=direccion_referencia_cuba.Text,

                direccion1_referencia=direccion1_referencia.Text,

                fecha_direccion1_referencia_desde=fecha_direccion1_referencia_desde.SelectedDate?.ToString("yyyy-MM-dd"),

                fecha_direccion1_referencia_fecha_hasta=fecha_direccion1_referencia_fecha_hasta.SelectedDate?.ToString("yyyy-MM-dd"),

                direccion2_referencia=direccion2_referencia.Text,

                fecha_direccion2_referencia_desde=fecha_direccion2_referencia_desde.SelectedDate?.ToString("yyyy-MM-dd"),

                fecha_direccion2_referencia_fecha_hasta=fecha_direccion2_referencia_fecha_hasta.SelectedDate?.ToString("yyyy-MM-dd"),

                apellido_soltera_referencia=apellido_soltera_referencia.Text,

                otros_nombres_referencia=otros_nombres_referencia.Text,

                numero_residencia_referencia=numero_residencia_referencia.Text,

                pasaporte_extranjero_referencia=pasaporte_extranjero_referencia.Text,

                numero_pasaporte_vencido=numero_pasaporte_vencido.Text,

                fecha_expedicion_pasaporte_vencido=fecha_expedicion_pasaporte_vencido.SelectedDate?.ToString("yyyy-MM-dd"),

                lugar_pasaporte_vencido=lugar_pasaporte_vencido.Text,

                tomo_certificado_nacimiento=tomo_certificado_nacimiento.Text,

                folio_certificado_nacimiento=folio_certificado_nacimiento.Text,

                registro_civil_certificado_nacimiento=registro_civil_certificado_nacimiento.Text,

                numero_inscripcion_consular=numero_inscripcion_consular.Text,

                fecha_inscripcion_consular=fecha_inscripcion_consular.SelectedDate?.ToString("yyyy-MM-dd"),

                arancel_inscripcion_consular=arancel_inscripcion_consular.Text,

                valoracion_consular=valoracion_consular.Text
            };

            if(ValidarAnexo(anexo))
            {
                manager.update(anexo);
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
