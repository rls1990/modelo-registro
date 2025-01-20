using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo3_m
    {
        private SQLiteConnection connection;

        public Anexo3_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo3_e anexo3_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellido", "fecha_nacimiento", "municipio", "provincia", "registro", "municipio_registro", "provincia_registro", "tomo", "folio", "fecha_asiento", "nombre_padre", "nombre_madre", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud", "id" };
            object[] values = new object[] { anexo3_e.pais, anexo3_e.nombre_apellido, anexo3_e.fecha_nacimiento, anexo3_e.municipio, anexo3_e.provincia, anexo3_e.registro, anexo3_e.municipio_registro, anexo3_e.provincia_registro, anexo3_e.tomo, anexo3_e.folio, anexo3_e.fecha_asiento, anexo3_e.nombre_padre, anexo3_e.nombre_madre, anexo3_e.legalizacion_minred, anexo3_e.legalizacion_embajada, anexo3_e.fecha_solicitud, anexo3_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo3 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo3_e anexo3_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellido", "fecha_nacimiento", "municipio", "provincia", "registro", "municipio_registro", "provincia_registro", "tomo", "folio", "fecha_asiento", "nombre_padre", "nombre_madre", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud", "id" };
            object[] values = new object[] { anexo3_e.pais, anexo3_e.nombre_apellido, anexo3_e.fecha_nacimiento, anexo3_e.municipio, anexo3_e.provincia, anexo3_e.registro, anexo3_e.municipio_registro, anexo3_e.provincia_registro, anexo3_e.tomo, anexo3_e.folio, anexo3_e.fecha_asiento, anexo3_e.nombre_padre, anexo3_e.nombre_madre, anexo3_e.legalizacion_minred, anexo3_e.legalizacion_embajada, anexo3_e.fecha_solicitud, anexo3_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo3 SET {data} WHERE id = {anexo3_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo3 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo3_e> list()
        {
            List<Anexo3_e> list = new List<Anexo3_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo3";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo3_e anexo3_e = new Anexo3_e();
                anexo3_e.ciudad = sqlite_datareader.GetString(0);
                anexo3_e.pais = sqlite_datareader.GetString(1);
                anexo3_e.nombre_apellido = sqlite_datareader.GetString(2);
                anexo3_e.fecha_nacimiento = sqlite_datareader.GetString(3);
                anexo3_e.municipio = sqlite_datareader.GetString(4);
                anexo3_e.provincia = sqlite_datareader.GetString(5);
                anexo3_e.registro = sqlite_datareader.GetString(6);
                anexo3_e.municipio_registro = sqlite_datareader.GetString(7);
                anexo3_e.provincia_registro = sqlite_datareader.GetString(8);
                anexo3_e.tomo = sqlite_datareader.GetString(9);
                anexo3_e.folio = sqlite_datareader.GetString(10);
                anexo3_e.fecha_asiento = sqlite_datareader.GetString(11);
                anexo3_e.nombre_padre = sqlite_datareader.GetString(12);
                anexo3_e.nombre_madre = sqlite_datareader.GetString(13);
                anexo3_e.legalizacion_minred = sqlite_datareader.GetString(14);
                anexo3_e.legalizacion_embajada = sqlite_datareader.GetString(15);
                anexo3_e.fecha_solicitud = sqlite_datareader.GetString(16);
                anexo3_e.id = sqlite_datareader.GetInt32(17);
                list.Add(anexo3_e);
            }
            
            return list;
        }
    }
}