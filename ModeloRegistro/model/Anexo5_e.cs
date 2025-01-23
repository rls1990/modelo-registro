using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo5_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nombre_apellido_hombre { get; set; }
        public string nombre_apellido_mujer { get; set; }
        public string fecha_matrimonio { get; set; }
        public string ciudad_matrimonio { get; set; }
        public string provincia_matrimonio { get; set; }
        public string pais_matrimonio { get; set; }
        public string registro { get; set; }
        public string municipio_registro { get; set; }
        public string provincia_registro { get; set; }
        public string tomo { get; set; }
        public string folio { get; set; }
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