using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo31_e
    {
        public int id { get; set; }
        public string fecha_solicitud { get; set; }
        public string nombre_poderante { get; set; }
        public string lugar_nacimiento_municipio_poderante { get; set; }
        public string lugar_nacimiento_provincia_poderante { get; set; }
        public string fecha_nacimineto_poderante { get; set; }
        public string registro_estado_civil_poderante { get; set; }
        public string tomo_poderante { get; set; }
        public string folio_poderante { get; set; }
        public string estado_civil_poderante { get; set; }
        public string ciudadania_poderante { get; set; }
        public string ocupacion_poderante { get; set; }
        public string direccion_particular_poderante { get; set; }
        public string carne_pasaporte_poderante { get; set; }
        public string nombre_apellido_padres_poderante { get; set; }
        public string condicion_migratoria_poderante { get; set; }
        public string correo_poderante { get; set; }
        public string celular_poderante { get; set; }
        public string nombre_apoderado { get; set; }
        public string lugar_nacimiento_municipio_apoderado { get; set; }
        public string lugar_nacimiento_provincia_apoderado { get; set; }
        public string fecha_nacimineto_apoderado { get; set; }
        public string registro_estado_civil_apoderado { get; set; }
        public string tomo_apoderado { get; set; }
        public string folio_apoderado { get; set; }
        public string estado_civil_apoderado { get; set; }
        public string ciudadania_apoderado { get; set; }
        public string ocupacion_apoderado { get; set; }
        public string direccion_particular_apoderado { get; set; }
        public string carne_pasaporte_apoderado { get; set; }
        public string nombre_apellido_padres_apoderado { get; set; }
        public string condicion_migratoria_apoderado { get; set; }
        public string clausula { get; set; }

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