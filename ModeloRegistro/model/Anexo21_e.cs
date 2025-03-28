using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo21_e
    {
        public int id { get; set; }
        public string fecha_solicitud { get; set; }
        public string nombre_padre { get; set; }
        public string ciudadania_padre { get; set; }
        public string estado_civil_padre { get; set; }
        public string minicipio_nacimineto_padre { get; set; }
        public string provincia_nacimineto_padre { get; set; }
        public string fecha_nacimiento_padre { get; set; }
        public string profecion_padre { get; set; }
        public string carnet_pasaporte_padre { get; set; }
        public string categoria_migratoria_padre { get; set; }
        public string direccion_eu_padre { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string nombre_menor { get; set; }
        public string municipio_nacimiento_menor { get; set; }
        public string provincia_nacimiento_menor { get; set; }
        public string fecha_nacimiento_menor { get; set; }
        public string registro_estado_nacimiento_menor { get; set; }
        public string tomo { get; set; }
        public string folio { get; set; }
        public string tarjeta_menor { get; set; }
        public string direccion_menor_cuba { get; set; }

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