using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo20_m
    {
        private SQLiteConnection connection;

        public Anexo20_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo20_e anexo20_e)
        {
            string[] columns = new string[] { "ciudadano", "nombre_apellidos_menor_edad", "ciudadania_menor_edad", "lugar_nacimiento_menor", "fecha_nacimiento_menor", "pasaporte_menor", "padre", "ciudadania_padre", "madre", "ciudadania_madre", "ultima_direccion_padres", "nombre_persona_representante_legal", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario_consular", "telefono", "email", "id" };
            object[] values = new object[] { anexo20_e.ciudadano, anexo20_e.nombre_apellidos_menor_edad, anexo20_e.ciudadania_menor_edad, anexo20_e.lugar_nacimiento_menor, anexo20_e.fecha_nacimiento_menor, anexo20_e.pasaporte_menor, anexo20_e.padre, anexo20_e.ciudadania_padre, anexo20_e.madre, anexo20_e.ciudadania_madre, anexo20_e.ultima_direccion_padres, anexo20_e.nombre_persona_representante_legal, anexo20_e.recidir_cuba, anexo20_e.recidir_en_exterior, anexo20_e.razones_personales, anexo20_e.nombre_funcionario_consular, anexo20_e.telefono, anexo20_e.email, anexo20_e.id };

            SQLiteCommand sqlite_cmd = connection.CreateCommand();

            string exp_columns = "(";
            string exp_values = "(";
            for (int i = 0; i < columns.Length; i++)
            {
                if (i + 1 < columns.Length)
                {
                    exp_columns += columns[i] + ",";
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        exp_values += $"'{values[i]}', ";
                    }
                    else
                    {
                        exp_values += $"{ values[i]}, ";
                    }
                }
                else
                {
                    exp_columns += columns[i] + ")";
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        exp_values += $"'{values[i]}')";
                    }
                    else
                    {
                        exp_values += $"{values[i]})";
                    }
                }
            }

            sqlite_cmd.CommandText = $"INSERT INTO anexo20 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo20_e anexo20_e)
        {
            string[] columns = new string[] { "ciudadano", "nombre_apellidos_menor_edad", "ciudadania_menor_edad", "lugar_nacimiento_menor", "fecha_nacimiento_menor", "pasaporte_menor", "padre", "ciudadania_padre", "madre", "ciudadania_madre", "ultima_direccion_padres", "nombre_persona_representante_legal", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario_consular", "telefono", "email", "id" };
            object[] values = new object[] { anexo20_e.ciudadano, anexo20_e.nombre_apellidos_menor_edad, anexo20_e.ciudadania_menor_edad, anexo20_e.lugar_nacimiento_menor, anexo20_e.fecha_nacimiento_menor, anexo20_e.pasaporte_menor, anexo20_e.padre, anexo20_e.ciudadania_padre, anexo20_e.madre, anexo20_e.ciudadania_madre, anexo20_e.ultima_direccion_padres, anexo20_e.nombre_persona_representante_legal, anexo20_e.recidir_cuba, anexo20_e.recidir_en_exterior, anexo20_e.razones_personales, anexo20_e.nombre_funcionario_consular, anexo20_e.telefono, anexo20_e.email, anexo20_e.id };

            SQLiteCommand sqlite_cmd = connection.CreateCommand();

            string data = "";

            for (int i = 0; i < columns.Length; i++)
            {
                if (i + 1 < columns.Length)
                {
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        data += $"{columns[i]} = '{values[i]}', ";
                    }
                    else
                    {
                        data += $"{columns[i]} = {values[i]}, ";
                    }
                    }
                else
                {
                    Type ty = values[i].GetType();
                    string cad = ty.Name;

                    if (cad == "String")
                    {
                        data += $"{ columns[i]} = '{values[i]}'";
                    }
                    else
                    {
                        data += $"{columns[i]} = {values[i]}";
                    }
                }
            }

            sqlite_cmd.CommandText = $"UPDATE anexo20 SET {data} WHERE id = {anexo20_e.id}";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void delete(int id)
        {
            SQLiteCommand sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = $"DELETE FROM anexo20 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo20_e> list()
        {
            List<Anexo20_e> list = new List<Anexo20_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo20";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo20_e anexo20_e = new Anexo20_e();
                anexo20_e.nombre_apellidos = sqlite_datareader.GetString(0);
                anexo20_e.ciudadano = sqlite_datareader.GetString(1);
                anexo20_e.nombre_apellidos_menor_edad = sqlite_datareader.GetString(2);
                anexo20_e.ciudadania_menor_edad = sqlite_datareader.GetString(3);
                anexo20_e.lugar_nacimiento_menor = sqlite_datareader.GetString(4);
                anexo20_e.fecha_nacimiento_menor = sqlite_datareader.GetString(5);
                anexo20_e.pasaporte_menor = sqlite_datareader.GetString(6);
                anexo20_e.padre = sqlite_datareader.GetString(7);
                anexo20_e.ciudadania_padre = sqlite_datareader.GetString(8);
                anexo20_e.madre = sqlite_datareader.GetString(9);
                anexo20_e.ciudadania_madre = sqlite_datareader.GetString(10);
                anexo20_e.ultima_direccion_padres = sqlite_datareader.GetString(11);
                anexo20_e.nombre_persona_representante_legal = sqlite_datareader.GetString(12);
                anexo20_e.recidir_cuba = sqlite_datareader.GetString(13);
                anexo20_e.recidir_en_exterior = sqlite_datareader.GetString(14);
                anexo20_e.razones_personales = sqlite_datareader.GetString(15);
                anexo20_e.nombre_funcionario_consular = sqlite_datareader.GetString(16);
                anexo20_e.telefono = sqlite_datareader.GetString(17);
                anexo20_e.email = sqlite_datareader.GetString(18);
                anexo20_e.id = sqlite_datareader.GetInt32(19);
                list.Add(anexo20_e);
            }
            
            return list;
        }
    }
}