using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo12_e
    {
        public int id { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string nombre_apellidos { get; set; }
        public string ciudadano { get; set; }
        public string carnet_identidad { get; set; }
        public string fecha_nacimiento { get; set; }
        public string lugar_nacimineto { get; set; }
        public string registro_civil { get; set; }
        public string vecino_de { get; set; }
        public string nombre_apellido_apoderado { get; set; }
        public string si { get; set; }
        public string no { get; set; }
        public string numero { get; set; }
        public string fecha_poder_especial { get; set; }
        public string nombre_apellido_notario { get; set; }
        public string competencia { get; set; }
        public string sede { get; set; }
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