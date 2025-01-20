using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo5_m
    {
        private SQLiteConnection connection;

        public Anexo5_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo5_e anexo5_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellido_hombre", "nombre_apellido_mujer", "fecha_matrimonio", "ciudad_matrimonio", "provincia_matrimonio", "pais_matrimonio", "registro", "municipio_registro", "provincia_registro", "tomo", "folio", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud", "id" };
            object[] values = new object[] { anexo5_e.pais, anexo5_e.nombre_apellido_hombre, anexo5_e.nombre_apellido_mujer, anexo5_e.fecha_matrimonio, anexo5_e.ciudad_matrimonio, anexo5_e.provincia_matrimonio, anexo5_e.pais_matrimonio, anexo5_e.registro, anexo5_e.municipio_registro, anexo5_e.provincia_registro, anexo5_e.tomo, anexo5_e.folio, anexo5_e.legalizacion_minred, anexo5_e.legalizacion_embajada, anexo5_e.fecha_solicitud, anexo5_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo5 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo5_e anexo5_e)
        {
            string[] columns = new string[] { "pais", "nombre_apellido_hombre", "nombre_apellido_mujer", "fecha_matrimonio", "ciudad_matrimonio", "provincia_matrimonio", "pais_matrimonio", "registro", "municipio_registro", "provincia_registro", "tomo", "folio", "legalizacion_minred", "legalizacion_embajada", "fecha_solicitud", "id" };
            object[] values = new object[] { anexo5_e.pais, anexo5_e.nombre_apellido_hombre, anexo5_e.nombre_apellido_mujer, anexo5_e.fecha_matrimonio, anexo5_e.ciudad_matrimonio, anexo5_e.provincia_matrimonio, anexo5_e.pais_matrimonio, anexo5_e.registro, anexo5_e.municipio_registro, anexo5_e.provincia_registro, anexo5_e.tomo, anexo5_e.folio, anexo5_e.legalizacion_minred, anexo5_e.legalizacion_embajada, anexo5_e.fecha_solicitud, anexo5_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo5 SET {data} WHERE id = {anexo5_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo5 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo5_e> list()
        {
            List<Anexo5_e> list = new List<Anexo5_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo5";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo5_e anexo5_e = new Anexo5_e();
                anexo5_e.ciudad = sqlite_datareader.GetString(0);
                anexo5_e.pais = sqlite_datareader.GetString(1);
                anexo5_e.nombre_apellido_hombre = sqlite_datareader.GetString(2);
                anexo5_e.nombre_apellido_mujer = sqlite_datareader.GetString(3);
                anexo5_e.fecha_matrimonio = sqlite_datareader.GetString(4);
                anexo5_e.ciudad_matrimonio = sqlite_datareader.GetString(5);
                anexo5_e.provincia_matrimonio = sqlite_datareader.GetString(6);
                anexo5_e.pais_matrimonio = sqlite_datareader.GetString(7);
                anexo5_e.registro = sqlite_datareader.GetString(8);
                anexo5_e.municipio_registro = sqlite_datareader.GetString(9);
                anexo5_e.provincia_registro = sqlite_datareader.GetString(10);
                anexo5_e.tomo = sqlite_datareader.GetString(11);
                anexo5_e.folio = sqlite_datareader.GetString(12);
                anexo5_e.legalizacion_minred = sqlite_datareader.GetString(13);
                anexo5_e.legalizacion_embajada = sqlite_datareader.GetString(14);
                anexo5_e.fecha_solicitud = sqlite_datareader.GetString(15);
                anexo5_e.id = sqlite_datareader.GetInt32(16);
                list.Add(anexo5_e);
            }
            
            return list;
        }
    }
}