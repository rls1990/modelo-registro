using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo18_m
    {
        private SQLiteConnection connection;

        public Anexo18_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo18_e anexo18_e)
        {
            string[] columns = new string[] { "nombre_hombre", "nombre_mujer", "ciudadania_hombre", "ciudadania_mujer", "lugar_nacimiento_hombre", "lugar_nacimiento_mujer", "fecha_nacimiento_hombre", "fecha_nacimiento_mujer", "pasaporte_hombre", "pasaporte_mujer", "nombre_hijo_menor", "ciudadania_hijo_menor", "lugar_nacimineto_hijo_menor", "fecha_nacimiento_hijo_menor", "pasaporte_hijo_menor", "padre", "ciudadania_padre", "madre", "ciudadania_madre", "ultima_direccion_cuba", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario", "telefono", "email" };
            object[] values = new object[] { anexo18_e.nombre_hombre, anexo18_e.nombre_mujer, anexo18_e.ciudadania_hombre, anexo18_e.ciudadania_mujer, anexo18_e.lugar_nacimiento_hombre, anexo18_e.lugar_nacimiento_mujer, anexo18_e.fecha_nacimiento_hombre, anexo18_e.fecha_nacimiento_mujer, anexo18_e.pasaporte_hombre, anexo18_e.pasaporte_mujer, anexo18_e.nombre_hijo_menor, anexo18_e.ciudadania_hijo_menor, anexo18_e.lugar_nacimineto_hijo_menor, anexo18_e.fecha_nacimiento_hijo_menor, anexo18_e.pasaporte_hijo_menor, anexo18_e.padre, anexo18_e.ciudadania_padre, anexo18_e.madre, anexo18_e.ciudadania_madre, anexo18_e.ultima_direccion_cuba, anexo18_e.recidir_cuba, anexo18_e.recidir_en_exterior, anexo18_e.razones_personales, anexo18_e.nombre_funcionario, anexo18_e.telefono, anexo18_e.email };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo18 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo18_e anexo18_e)
        {
            string[] columns = new string[] { "nombre_hombre", "nombre_mujer", "ciudadania_hombre", "ciudadania_mujer", "lugar_nacimiento_hombre", "lugar_nacimiento_mujer", "fecha_nacimiento_hombre", "fecha_nacimiento_mujer", "pasaporte_hombre", "pasaporte_mujer", "nombre_hijo_menor", "ciudadania_hijo_menor", "lugar_nacimineto_hijo_menor", "fecha_nacimiento_hijo_menor", "pasaporte_hijo_menor", "padre", "ciudadania_padre", "madre", "ciudadania_madre", "ultima_direccion_cuba", "recidir_cuba", "recidir_en_exterior", "razones_personales", "nombre_funcionario", "telefono", "email" };
            object[] values = new object[] { anexo18_e.nombre_hombre, anexo18_e.nombre_mujer, anexo18_e.ciudadania_hombre, anexo18_e.ciudadania_mujer, anexo18_e.lugar_nacimiento_hombre, anexo18_e.lugar_nacimiento_mujer, anexo18_e.fecha_nacimiento_hombre, anexo18_e.fecha_nacimiento_mujer, anexo18_e.pasaporte_hombre, anexo18_e.pasaporte_mujer, anexo18_e.nombre_hijo_menor, anexo18_e.ciudadania_hijo_menor, anexo18_e.lugar_nacimineto_hijo_menor, anexo18_e.fecha_nacimiento_hijo_menor, anexo18_e.pasaporte_hijo_menor, anexo18_e.padre, anexo18_e.ciudadania_padre, anexo18_e.madre, anexo18_e.ciudadania_madre, anexo18_e.ultima_direccion_cuba, anexo18_e.recidir_cuba, anexo18_e.recidir_en_exterior, anexo18_e.razones_personales, anexo18_e.nombre_funcionario, anexo18_e.telefono, anexo18_e.email };

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

            sqlite_cmd.CommandText = $"UPDATE anexo18 SET {data} WHERE id = {anexo18_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo18 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo18_e> list()
        {
            List<Anexo18_e> list = new List<Anexo18_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo18";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo18_e anexo18_e = new Anexo18_e();
                anexo18_e.id = sqlite_datareader.GetInt32(0);
                anexo18_e.nombre_hombre = sqlite_datareader.GetString(1);
                anexo18_e.nombre_mujer = sqlite_datareader.GetString(2);
                anexo18_e.ciudadania_hombre = sqlite_datareader.GetString(3);
                anexo18_e.ciudadania_mujer = sqlite_datareader.GetString(4);
                anexo18_e.lugar_nacimiento_hombre = sqlite_datareader.GetString(5);
                anexo18_e.lugar_nacimiento_mujer = sqlite_datareader.GetString(6);
                anexo18_e.fecha_nacimiento_hombre = sqlite_datareader.GetString(7);
                anexo18_e.fecha_nacimiento_mujer = sqlite_datareader.GetString(8);
                anexo18_e.pasaporte_hombre = sqlite_datareader.GetString(9);
                anexo18_e.pasaporte_mujer = sqlite_datareader.GetString(10);
                anexo18_e.nombre_hijo_menor = sqlite_datareader.GetString(11);
                anexo18_e.ciudadania_hijo_menor = sqlite_datareader.GetString(12);
                anexo18_e.lugar_nacimineto_hijo_menor = sqlite_datareader.GetString(13);
                anexo18_e.fecha_nacimiento_hijo_menor = sqlite_datareader.GetString(14);
                anexo18_e.pasaporte_hijo_menor = sqlite_datareader.GetString(15);
                anexo18_e.padre = sqlite_datareader.GetString(16);
                anexo18_e.ciudadania_padre = sqlite_datareader.GetString(17);
                anexo18_e.madre = sqlite_datareader.GetString(18);
                anexo18_e.ciudadania_madre = sqlite_datareader.GetString(19);
                anexo18_e.ultima_direccion_cuba = sqlite_datareader.GetString(20);
                anexo18_e.recidir_cuba = sqlite_datareader.GetString(21);
                anexo18_e.recidir_en_exterior = sqlite_datareader.GetString(22);
                anexo18_e.razones_personales = sqlite_datareader.GetString(23);
                anexo18_e.nombre_funcionario = sqlite_datareader.GetString(24);
                anexo18_e.telefono = sqlite_datareader.GetString(25);
                anexo18_e.email = sqlite_datareader.GetString(26);
                list.Add(anexo18_e);
            }
            
            return list;
        }
    }
}