using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo30_m
    {
        private SQLiteConnection connection;

        public Anexo30_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo30_e anexo30_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre", "sexo", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "sexo_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "direccion_vivienda", "clausaula" };
            object[] values = new object[] { anexo30_e.fecha_solicitud, anexo30_e.nombre, anexo30_e.sexo, anexo30_e.lugar_nacimineto_municipio, anexo30_e.lugar_nacimineto_provincia, anexo30_e.fecha_nacimineto, anexo30_e.estado_civil, anexo30_e.ciudadania, anexo30_e.ocupacion, anexo30_e.direccion, anexo30_e.carnet_pasaporte, anexo30_e.condicion_migratoria, anexo30_e.correo, anexo30_e.celular, anexo30_e.nombre_apoderado, anexo30_e.sexo_apoderado, anexo30_e.lugar_nacimineto_municipio_apoderado, anexo30_e.lugar_nacimineto_provincia_apoderado, anexo30_e.fecha_nacimineto_apoderado, anexo30_e.estado_civil_apoderado, anexo30_e.ciudadania_apoderado, anexo30_e.ocupacion_apoderado, anexo30_e.direccion_apoderado, anexo30_e.carnet_pasaporte_apoderado, anexo30_e.condicion_migratoria_apoderado, anexo30_e.direccion_vivienda, anexo30_e.clausaula };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo30 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo30_e anexo30_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre", "sexo", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "sexo_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "direccion_vivienda", "clausaula" };
            object[] values = new object[] { anexo30_e.fecha_solicitud, anexo30_e.nombre, anexo30_e.sexo, anexo30_e.lugar_nacimineto_municipio, anexo30_e.lugar_nacimineto_provincia, anexo30_e.fecha_nacimineto, anexo30_e.estado_civil, anexo30_e.ciudadania, anexo30_e.ocupacion, anexo30_e.direccion, anexo30_e.carnet_pasaporte, anexo30_e.condicion_migratoria, anexo30_e.correo, anexo30_e.celular, anexo30_e.nombre_apoderado, anexo30_e.sexo_apoderado, anexo30_e.lugar_nacimineto_municipio_apoderado, anexo30_e.lugar_nacimineto_provincia_apoderado, anexo30_e.fecha_nacimineto_apoderado, anexo30_e.estado_civil_apoderado, anexo30_e.ciudadania_apoderado, anexo30_e.ocupacion_apoderado, anexo30_e.direccion_apoderado, anexo30_e.carnet_pasaporte_apoderado, anexo30_e.condicion_migratoria_apoderado, anexo30_e.direccion_vivienda, anexo30_e.clausaula };

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

            sqlite_cmd.CommandText = $"UPDATE anexo30 SET {data} WHERE id = {anexo30_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo30 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo30_e> list()
        {
            List<Anexo30_e> list = new List<Anexo30_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo30";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo30_e anexo30_e = new Anexo30_e();
                anexo30_e.id = sqlite_datareader.GetInt32(0);
                anexo30_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo30_e.nombre = sqlite_datareader.GetString(2);
                anexo30_e.sexo = sqlite_datareader.GetString(3);
                anexo30_e.lugar_nacimineto_municipio = sqlite_datareader.GetString(4);
                anexo30_e.lugar_nacimineto_provincia = sqlite_datareader.GetString(5);
                anexo30_e.fecha_nacimineto = sqlite_datareader.GetString(6);
                anexo30_e.estado_civil = sqlite_datareader.GetString(7);
                anexo30_e.ciudadania = sqlite_datareader.GetString(8);
                anexo30_e.ocupacion = sqlite_datareader.GetString(9);
                anexo30_e.direccion = sqlite_datareader.GetString(10);
                anexo30_e.carnet_pasaporte = sqlite_datareader.GetString(11);
                anexo30_e.condicion_migratoria = sqlite_datareader.GetString(12);
                anexo30_e.correo = sqlite_datareader.GetString(13);
                anexo30_e.celular = sqlite_datareader.GetString(14);
                anexo30_e.nombre_apoderado = sqlite_datareader.GetString(15);
                anexo30_e.sexo_apoderado = sqlite_datareader.GetString(16);
                anexo30_e.lugar_nacimineto_municipio_apoderado = sqlite_datareader.GetString(17);
                anexo30_e.lugar_nacimineto_provincia_apoderado = sqlite_datareader.GetString(18);
                anexo30_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(19);
                anexo30_e.estado_civil_apoderado = sqlite_datareader.GetString(20);
                anexo30_e.ciudadania_apoderado = sqlite_datareader.GetString(21);
                anexo30_e.ocupacion_apoderado = sqlite_datareader.GetString(22);
                anexo30_e.direccion_apoderado = sqlite_datareader.GetString(23);
                anexo30_e.carnet_pasaporte_apoderado = sqlite_datareader.GetString(24);
                anexo30_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(25);
                anexo30_e.direccion_vivienda = sqlite_datareader.GetString(26);
                anexo30_e.clausaula = sqlite_datareader.GetString(27);
                list.Add(anexo30_e);
            }
            
            return list;
        }
    }
}