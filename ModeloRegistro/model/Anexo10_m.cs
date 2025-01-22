using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo10_m
    {
        private SQLiteConnection connection;

        public Anexo10_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo10_e anexo10_e)
        {
            string[] columns = new string[] { "ciudad", "pais", "solicito_certificado", "de_mi", "nombre_apellidos", "fecha_nacimiento", "lugar_nacimiento", "nombre_padres", "lugar_vivio_cuba", "fecha_fallecimiento", "otros_datos_interes", "nombre_apellidos_solicitante", "doc_identidad", "pasaporte", "direccion", "telefono", "email", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud" };
            object[] values = new object[] { anexo10_e.ciudad, anexo10_e.pais, anexo10_e.solicito_certificado, anexo10_e.de_mi, anexo10_e.nombre_apellidos, anexo10_e.fecha_nacimiento, anexo10_e.lugar_nacimiento, anexo10_e.nombre_padres, anexo10_e.lugar_vivio_cuba, anexo10_e.fecha_fallecimiento, anexo10_e.otros_datos_interes, anexo10_e.nombre_apellidos_solicitante, anexo10_e.doc_identidad, anexo10_e.pasaporte, anexo10_e.direccion, anexo10_e.telefono, anexo10_e.email, anexo10_e.legalizacion_minrex, anexo10_e.legalizacion_embajada, anexo10_e.fecha_de_solicitud };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo10 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo10_e anexo10_e)
        {
            string[] columns = new string[] { "ciudad", "pais", "solicito_certificado", "de_mi", "nombre_apellidos", "fecha_nacimiento", "lugar_nacimiento", "nombre_padres", "lugar_vivio_cuba", "fecha_fallecimiento", "otros_datos_interes", "nombre_apellidos_solicitante", "doc_identidad", "pasaporte", "direccion", "telefono", "email", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud" };
            object[] values = new object[] { anexo10_e.ciudad, anexo10_e.pais, anexo10_e.solicito_certificado, anexo10_e.de_mi, anexo10_e.nombre_apellidos, anexo10_e.fecha_nacimiento, anexo10_e.lugar_nacimiento, anexo10_e.nombre_padres, anexo10_e.lugar_vivio_cuba, anexo10_e.fecha_fallecimiento, anexo10_e.otros_datos_interes, anexo10_e.nombre_apellidos_solicitante, anexo10_e.doc_identidad, anexo10_e.pasaporte, anexo10_e.direccion, anexo10_e.telefono, anexo10_e.email, anexo10_e.legalizacion_minrex, anexo10_e.legalizacion_embajada, anexo10_e.fecha_de_solicitud };

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

            sqlite_cmd.CommandText = $"UPDATE anexo10 SET {data} WHERE id = {anexo10_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo10 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo10_e> list()
        {
            List<Anexo10_e> list = new List<Anexo10_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo10";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo10_e anexo10_e = new Anexo10_e();
                anexo10_e.id = sqlite_datareader.GetInt32(0);
                anexo10_e.ciudad = sqlite_datareader.GetString(1);
                anexo10_e.pais = sqlite_datareader.GetString(2);
                anexo10_e.solicito_certificado = sqlite_datareader.GetString(3);
                anexo10_e.de_mi = sqlite_datareader.GetString(4);
                anexo10_e.nombre_apellidos = sqlite_datareader.GetString(5);
                anexo10_e.fecha_nacimiento = sqlite_datareader.GetString(6);
                anexo10_e.lugar_nacimiento = sqlite_datareader.GetString(7);
                anexo10_e.nombre_padres = sqlite_datareader.GetString(8);
                anexo10_e.lugar_vivio_cuba = sqlite_datareader.GetString(9);
                anexo10_e.fecha_fallecimiento = sqlite_datareader.GetString(10);
                anexo10_e.otros_datos_interes = sqlite_datareader.GetString(11);
                anexo10_e.nombre_apellidos_solicitante = sqlite_datareader.GetString(12);
                anexo10_e.doc_identidad = sqlite_datareader.GetString(13);
                anexo10_e.pasaporte = sqlite_datareader.GetString(14);
                anexo10_e.direccion = sqlite_datareader.GetString(15);
                anexo10_e.telefono = sqlite_datareader.GetString(16);
                anexo10_e.email = sqlite_datareader.GetString(17);
                anexo10_e.legalizacion_minrex = sqlite_datareader.GetString(18);
                anexo10_e.legalizacion_embajada = sqlite_datareader.GetString(19);
                anexo10_e.fecha_de_solicitud = sqlite_datareader.GetString(20);
                list.Add(anexo10_e);
            }
            
            return list;
        }
    }
}