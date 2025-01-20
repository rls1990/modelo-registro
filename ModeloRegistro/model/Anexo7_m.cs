using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo7_m
    {
        private SQLiteConnection connection;

        public Anexo7_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo7_e anexo7_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellido", "fecha_defuncion", "municipio_fallecimineto", "provincia_fallecimineto", "donde_fue_velado", "municipio_funeraria", "provincia_funeraria", "tomo", "folio", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo7_e.pais, anexo7_e.nombre_apellido, anexo7_e.fecha_defuncion, anexo7_e.municipio_fallecimineto, anexo7_e.provincia_fallecimineto, anexo7_e.donde_fue_velado, anexo7_e.municipio_funeraria, anexo7_e.provincia_funeraria, anexo7_e.tomo, anexo7_e.folio, anexo7_e.legalizacion_minrex, anexo7_e.legalizacion_embajada, anexo7_e.fecha_de_solicitud, anexo7_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo7 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo7_e anexo7_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellido", "fecha_defuncion", "municipio_fallecimineto", "provincia_fallecimineto", "donde_fue_velado", "municipio_funeraria", "provincia_funeraria", "tomo", "folio", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo7_e.pais, anexo7_e.nombre_apellido, anexo7_e.fecha_defuncion, anexo7_e.municipio_fallecimineto, anexo7_e.provincia_fallecimineto, anexo7_e.donde_fue_velado, anexo7_e.municipio_funeraria, anexo7_e.provincia_funeraria, anexo7_e.tomo, anexo7_e.folio, anexo7_e.legalizacion_minrex, anexo7_e.legalizacion_embajada, anexo7_e.fecha_de_solicitud, anexo7_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo7 SET {data} WHERE id = {anexo7_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo7 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo7_e> list()
        {
            List<Anexo7_e> list = new List<Anexo7_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo7";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo7_e anexo7_e = new Anexo7_e();
                anexo7_e.ciudad = sqlite_datareader.GetString(0);
                anexo7_e.pais = sqlite_datareader.GetString(1);
                anexo7_e.nombre_apellido = sqlite_datareader.GetString(2);
                anexo7_e.fecha_defuncion = sqlite_datareader.GetString(3);
                anexo7_e.municipio_fallecimineto = sqlite_datareader.GetString(4);
                anexo7_e.provincia_fallecimineto = sqlite_datareader.GetString(5);
                anexo7_e.donde_fue_velado = sqlite_datareader.GetString(6);
                anexo7_e.municipio_funeraria = sqlite_datareader.GetString(7);
                anexo7_e.provincia_funeraria = sqlite_datareader.GetString(8);
                anexo7_e.tomo = sqlite_datareader.GetString(9);
                anexo7_e.folio = sqlite_datareader.GetString(10);
                anexo7_e.legalizacion_minrex = sqlite_datareader.GetString(11);
                anexo7_e.legalizacion_embajada = sqlite_datareader.GetString(12);
                anexo7_e.fecha_de_solicitud = sqlite_datareader.GetString(13);
                anexo7_e.id = sqlite_datareader.GetInt32(14);
                list.Add(anexo7_e);
            }
            
            return list;
        }
    }
}