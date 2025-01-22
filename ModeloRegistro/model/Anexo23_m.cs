using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo23_m
    {
        private SQLiteConnection connection;

        public Anexo23_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo23_e anexo23_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre", "sexo", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "sexo_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "direccion_vivienda", "clausula" };
            object[] values = new object[] { anexo23_e.fecha_solicitud, anexo23_e.nombre, anexo23_e.sexo, anexo23_e.lugar_nacimineto_municipio, anexo23_e.lugar_nacimineto_provincia, anexo23_e.fecha_nacimineto, anexo23_e.estado_civil, anexo23_e.ciudadania, anexo23_e.ocupacion, anexo23_e.direccion, anexo23_e.carnet_pasaporte, anexo23_e.condicion_migratoria, anexo23_e.correo, anexo23_e.celular, anexo23_e.nombre_apoderado, anexo23_e.sexo_apoderado, anexo23_e.lugar_nacimineto_municipio_apoderado, anexo23_e.lugar_nacimineto_provincia_apoderado, anexo23_e.fecha_nacimineto_apoderado, anexo23_e.estado_civil_apoderado, anexo23_e.ciudadania_apoderado, anexo23_e.ocupacion_apoderado, anexo23_e.direccion_apoderado, anexo23_e.carnet_pasaporte_apoderado, anexo23_e.condicion_migratoria_apoderado, anexo23_e.direccion_vivienda, anexo23_e.clausula };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo23 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo23_e anexo23_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre", "sexo", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "sexo_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "direccion_vivienda", "clausula" };
            object[] values = new object[] { anexo23_e.fecha_solicitud, anexo23_e.nombre, anexo23_e.sexo, anexo23_e.lugar_nacimineto_municipio, anexo23_e.lugar_nacimineto_provincia, anexo23_e.fecha_nacimineto, anexo23_e.estado_civil, anexo23_e.ciudadania, anexo23_e.ocupacion, anexo23_e.direccion, anexo23_e.carnet_pasaporte, anexo23_e.condicion_migratoria, anexo23_e.correo, anexo23_e.celular, anexo23_e.nombre_apoderado, anexo23_e.sexo_apoderado, anexo23_e.lugar_nacimineto_municipio_apoderado, anexo23_e.lugar_nacimineto_provincia_apoderado, anexo23_e.fecha_nacimineto_apoderado, anexo23_e.estado_civil_apoderado, anexo23_e.ciudadania_apoderado, anexo23_e.ocupacion_apoderado, anexo23_e.direccion_apoderado, anexo23_e.carnet_pasaporte_apoderado, anexo23_e.condicion_migratoria_apoderado, anexo23_e.direccion_vivienda, anexo23_e.clausula };

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

            sqlite_cmd.CommandText = $"UPDATE anexo23 SET {data} WHERE id = {anexo23_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo23 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo23_e> list()
        {
            List<Anexo23_e> list = new List<Anexo23_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo23";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo23_e anexo23_e = new Anexo23_e();
                anexo23_e.id = sqlite_datareader.GetInt32(0);
                anexo23_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo23_e.nombre = sqlite_datareader.GetString(2);
                anexo23_e.sexo = sqlite_datareader.GetString(3);
                anexo23_e.lugar_nacimineto_municipio = sqlite_datareader.GetString(4);
                anexo23_e.lugar_nacimineto_provincia = sqlite_datareader.GetString(5);
                anexo23_e.fecha_nacimineto = sqlite_datareader.GetString(6);
                anexo23_e.estado_civil = sqlite_datareader.GetString(7);
                anexo23_e.ciudadania = sqlite_datareader.GetString(8);
                anexo23_e.ocupacion = sqlite_datareader.GetString(9);
                anexo23_e.direccion = sqlite_datareader.GetString(10);
                anexo23_e.carnet_pasaporte = sqlite_datareader.GetString(11);
                anexo23_e.condicion_migratoria = sqlite_datareader.GetString(12);
                anexo23_e.correo = sqlite_datareader.GetString(13);
                anexo23_e.celular = sqlite_datareader.GetString(14);
                anexo23_e.nombre_apoderado = sqlite_datareader.GetString(15);
                anexo23_e.sexo_apoderado = sqlite_datareader.GetString(16);
                anexo23_e.lugar_nacimineto_municipio_apoderado = sqlite_datareader.GetString(17);
                anexo23_e.lugar_nacimineto_provincia_apoderado = sqlite_datareader.GetString(18);
                anexo23_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(19);
                anexo23_e.estado_civil_apoderado = sqlite_datareader.GetString(20);
                anexo23_e.ciudadania_apoderado = sqlite_datareader.GetString(21);
                anexo23_e.ocupacion_apoderado = sqlite_datareader.GetString(22);
                anexo23_e.direccion_apoderado = sqlite_datareader.GetString(23);
                anexo23_e.carnet_pasaporte_apoderado = sqlite_datareader.GetString(24);
                anexo23_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(25);
                anexo23_e.direccion_vivienda = sqlite_datareader.GetString(26);
                anexo23_e.clausula = sqlite_datareader.GetString(27);
                list.Add(anexo23_e);
            }
            
            return list;
        }
    }
}