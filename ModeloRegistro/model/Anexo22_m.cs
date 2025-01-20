using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo22_m
    {
        private SQLiteConnection connection;

        public Anexo22_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo22_e anexo22_e)
        {
            string[] columns = new string[] { "nombre", "ciudadania", "estado_civil", "fecha_nacimiento", "profecion", "carnet_pasaporte", "categoria_migratoria", "direccion_estados_unidos", "correo", "celular", "documento_legalizar", "id" };
            object[] values = new object[] { anexo22_e.nombre, anexo22_e.ciudadania, anexo22_e.estado_civil, anexo22_e.fecha_nacimiento, anexo22_e.profecion, anexo22_e.carnet_pasaporte, anexo22_e.categoria_migratoria, anexo22_e.direccion_estados_unidos, anexo22_e.correo, anexo22_e.celular, anexo22_e.documento_legalizar, anexo22_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo22 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo22_e anexo22_e)
        {
            string[] columns = new string[] { "nombre", "ciudadania", "estado_civil", "fecha_nacimiento", "profecion", "carnet_pasaporte", "categoria_migratoria", "direccion_estados_unidos", "correo", "celular", "documento_legalizar", "id" };
            object[] values = new object[] { anexo22_e.nombre, anexo22_e.ciudadania, anexo22_e.estado_civil, anexo22_e.fecha_nacimiento, anexo22_e.profecion, anexo22_e.carnet_pasaporte, anexo22_e.categoria_migratoria, anexo22_e.direccion_estados_unidos, anexo22_e.correo, anexo22_e.celular, anexo22_e.documento_legalizar, anexo22_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo22 SET {data} WHERE id = {anexo22_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo22 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo22_e> list()
        {
            List<Anexo22_e> list = new List<Anexo22_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo22";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo22_e anexo22_e = new Anexo22_e();
                anexo22_e.fecha_solicitud = sqlite_datareader.GetString(0);
                anexo22_e.nombre = sqlite_datareader.GetString(1);
                anexo22_e.ciudadania = sqlite_datareader.GetString(2);
                anexo22_e.estado_civil = sqlite_datareader.GetString(3);
                anexo22_e.fecha_nacimiento = sqlite_datareader.GetString(4);
                anexo22_e.profecion = sqlite_datareader.GetString(5);
                anexo22_e.carnet_pasaporte = sqlite_datareader.GetString(6);
                anexo22_e.categoria_migratoria = sqlite_datareader.GetString(7);
                anexo22_e.direccion_estados_unidos = sqlite_datareader.GetString(8);
                anexo22_e.correo = sqlite_datareader.GetString(9);
                anexo22_e.celular = sqlite_datareader.GetString(10);
                anexo22_e.documento_legalizar = sqlite_datareader.GetString(11);
                anexo22_e.id = sqlite_datareader.GetInt32(12);
                list.Add(anexo22_e);
            }
            
            return list;
        }
    }
}