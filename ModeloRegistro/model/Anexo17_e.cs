using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo17_e
    {
        public int id { get; set; }
        public string nombre_apellidos { get; set; }
        public string ciudadano { get; set; }
        public string lugar_nacimiento { get; set; }
        public string fecha_nacimiento { get; set; }
        public string pasaporte { get; set; }
        public string padre { get; set; }
        public string ciudadania_padre { get; set; }
        public string madre { get; set; }
        public string ciudadania_madre { get; set; }
        public string recidir_cuba { get; set; }
        public string recidir_en_exterior { get; set; }
        public string razones_personales { get; set; }
        public string nombre_funcionario { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

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