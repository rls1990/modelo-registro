using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo6_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nombre_apellido_hombre { get; set; }
        public string nombre_apellido_mujer { get; set; }
        public string tribunal_dicto_sentencia { get; set; }
        public string nombre_secretario_actuante { get; set; }
        public string fecha_dicto_sentencia { get; set; }
        public string fecha_firmeza_sentencia { get; set; }
        public string no_sentencia { get; set; }
        public string no_radicacion { get; set; }
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