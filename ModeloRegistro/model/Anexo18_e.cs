using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo18_e
    {
        public int id { get; set; }
        public string nombre_hombre { get; set; }
        public string nombre_mujer { get; set; }
        public string ciudadania_hombre { get; set; }
        public string ciudadania_mujer { get; set; }
        public string lugar_nacimiento_hombre { get; set; }
        public string lugar_nacimiento_mujer { get; set; }
        public string fecha_nacimiento_hombre { get; set; }
        public string fecha_nacimiento_mujer { get; set; }
        public string pasaporte_hombre { get; set; }
        public string pasaporte_mujer { get; set; }
        public string nombre_hijo_menor { get; set; }
        public string ciudadania_hijo_menor { get; set; }
        public string lugar_nacimineto_hijo_menor { get; set; }
        public string fecha_nacimiento_hijo_menor { get; set; }
        public string pasaporte_hijo_menor { get; set; }
        public string padre { get; set; }
        public string ciudadania_padre { get; set; }
        public string madre { get; set; }
        public string ciudadania_madre { get; set; }
        public string ultima_direccion_cuba { get; set; }
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