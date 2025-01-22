using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo17_m
    {
        private SQLiteConnection connection;

        public Anexo17_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo17_e anexo17_e)
        {
            string[] columns = new string[] { "nombre_apellidos", "ciudadano", "lugar_nacimiento", "fecha_nacimiento", "pasaporte", "padre", "ciudadania_padre", "madre", "ciudadania_madre", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario", "telefono", "email" };
            object[] values = new object[] { anexo17_e.nombre_apellidos, anexo17_e.ciudadano, anexo17_e.lugar_nacimiento, anexo17_e.fecha_nacimiento, anexo17_e.pasaporte, anexo17_e.padre, anexo17_e.ciudadania_padre, anexo17_e.madre, anexo17_e.ciudadania_madre, anexo17_e.recidir_cuba, anexo17_e.recidir_en_exterior, anexo17_e.razones_personales, anexo17_e.nombre_funcionario, anexo17_e.telefono, anexo17_e.email };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo17 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo17_e anexo17_e)
        {
            string[] columns = new string[] { "nombre_apellidos", "ciudadano", "lugar_nacimiento", "fecha_nacimiento", "pasaporte", "padre", "ciudadania_padre", "madre", "ciudadania_madre", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario", "telefono", "email" };
            object[] values = new object[] { anexo17_e.nombre_apellidos, anexo17_e.ciudadano, anexo17_e.lugar_nacimiento, anexo17_e.fecha_nacimiento, anexo17_e.pasaporte, anexo17_e.padre, anexo17_e.ciudadania_padre, anexo17_e.madre, anexo17_e.ciudadania_madre, anexo17_e.recidir_cuba, anexo17_e.recidir_en_exterior, anexo17_e.razones_personales, anexo17_e.nombre_funcionario, anexo17_e.telefono, anexo17_e.email };

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

            sqlite_cmd.CommandText = $"UPDATE anexo17 SET {data} WHERE id = {anexo17_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo17 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo17_e> list()
        {
            List<Anexo17_e> list = new List<Anexo17_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo17";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo17_e anexo17_e = new Anexo17_e();
                anexo17_e.id = sqlite_datareader.GetInt32(0);
                anexo17_e.nombre_apellidos = sqlite_datareader.GetString(1);
                anexo17_e.ciudadano = sqlite_datareader.GetString(2);
                anexo17_e.lugar_nacimiento = sqlite_datareader.GetString(3);
                anexo17_e.fecha_nacimiento = sqlite_datareader.GetString(4);
                anexo17_e.pasaporte = sqlite_datareader.GetString(5);
                anexo17_e.padre = sqlite_datareader.GetString(6);
                anexo17_e.ciudadania_padre = sqlite_datareader.GetString(7);
                anexo17_e.madre = sqlite_datareader.GetString(8);
                anexo17_e.ciudadania_madre = sqlite_datareader.GetString(9);
                anexo17_e.recidir_cuba = sqlite_datareader.GetString(10);
                anexo17_e.recidir_en_exterior = sqlite_datareader.GetString(11);
                anexo17_e.razones_personales = sqlite_datareader.GetString(12);
                anexo17_e.nombre_funcionario = sqlite_datareader.GetString(13);
                anexo17_e.telefono = sqlite_datareader.GetString(14);
                anexo17_e.email = sqlite_datareader.GetString(15);
                list.Add(anexo17_e);
            }
            
            return list;
        }
    }
}