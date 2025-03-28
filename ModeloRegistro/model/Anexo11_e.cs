using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo11_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string solicito_certificado { get; set; }
        public string de_mi { get; set; }
        public string nombre_apellidos { get; set; }
        public string fecha_nacimiento { get; set; }
        public string lugar_nacimiento { get; set; }
        public string nombre_padres { get; set; }
        public string lugar_vivio_cuba { get; set; }
        public string fecha_fallecimiento { get; set; }
        public string otros_datos_interes { get; set; }
        public string nombre_apellidos_solicitante { get; set; }
        public string doc_identidad { get; set; }
        public string pasaporte { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
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