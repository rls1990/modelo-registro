using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo9_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string encargado_registro_civil { get; set; }
        public string municipio_encargado { get; set; }
        public string provincia_encargado { get; set; }
        public string nombre { get; set; }
        public string fecha_solicitud { get; set; }
        public string tomo_certificado { get; set; }
        public string folio_certificado { get; set; }
        public string fecha_nacimiento { get; set; }
        public string municipio_persona { get; set; }
        public string provincia_persona { get; set; }
        public string padre { get; set; }
        public string madre { get; set; }
        public string legalizacion_minrex { get; set; }
        public string legalizacion_embajada { get; set; }
        public string fecha_de_solicitud { get; set; }

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