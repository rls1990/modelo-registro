using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo24_m
    {
        private SQLiteConnection connection;

        public Anexo24_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo24_e anexo24_e)
        {
            string[] columns = new string[] { "nombre", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "nombre_apellido_padres", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "marca", "modelo", "anno", "color", "nro_motor", "nro_chasis", "matricula", "id" };
            object[] values = new object[] { anexo24_e.nombre, anexo24_e.lugar_nacimineto_municipio, anexo24_e.lugar_nacimineto_provincia, anexo24_e.fecha_nacimineto, anexo24_e.estado_civil, anexo24_e.ciudadania, anexo24_e.ocupacion, anexo24_e.direccion, anexo24_e.carnet_pasaporte, anexo24_e.nombre_apellido_padres, anexo24_e.condicion_migratoria, anexo24_e.correo, anexo24_e.celular, anexo24_e.nombre_apoderado, anexo24_e.lugar_nacimineto_municipio_apoderado, anexo24_e.lugar_nacimineto_provincia_apoderado, anexo24_e.fecha_nacimineto_apoderado, anexo24_e.estado_civil_apoderado, anexo24_e.ciudadania_apoderado, anexo24_e.ocupacion_apoderado, anexo24_e.direccion_apoderado, anexo24_e.carnet_pasaporte_apoderado, anexo24_e.condicion_migratoria_apoderado, anexo24_e.marca, anexo24_e.modelo, anexo24_e.anno, anexo24_e.color, anexo24_e.nro_motor, anexo24_e.nro_chasis, anexo24_e.matricula, anexo24_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo24 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo24_e anexo24_e)
        {
            string[] columns = new string[] { "nombre", "lugar_nacimineto_municipio", "lugar_nacimineto_provincia", "fecha_nacimineto", "estado_civil", "ciudadania", "ocupacion", "direccion", "carnet_pasaporte", "nombre_apellido_padres", "condicion_migratoria", "correo", "celular", "nombre_apoderado", "lugar_nacimineto_municipio_apoderado", "lugar_nacimineto_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_apoderado", "carnet_pasaporte_apoderado", "condicion_migratoria_apoderado", "marca", "modelo", "anno", "color", "nro_motor", "nro_chasis", "matricula", "id" };
            object[] values = new object[] { anexo24_e.nombre, anexo24_e.lugar_nacimineto_municipio, anexo24_e.lugar_nacimineto_provincia, anexo24_e.fecha_nacimineto, anexo24_e.estado_civil, anexo24_e.ciudadania, anexo24_e.ocupacion, anexo24_e.direccion, anexo24_e.carnet_pasaporte, anexo24_e.nombre_apellido_padres, anexo24_e.condicion_migratoria, anexo24_e.correo, anexo24_e.celular, anexo24_e.nombre_apoderado, anexo24_e.lugar_nacimineto_municipio_apoderado, anexo24_e.lugar_nacimineto_provincia_apoderado, anexo24_e.fecha_nacimineto_apoderado, anexo24_e.estado_civil_apoderado, anexo24_e.ciudadania_apoderado, anexo24_e.ocupacion_apoderado, anexo24_e.direccion_apoderado, anexo24_e.carnet_pasaporte_apoderado, anexo24_e.condicion_migratoria_apoderado, anexo24_e.marca, anexo24_e.modelo, anexo24_e.anno, anexo24_e.color, anexo24_e.nro_motor, anexo24_e.nro_chasis, anexo24_e.matricula, anexo24_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo24 SET {data} WHERE id = {anexo24_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo24 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo24_e> list()
        {
            List<Anexo24_e> list = new List<Anexo24_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo24";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo24_e anexo24_e = new Anexo24_e();
                anexo24_e.fecha_solicitud = sqlite_datareader.GetString(0);
                anexo24_e.nombre = sqlite_datareader.GetString(1);
                anexo24_e.lugar_nacimineto_municipio = sqlite_datareader.GetString(2);
                anexo24_e.lugar_nacimineto_provincia = sqlite_datareader.GetString(3);
                anexo24_e.fecha_nacimineto = sqlite_datareader.GetString(4);
                anexo24_e.estado_civil = sqlite_datareader.GetString(5);
                anexo24_e.ciudadania = sqlite_datareader.GetString(6);
                anexo24_e.ocupacion = sqlite_datareader.GetString(7);
                anexo24_e.direccion = sqlite_datareader.GetString(8);
                anexo24_e.carnet_pasaporte = sqlite_datareader.GetString(9);
                anexo24_e.nombre_apellido_padres = sqlite_datareader.GetString(10);
                anexo24_e.condicion_migratoria = sqlite_datareader.GetString(11);
                anexo24_e.correo = sqlite_datareader.GetString(12);
                anexo24_e.celular = sqlite_datareader.GetString(13);
                anexo24_e.nombre_apoderado = sqlite_datareader.GetString(14);
                anexo24_e.lugar_nacimineto_municipio_apoderado = sqlite_datareader.GetString(15);
                anexo24_e.lugar_nacimineto_provincia_apoderado = sqlite_datareader.GetString(16);
                anexo24_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(17);
                anexo24_e.estado_civil_apoderado = sqlite_datareader.GetString(18);
                anexo24_e.ciudadania_apoderado = sqlite_datareader.GetString(19);
                anexo24_e.ocupacion_apoderado = sqlite_datareader.GetString(20);
                anexo24_e.direccion_apoderado = sqlite_datareader.GetString(21);
                anexo24_e.carnet_pasaporte_apoderado = sqlite_datareader.GetString(22);
                anexo24_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(23);
                anexo24_e.marca = sqlite_datareader.GetString(24);
                anexo24_e.modelo = sqlite_datareader.GetString(25);
                anexo24_e.anno = sqlite_datareader.GetString(26);
                anexo24_e.color = sqlite_datareader.GetString(27);
                anexo24_e.nro_motor = sqlite_datareader.GetString(28);
                anexo24_e.nro_chasis = sqlite_datareader.GetString(29);
                anexo24_e.matricula = sqlite_datareader.GetString(30);
                anexo24_e.id = sqlite_datareader.GetInt32(31);
                list.Add(anexo24_e);
            }
            
            return list;
        }
    }
}