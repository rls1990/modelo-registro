using System;
using System.Reflection;

namespace ModeloRegistro.model
{
    public class Anexo20_e
    {
        public int id { get; set; }
        public string nombre_apellidos { get; set; }
        public string ciudadano { get; set; }
        public string nombre_apellidos_menor_edad { get; set; }
        public string ciudadania_menor_edad { get; set; }
        public string lugar_nacimiento_menor { get; set; }
        public string fecha_nacimiento_menor { get; set; }
        public string pasaporte_menor { get; set; }
        public string padre { get; set; }
        public string ciudadania_padre { get; set; }
        public string madre { get; set; }
        public string ciudadania_madre { get; set; }
        public string ultima_direccion_padres { get; set; }
        public string nombre_persona_representante_legal { get; set; }
        public string recidir_cuba { get; set; }
        public string recidir_en_exterior { get; set; }
        public string razones_personales { get; set; }
        public string nombre_funcionario_consular { get; set; }
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