using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo19_m
    {
        private SQLiteConnection connection;

        public Anexo19_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo19_e anexo19_e)
        {
            string[] columns = new string[] { "nombre_apellidos", "ciudadano", "lugar_nacimiento", "fecha_nacimiento", "pasaporte", "nombre_menor", "ciudadania_menor", "lugar_nacimineto_menor", "fecha_nacimiento_menor", "pasaporte_menor", "ultima_direccion_pedres", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario", "telefono", "email" };
            object[] values = new object[] { anexo19_e.nombre_apellidos, anexo19_e.ciudadano, anexo19_e.lugar_nacimiento, anexo19_e.fecha_nacimiento, anexo19_e.pasaporte, anexo19_e.nombre_menor, anexo19_e.ciudadania_menor, anexo19_e.lugar_nacimineto_menor, anexo19_e.fecha_nacimiento_menor, anexo19_e.pasaporte_menor, anexo19_e.ultima_direccion_pedres, anexo19_e.recidir_cuba, anexo19_e.recidir_en_exterior, anexo19_e.razones_personales, anexo19_e.nombre_funcionario, anexo19_e.telefono, anexo19_e.email };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo19 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo19_e anexo19_e)
        {
            string[] columns = new string[] { "nombre_apellidos", "ciudadano", "lugar_nacimiento", "fecha_nacimiento", "pasaporte", "nombre_menor", "ciudadania_menor", "lugar_nacimineto_menor", "fecha_nacimiento_menor", "pasaporte_menor", "ultima_direccion_pedres", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario", "telefono", "email" };
            object[] values = new object[] { anexo19_e.nombre_apellidos, anexo19_e.ciudadano, anexo19_e.lugar_nacimiento, anexo19_e.fecha_nacimiento, anexo19_e.pasaporte, anexo19_e.nombre_menor, anexo19_e.ciudadania_menor, anexo19_e.lugar_nacimineto_menor, anexo19_e.fecha_nacimiento_menor, anexo19_e.pasaporte_menor, anexo19_e.ultima_direccion_pedres, anexo19_e.recidir_cuba, anexo19_e.recidir_en_exterior, anexo19_e.razones_personales, anexo19_e.nombre_funcionario, anexo19_e.telefono, anexo19_e.email };

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

            sqlite_cmd.CommandText = $"UPDATE anexo19 SET {data} WHERE id = {anexo19_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo19 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo19_e> list()
        {
            List<Anexo19_e> list = new List<Anexo19_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo19";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo19_e anexo19_e = new Anexo19_e();
                anexo19_e.id = sqlite_datareader.GetInt32(0);
                anexo19_e.nombre_apellidos = sqlite_datareader.GetString(1);
                anexo19_e.ciudadano = sqlite_datareader.GetString(2);
                anexo19_e.lugar_nacimiento = sqlite_datareader.GetString(3);
                anexo19_e.fecha_nacimiento = sqlite_datareader.GetString(4);
                anexo19_e.pasaporte = sqlite_datareader.GetString(5);
                anexo19_e.nombre_menor = sqlite_datareader.GetString(6);
                anexo19_e.ciudadania_menor = sqlite_datareader.GetString(7);
                anexo19_e.lugar_nacimineto_menor = sqlite_datareader.GetString(8);
                anexo19_e.fecha_nacimiento_menor = sqlite_datareader.GetString(9);
                anexo19_e.pasaporte_menor = sqlite_datareader.GetString(10);
                anexo19_e.ultima_direccion_pedres = sqlite_datareader.GetString(11);
                anexo19_e.recidir_cuba = sqlite_datareader.GetString(12);
                anexo19_e.recidir_en_exterior = sqlite_datareader.GetString(13);
                anexo19_e.razones_personales = sqlite_datareader.GetString(14);
                anexo19_e.nombre_funcionario = sqlite_datareader.GetString(15);
                anexo19_e.telefono = sqlite_datareader.GetString(16);
                anexo19_e.email = sqlite_datareader.GetString(17);
                list.Add(anexo19_e);
            }
            
            return list;
        }
    }
}