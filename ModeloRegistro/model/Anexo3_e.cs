using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo3_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nombre_apellido { get; set; }
        public string fecha_nacimiento { get; set; }
        public string municipio { get; set; }
        public string provincia { get; set; }
        public string registro { get; set; }
        public string municipio_registro { get; set; }
        public string provincia_registro { get; set; }
        public string tomo { get; set; }
        public string folio { get; set; }
        public string fecha_asiento { get; set; }
        public string nombre_padre { get; set; }
        public string nombre_madre { get; set; }
        public string legalizacion_minred { get; set; }
        public string legalizacion_embajada { get; set; }
        public string fecha_solicitud { get; set; }

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