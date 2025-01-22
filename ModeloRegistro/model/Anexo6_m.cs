using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo6_m
    {
        private SQLiteConnection connection;

        public Anexo6_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo6_e anexo6_e)
        {
            string[] columns = new string[] { "ciudad", "pais", "nombre_apellido_hombre", "nombre_apellido_mujer", "tribunal_dicto_sentencia", "nombre_secretario_actuante", "fecha_dicto_sentencia", "fecha_firmeza_sentencia", "no_sentencia", "no_radicacion", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud" };
            object[] values = new object[] { anexo6_e.ciudad, anexo6_e.pais, anexo6_e.nombre_apellido_hombre, anexo6_e.nombre_apellido_mujer, anexo6_e.tribunal_dicto_sentencia, anexo6_e.nombre_secretario_actuante, anexo6_e.fecha_dicto_sentencia, anexo6_e.fecha_firmeza_sentencia, anexo6_e.no_sentencia, anexo6_e.no_radicacion, anexo6_e.legalizacion_minred, anexo6_e.legalizacion_embajada, anexo6_e.fecha_solicitud };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo6 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo6_e anexo6_e)
        {
            string[] columns = new string[] { "ciudad", "pais", "nombre_apellido_hombre", "nombre_apellido_mujer", "tribunal_dicto_sentencia", "nombre_secretario_actuante", "fecha_dicto_sentencia", "fecha_firmeza_sentencia", "no_sentencia", "no_radicacion", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud" };
            object[] values = new object[] { anexo6_e.ciudad, anexo6_e.pais, anexo6_e.nombre_apellido_hombre, anexo6_e.nombre_apellido_mujer, anexo6_e.tribunal_dicto_sentencia, anexo6_e.nombre_secretario_actuante, anexo6_e.fecha_dicto_sentencia, anexo6_e.fecha_firmeza_sentencia, anexo6_e.no_sentencia, anexo6_e.no_radicacion, anexo6_e.legalizacion_minred, anexo6_e.legalizacion_embajada, anexo6_e.fecha_solicitud };

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

            sqlite_cmd.CommandText = $"UPDATE anexo6 SET {data} WHERE id = {anexo6_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo6 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo6_e> list()
        {
            List<Anexo6_e> list = new List<Anexo6_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo6";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo6_e anexo6_e = new Anexo6_e();
                anexo6_e.id = sqlite_datareader.GetInt32(0);
                anexo6_e.ciudad = sqlite_datareader.GetString(1);
                anexo6_e.pais = sqlite_datareader.GetString(2);
                anexo6_e.nombre_apellido_hombre = sqlite_datareader.GetString(3);
                anexo6_e.nombre_apellido_mujer = sqlite_datareader.GetString(4);
                anexo6_e.tribunal_dicto_sentencia = sqlite_datareader.GetString(5);
                anexo6_e.nombre_secretario_actuante = sqlite_datareader.GetString(6);
                anexo6_e.fecha_dicto_sentencia = sqlite_datareader.GetString(7);
                anexo6_e.fecha_firmeza_sentencia = sqlite_datareader.GetString(8);
                anexo6_e.no_sentencia = sqlite_datareader.GetString(9);
                anexo6_e.no_radicacion = sqlite_datareader.GetString(10);
                anexo6_e.legalizacion_minred = sqlite_datareader.GetString(11);
                anexo6_e.legalizacion_embajada = sqlite_datareader.GetString(12);
                anexo6_e.fecha_solicitud = sqlite_datareader.GetString(13);
                list.Add(anexo6_e);
            }
            
            return list;
        }
    }
}