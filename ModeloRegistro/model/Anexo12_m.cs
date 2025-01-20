using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo12_m
    {
        private SQLiteConnection connection;

        public Anexo12_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo12_e anexo12_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellidos", "ciudadano", "carnet_identidad", "fecha_nacimiento", "lugar_nacimineto", "registro_civil", "vecino_de", "nombre_apellido_apoderado", "si", "no", "numero", "fecha_poder_especial", "nombre_apellido_notario", "competencia", "sede", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo12_e.pais, anexo12_e.nombre_apellidos, anexo12_e.ciudadano, anexo12_e.carnet_identidad, anexo12_e.fecha_nacimiento, anexo12_e.lugar_nacimineto, anexo12_e.registro_civil, anexo12_e.vecino_de, anexo12_e.nombre_apellido_apoderado, anexo12_e.si, anexo12_e.no, anexo12_e.numero, anexo12_e.fecha_poder_especial, anexo12_e.nombre_apellido_notario, anexo12_e.competencia, anexo12_e.sede, anexo12_e.legalizacion_minrex, anexo12_e.legalizacion_embajada, anexo12_e.fecha_de_solicitud, anexo12_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo12 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo12_e anexo12_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellidos", "ciudadano", "carnet_identidad", "fecha_nacimiento", "lugar_nacimineto", "registro_civil", "vecino_de", "nombre_apellido_apoderado", "si", "no", "numero", "fecha_poder_especial", "nombre_apellido_notario", "competencia", "sede", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo12_e.pais, anexo12_e.nombre_apellidos, anexo12_e.ciudadano, anexo12_e.carnet_identidad, anexo12_e.fecha_nacimiento, anexo12_e.lugar_nacimineto, anexo12_e.registro_civil, anexo12_e.vecino_de, anexo12_e.nombre_apellido_apoderado, anexo12_e.si, anexo12_e.no, anexo12_e.numero, anexo12_e.fecha_poder_especial, anexo12_e.nombre_apellido_notario, anexo12_e.competencia, anexo12_e.sede, anexo12_e.legalizacion_minrex, anexo12_e.legalizacion_embajada, anexo12_e.fecha_de_solicitud, anexo12_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo12 SET {data} WHERE id = {anexo12_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo12 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo12_e> list()
        {
            List<Anexo12_e> list = new List<Anexo12_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo12";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo12_e anexo12_e = new Anexo12_e();
                anexo12_e.ciudad = sqlite_datareader.GetString(0);
                anexo12_e.pais = sqlite_datareader.GetString(1);
                anexo12_e.nombre_apellidos = sqlite_datareader.GetString(2);
                anexo12_e.ciudadano = sqlite_datareader.GetString(3);
                anexo12_e.carnet_identidad = sqlite_datareader.GetString(4);
                anexo12_e.fecha_nacimiento = sqlite_datareader.GetString(5);
                anexo12_e.lugar_nacimineto = sqlite_datareader.GetString(6);
                anexo12_e.registro_civil = sqlite_datareader.GetString(7);
                anexo12_e.vecino_de = sqlite_datareader.GetString(8);
                anexo12_e.nombre_apellido_apoderado = sqlite_datareader.GetString(9);
                anexo12_e.si = sqlite_datareader.GetString(10);
                anexo12_e.no = sqlite_datareader.GetString(11);
                anexo12_e.numero = sqlite_datareader.GetString(12);
                anexo12_e.fecha_poder_especial = sqlite_datareader.GetString(13);
                anexo12_e.nombre_apellido_notario = sqlite_datareader.GetString(14);
                anexo12_e.competencia = sqlite_datareader.GetString(15);
                anexo12_e.sede = sqlite_datareader.GetString(16);
                anexo12_e.legalizacion_minrex = sqlite_datareader.GetString(17);
                anexo12_e.legalizacion_embajada = sqlite_datareader.GetString(18);
                anexo12_e.fecha_de_solicitud = sqlite_datareader.GetString(19);
                anexo12_e.id = sqlite_datareader.GetInt32(20);
                list.Add(anexo12_e);
            }
            
            return list;
        }
    }
}