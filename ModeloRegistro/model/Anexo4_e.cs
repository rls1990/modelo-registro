using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo4_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string f_name { get; set; }
        public string s_name { get; set; }
        public string f_apellido { get; set; }
        public string s_apellido { get; set; }
        public string lugar_nacimiento { get; set; }
        public string ciudadania { get; set; }
        public string nacionalidad { get; set; }
        public string estado_civil { get; set; }
        public string fecha_nacimiento { get; set; }
        public string sexo { get; set; }
        public string color_piel { get; set; }
        public string profecion_oficio_ocupacion { get; set; }
        public string nombre_padre { get; set; }
        public string nombre_madre { get; set; }
        public string carnet_identidad { get; set; }
        public string pasaporte { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string entre { get; set; }
        public string y { get; set; }
        public string barrio { get; set; }
        public string municipio { get; set; }
        public string provincia { get; set; }
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