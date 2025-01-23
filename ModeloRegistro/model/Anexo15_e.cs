using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo15_e
    {
        public int id { get; set; }
        public string nombre_fallecido { get; set; }
        public string m { get; set; }
        public string f { get; set; }
        public string primer_apellido_fallecido { get; set; }
        public string segundo_apellido_fallecido { get; set; }
        public string hora_fallecido { get; set; }
        public string fecha_fallecimineto { get; set; }
        public string lugar_nacimineto_fallecido { get; set; }
        public string municipio_provincia_pais_fallecido { get; set; }
        public string fecha_nacimiento { get; set; }
        public string pasaporte_fallecido { get; set; }
        public string edad_fallecido { get; set; }
        public string registro_civil_fallecido { get; set; }
        public string tomo_fallecido { get; set; }
        public string folio_fallecido { get; set; }
        public string estado_civil_fallecido { get; set; }
        public string ocupacion_fallecido { get; set; }
        public string padre_fallecido { get; set; }
        public string madre_fallecido { get; set; }
        public string domicilio_fallecido { get; set; }
        public string fecha_defuncion { get; set; }
        public string hora_defuncion { get; set; }
        public string lugar_fallecimiento { get; set; }
        public string causa_muerte_fallecimiento { get; set; }
        public string enfermedad_causa_fallecimiento { get; set; }
        public string nombre_medico_certifica_fallecimiento { get; set; }
        public string lugar_cepultura { get; set; }
        public string registro_civil { get; set; }
        public string tomo { get; set; }
        public string folio { get; set; }
        public string fecha_certificado { get; set; }
        public string nombre_apellido_solicita { get; set; }
        public string nro_pasaporte_carnet { get; set; }
        public string parentesco_fallecido { get; set; }
        public string direccion_solicita { get; set; }
        public string nombre_apellido_funcionario_consular { get; set; }

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