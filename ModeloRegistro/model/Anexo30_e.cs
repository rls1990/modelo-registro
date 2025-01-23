using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo30_e
    {
        public int id { get; set; }
        public string fecha_solicitud { get; set; }
        public string nombre { get; set; }
        public string sexo { get; set; }
        public string lugar_nacimineto_municipio { get; set; }
        public string lugar_nacimineto_provincia { get; set; }
        public string fecha_nacimineto { get; set; }
        public string estado_civil { get; set; }
        public string ciudadania { get; set; }
        public string ocupacion { get; set; }
        public string direccion { get; set; }
        public string carnet_pasaporte { get; set; }
        public string condicion_migratoria { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string nombre_apoderado { get; set; }
        public string sexo_apoderado { get; set; }
        public string lugar_nacimineto_municipio_apoderado { get; set; }
        public string lugar_nacimineto_provincia_apoderado { get; set; }
        public string fecha_nacimineto_apoderado { get; set; }
        public string estado_civil_apoderado { get; set; }
        public string ciudadania_apoderado { get; set; }
        public string ocupacion_apoderado { get; set; }
        public string direccion_apoderado { get; set; }
        public string carnet_pasaporte_apoderado { get; set; }
        public string condicion_migratoria_apoderado { get; set; }
        public string direccion_vivienda { get; set; }
        public string clausaula { get; set; }

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