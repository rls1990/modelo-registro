using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo11_m
    {
        private SQLiteConnection connection;

        public Anexo11_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo11_e anexo11_e)
        {
            string[] columns = new string[] { "pais", "solicito_certificado", "de_mi", "nombre_apellidos", "fecha_nacimiento", "lugar_nacimiento", "nombre_padres", "lugar_vivio_cuba", "fecha_fallecimiento", "otros_datos_interes", "nombre_apellidos_solicitante", "doc_identidad", "pasaporte", "direccion", "telefono", "email", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo11_e.pais, anexo11_e.solicito_certificado, anexo11_e.de_mi, anexo11_e.nombre_apellidos, anexo11_e.fecha_nacimiento, anexo11_e.lugar_nacimiento, anexo11_e.nombre_padres, anexo11_e.lugar_vivio_cuba, anexo11_e.fecha_fallecimiento, anexo11_e.otros_datos_interes, anexo11_e.nombre_apellidos_solicitante, anexo11_e.doc_identidad, anexo11_e.pasaporte, anexo11_e.direccion, anexo11_e.telefono, anexo11_e.email, anexo11_e.legalizacion_minrex, anexo11_e.legalizacion_embajada, anexo11_e.fecha_de_solicitud, anexo11_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo11 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo11_e anexo11_e)
        {
            string[] columns = new string[] { "pais", "solicito_certificado", "de_mi", "nombre_apellidos", "fecha_nacimiento", "lugar_nacimiento", "nombre_padres", "lugar_vivio_cuba", "fecha_fallecimiento", "otros_datos_interes", "nombre_apellidos_solicitante", "doc_identidad", "pasaporte", "direccion", "telefono", "email", "legalizacion_minrex", "legalizacion_embajada", "fecha_de_solicitud", "id" };
            object[] values = new object[] { anexo11_e.pais, anexo11_e.solicito_certificado, anexo11_e.de_mi, anexo11_e.nombre_apellidos, anexo11_e.fecha_nacimiento, anexo11_e.lugar_nacimiento, anexo11_e.nombre_padres, anexo11_e.lugar_vivio_cuba, anexo11_e.fecha_fallecimiento, anexo11_e.otros_datos_interes, anexo11_e.nombre_apellidos_solicitante, anexo11_e.doc_identidad, anexo11_e.pasaporte, anexo11_e.direccion, anexo11_e.telefono, anexo11_e.email, anexo11_e.legalizacion_minrex, anexo11_e.legalizacion_embajada, anexo11_e.fecha_de_solicitud, anexo11_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo11 SET {data} WHERE id = {anexo11_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo11 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo11_e> list()
        {
            List<Anexo11_e> list = new List<Anexo11_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo11";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo11_e anexo11_e = new Anexo11_e();
                anexo11_e.ciudad = sqlite_datareader.GetString(0);
                anexo11_e.pais = sqlite_datareader.GetString(1);
                anexo11_e.solicito_certificado = sqlite_datareader.GetString(2);
                anexo11_e.de_mi = sqlite_datareader.GetString(3);
                anexo11_e.nombre_apellidos = sqlite_datareader.GetString(4);
                anexo11_e.fecha_nacimiento = sqlite_datareader.GetString(5);
                anexo11_e.lugar_nacimiento = sqlite_datareader.GetString(6);
                anexo11_e.nombre_padres = sqlite_datareader.GetString(7);
                anexo11_e.lugar_vivio_cuba = sqlite_datareader.GetString(8);
                anexo11_e.fecha_fallecimiento = sqlite_datareader.GetString(9);
                anexo11_e.otros_datos_interes = sqlite_datareader.GetString(10);
                anexo11_e.nombre_apellidos_solicitante = sqlite_datareader.GetString(11);
                anexo11_e.doc_identidad = sqlite_datareader.GetString(12);
                anexo11_e.pasaporte = sqlite_datareader.GetString(13);
                anexo11_e.direccion = sqlite_datareader.GetString(14);
                anexo11_e.telefono = sqlite_datareader.GetString(15);
                anexo11_e.email = sqlite_datareader.GetString(16);
                anexo11_e.legalizacion_minrex = sqlite_datareader.GetString(17);
                anexo11_e.legalizacion_embajada = sqlite_datareader.GetString(18);
                anexo11_e.fecha_de_solicitud = sqlite_datareader.GetString(19);
                anexo11_e.id = sqlite_datareader.GetInt32(20);
                list.Add(anexo11_e);
            }
            
            return list;
        }
    }
}