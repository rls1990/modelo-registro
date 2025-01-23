using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo22_e
    {
        public int id { get; set; }
        public string fecha_solicitud { get; set; }
        public string nombre { get; set; }
        public string ciudadania { get; set; }
        public string estado_civil { get; set; }
        public string fecha_nacimiento { get; set; }
        public string profecion { get; set; }
        public string carnet_pasaporte { get; set; }
        public string categoria_migratoria { get; set; }
        public string direccion_estados_unidos { get; set; }
        public string correo { get; set; }
        public string celular { get; set; }
        public string documento_legalizar { get; set; }

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