using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo9_m
    {
        private SQLiteConnection connection;

        public Anexo9_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo9_e anexo9_e)
        {
            string[] columns = new string[] { "pais", "encargado_registro_civil", "municipio_encargado", "provincia_encargado", "nombre", "fecha_solicitud", "tomo_certificado", "folio_certificado", "fecha_nacimiento", "municipio_persona", "provincia_persona", "padre", "madre", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo9_e.pais, anexo9_e.encargado_registro_civil, anexo9_e.municipio_encargado, anexo9_e.provincia_encargado, anexo9_e.nombre, anexo9_e.fecha_solicitud, anexo9_e.tomo_certificado, anexo9_e.folio_certificado, anexo9_e.fecha_nacimiento, anexo9_e.municipio_persona, anexo9_e.provincia_persona, anexo9_e.padre, anexo9_e.madre, anexo9_e.legalizacion_minrex, anexo9_e.legalizacion_embajada, anexo9_e.fecha_de_solicitud, anexo9_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo9 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo9_e anexo9_e)
        {
            string[] columns = new string[] { "pais", "encargado_registro_civil", "municipio_encargado", "provincia_encargado", "nombre", "fecha_solicitud", "tomo_certificado", "folio_certificado", "fecha_nacimiento", "municipio_persona", "provincia_persona", "padre", "madre", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo9_e.pais, anexo9_e.encargado_registro_civil, anexo9_e.municipio_encargado, anexo9_e.provincia_encargado, anexo9_e.nombre, anexo9_e.fecha_solicitud, anexo9_e.tomo_certificado, anexo9_e.folio_certificado, anexo9_e.fecha_nacimiento, anexo9_e.municipio_persona, anexo9_e.provincia_persona, anexo9_e.padre, anexo9_e.madre, anexo9_e.legalizacion_minrex, anexo9_e.legalizacion_embajada, anexo9_e.fecha_de_solicitud, anexo9_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo9 SET {data} WHERE id = {anexo9_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo9 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo9_e> list()
        {
            List<Anexo9_e> list = new List<Anexo9_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo9";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo9_e anexo9_e = new Anexo9_e();
                anexo9_e.ciudad = sqlite_datareader.GetString(0);
                anexo9_e.pais = sqlite_datareader.GetString(1);
                anexo9_e.encargado_registro_civil = sqlite_datareader.GetString(2);
                anexo9_e.municipio_encargado = sqlite_datareader.GetString(3);
                anexo9_e.provincia_encargado = sqlite_datareader.GetString(4);
                anexo9_e.nombre = sqlite_datareader.GetString(5);
                anexo9_e.fecha_solicitud = sqlite_datareader.GetString(6);
                anexo9_e.tomo_certificado = sqlite_datareader.GetString(7);
                anexo9_e.folio_certificado = sqlite_datareader.GetString(8);
                anexo9_e.fecha_nacimiento = sqlite_datareader.GetString(9);
                anexo9_e.municipio_persona = sqlite_datareader.GetString(10);
                anexo9_e.provincia_persona = sqlite_datareader.GetString(11);
                anexo9_e.padre = sqlite_datareader.GetString(12);
                anexo9_e.madre = sqlite_datareader.GetString(13);
                anexo9_e.legalizacion_minrex = sqlite_datareader.GetString(14);
                anexo9_e.legalizacion_embajada = sqlite_datareader.GetString(15);
                anexo9_e.fecha_de_solicitud = sqlite_datareader.GetString(16);
                anexo9_e.id = sqlite_datareader.GetInt32(17);
                list.Add(anexo9_e);
            }
            
            return list;
        }
    }
}