using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo2_e
    {
        public int id { get; set; }
        public string pasaporte_1ra_vez { get; set; }
        public string prorrogas { get; set; }
        public string he_1 { get; set; }
        public string he_4 { get; set; }
        public string dvt { get; set; }
        public string renovacion_pasaporte { get; set; }
        public string habilitacion_de_entrada { get; set; }
        public string he_3 { get; set; }
        public string he_11 { get; set; }
        public string ccv { get; set; }
        public string fecha_de_solicitud { get; set; }
        public string no_pasaporte { get; set; }
        public string carnet { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string padre { get; set; }
        public string madre { get; set; }
        public string caracteristicas_especiales { get; set; }
        public string estatura { get; set; }
        public string estado_civil { get; set; }
        public string sexo { get; set; }
        public string color_ojos { get; set; }
        public string color_piel { get; set; }
        public string color_cabello { get; set; }
        public string permiso_emigracion { get; set; }
        public string residente_en_el_exterior { get; set; }
        public string asunto_oficial { get; set; }
        public string pve { get; set; }
        public string psi { get; set; }
        public string residencia_exterior { get; set; }
        public string pre { get; set; }
        public string pvt { get; set; }
        public string pre_e { get; set; }
        public string salida_ilegal { get; set; }
        public string fecha_de_salida { get; set; }
        public string pais { get; set; }
        public string provincia { get; set; }
        public string municipio_ciudad { get; set; }
        public string fecha_de_nacimiento { get; set; }
        public string direccion { get; set; }
        public string codigo_postal { get; set; }
        public string provincia_estado_region { get; set; }
        public string pais_residencia_actual { get; set; }
        public string telefono_residencia { get; set; }
        public string fax_residencia { get; set; }
        public string email_residencia { get; set; }
        public string nombre_centro_trabajo_estudio { get; set; }
        public string profesion { get; set; }
        public string ocupacion { get; set; }
        public string direccion_centro_estudio_trabajo { get; set; }
        public string codigo_postal_centro_estudio_trabajo { get; set; }
        public string provincia_estado_region_centro_estudio_trabajo { get; set; }
        public string pais_centro_estudio_trabajo { get; set; }
        public string telefono_centro_estudio_trabajo { get; set; }
        public string fax_centro_estudio_trabajo { get; set; }
        public string email_centro_estudio_trabajo { get; set; }
        public string nivel_de_escolaridad { get; set; }
        public string ocupacion_centro_estudio_trabajo { get; set; }
        public string profecion_oficio_centro_estudio_trabajo { get; set; }
        public string nombre_referencia_cuba { get; set; }
        public string direccion_referencia_cuba { get; set; }
        public string direccion1_referencia { get; set; }
        public string fecha_direccion1_referencia_desde { get; set; }
        public string fecha_direccion1_referencia_fecha_hasta { get; set; }
        public string direccion2_referencia { get; set; }
        public string fecha_direccion2_referencia_desde { get; set; }
        public string fecha_direccion2_referencia_fecha_hasta { get; set; }
        public string apellido_soltera_referencia { get; set; }
        public string otros_nombres_referencia { get; set; }
        public string numero_residencia_referencia { get; set; }
        public string pasaporte_extranjero_referencia { get; set; }
        public string numero_pasaporte_vencido { get; set; }
        public string fecha_expedicion_pasaporte_vencido { get; set; }
        public string lugar_pasaporte_vencido { get; set; }
        public string tomo_certificado_nacimiento { get; set; }
        public string folio_certificado_nacimiento { get; set; }
        public string registro_civil_certificado_nacimiento { get; set; }
        public string numero_inscripcion_consular { get; set; }
        public string fecha_inscripcion_consular { get; set; }
        public string arancel_inscripcion_consular { get; set; }
        public string valoracion_consular { get; set; }

        public bool ContieneTexto( string texto )
        {
            // Recorremos todas las propiedades del objeto
            foreach(PropertyInfo propiedad in this.GetType().GetProperties())
            {
                // Obtenemos el valor de la propiedad
                var valor = propiedad.GetValue(this)?.ToString();
                // Comparamos el valor con el texto
                if(valor!=null&&valor.Equals(texto,StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}