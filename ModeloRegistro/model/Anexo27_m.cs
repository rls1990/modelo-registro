using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo27_m
    {
        private SQLiteConnection connection;

        public Anexo27_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo27_e anexo27_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_donatorio", "sexo_donatorio", "lugar_nacimiento_municipio_donatorio", "lugar_nacimiento_provincia_donatorio", "fecha_nacimineto_donatorio", "estado_civil_donatorio", "ciudadania_donatorio", "ocupacion_donatorio", "direccion_particular_donatorio", "carne_pasaporte_donatorio", "condicion_migratoria_donatorio", "direccion_vivienda" };
            object[] values = new object[] { anexo27_e.fecha_solicitud, anexo27_e.nombre_poderante, anexo27_e.sexo_poderante, anexo27_e.lugar_nacimiento_municipio_poderante, anexo27_e.lugar_nacimiento_provincia_poderante, anexo27_e.fecha_nacimineto_poderante, anexo27_e.estado_civil_poderante, anexo27_e.ciudadania_poderante, anexo27_e.ocupacion_poderante, anexo27_e.direccion_particular_poderante, anexo27_e.carne_pasaporte_poderante, anexo27_e.condicion_migratoria_poderante, anexo27_e.correo_poderante, anexo27_e.celular_poderante, anexo27_e.nombre_apoderado, anexo27_e.sexo_apoderado, anexo27_e.lugar_nacimiento_municipio_apoderado, anexo27_e.lugar_nacimiento_provincia_apoderado, anexo27_e.fecha_nacimineto_apoderado, anexo27_e.estado_civil_apoderado, anexo27_e.ciudadania_apoderado, anexo27_e.ocupacion_apoderado, anexo27_e.direccion_particular_apoderado, anexo27_e.carne_pasaporte_apoderado, anexo27_e.condicion_migratoria_apoderado, anexo27_e.nombre_donatorio, anexo27_e.sexo_donatorio, anexo27_e.lugar_nacimiento_municipio_donatorio, anexo27_e.lugar_nacimiento_provincia_donatorio, anexo27_e.fecha_nacimineto_donatorio, anexo27_e.estado_civil_donatorio, anexo27_e.ciudadania_donatorio, anexo27_e.ocupacion_donatorio, anexo27_e.direccion_particular_donatorio, anexo27_e.carne_pasaporte_donatorio, anexo27_e.condicion_migratoria_donatorio, anexo27_e.direccion_vivienda };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo27 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo27_e anexo27_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_donatorio", "sexo_donatorio", "lugar_nacimiento_municipio_donatorio", "lugar_nacimiento_provincia_donatorio", "fecha_nacimineto_donatorio", "estado_civil_donatorio", "ciudadania_donatorio", "ocupacion_donatorio", "direccion_particular_donatorio", "carne_pasaporte_donatorio", "condicion_migratoria_donatorio", "direccion_vivienda" };
            object[] values = new object[] { anexo27_e.fecha_solicitud, anexo27_e.nombre_poderante, anexo27_e.sexo_poderante, anexo27_e.lugar_nacimiento_municipio_poderante, anexo27_e.lugar_nacimiento_provincia_poderante, anexo27_e.fecha_nacimineto_poderante, anexo27_e.estado_civil_poderante, anexo27_e.ciudadania_poderante, anexo27_e.ocupacion_poderante, anexo27_e.direccion_particular_poderante, anexo27_e.carne_pasaporte_poderante, anexo27_e.condicion_migratoria_poderante, anexo27_e.correo_poderante, anexo27_e.celular_poderante, anexo27_e.nombre_apoderado, anexo27_e.sexo_apoderado, anexo27_e.lugar_nacimiento_municipio_apoderado, anexo27_e.lugar_nacimiento_provincia_apoderado, anexo27_e.fecha_nacimineto_apoderado, anexo27_e.estado_civil_apoderado, anexo27_e.ciudadania_apoderado, anexo27_e.ocupacion_apoderado, anexo27_e.direccion_particular_apoderado, anexo27_e.carne_pasaporte_apoderado, anexo27_e.condicion_migratoria_apoderado, anexo27_e.nombre_donatorio, anexo27_e.sexo_donatorio, anexo27_e.lugar_nacimiento_municipio_donatorio, anexo27_e.lugar_nacimiento_provincia_donatorio, anexo27_e.fecha_nacimineto_donatorio, anexo27_e.estado_civil_donatorio, anexo27_e.ciudadania_donatorio, anexo27_e.ocupacion_donatorio, anexo27_e.direccion_particular_donatorio, anexo27_e.carne_pasaporte_donatorio, anexo27_e.condicion_migratoria_donatorio, anexo27_e.direccion_vivienda };

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

            sqlite_cmd.CommandText = $"UPDATE anexo27 SET {data} WHERE id = {anexo27_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo27 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo27_e> list()
        {
            List<Anexo27_e> list = new List<Anexo27_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo27";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo27_e anexo27_e = new Anexo27_e();
                anexo27_e.id = sqlite_datareader.GetInt32(0);
                anexo27_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo27_e.nombre_poderante = sqlite_datareader.GetString(2);
                anexo27_e.sexo_poderante = sqlite_datareader.GetString(3);
                anexo27_e.lugar_nacimiento_municipio_poderante = sqlite_datareader.GetString(4);
                anexo27_e.lugar_nacimiento_provincia_poderante = sqlite_datareader.GetString(5);
                anexo27_e.fecha_nacimineto_poderante = sqlite_datareader.GetString(6);
                anexo27_e.estado_civil_poderante = sqlite_datareader.GetString(7);
                anexo27_e.ciudadania_poderante = sqlite_datareader.GetString(8);
                anexo27_e.ocupacion_poderante = sqlite_datareader.GetString(9);
                anexo27_e.direccion_particular_poderante = sqlite_datareader.GetString(10);
                anexo27_e.carne_pasaporte_poderante = sqlite_datareader.GetString(11);
                anexo27_e.condicion_migratoria_poderante = sqlite_datareader.GetString(12);
                anexo27_e.correo_poderante = sqlite_datareader.GetString(13);
                anexo27_e.celular_poderante = sqlite_datareader.GetString(14);
                anexo27_e.nombre_apoderado = sqlite_datareader.GetString(15);
                anexo27_e.sexo_apoderado = sqlite_datareader.GetString(16);
                anexo27_e.lugar_nacimiento_municipio_apoderado = sqlite_datareader.GetString(17);
                anexo27_e.lugar_nacimiento_provincia_apoderado = sqlite_datareader.GetString(18);
                anexo27_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(19);
                anexo27_e.estado_civil_apoderado = sqlite_datareader.GetString(20);
                anexo27_e.ciudadania_apoderado = sqlite_datareader.GetString(21);
                anexo27_e.ocupacion_apoderado = sqlite_datareader.GetString(22);
                anexo27_e.direccion_particular_apoderado = sqlite_datareader.GetString(23);
                anexo27_e.carne_pasaporte_apoderado = sqlite_datareader.GetString(24);
                anexo27_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(25);
                anexo27_e.nombre_donatorio = sqlite_datareader.GetString(26);
                anexo27_e.sexo_donatorio = sqlite_datareader.GetString(27);
                anexo27_e.lugar_nacimiento_municipio_donatorio = sqlite_datareader.GetString(28);
                anexo27_e.lugar_nacimiento_provincia_donatorio = sqlite_datareader.GetString(29);
                anexo27_e.fecha_nacimineto_donatorio = sqlite_datareader.GetString(30);
                anexo27_e.estado_civil_donatorio = sqlite_datareader.GetString(31);
                anexo27_e.ciudadania_donatorio = sqlite_datareader.GetString(32);
                anexo27_e.ocupacion_donatorio = sqlite_datareader.GetString(33);
                anexo27_e.direccion_particular_donatorio = sqlite_datareader.GetString(34);
                anexo27_e.carne_pasaporte_donatorio = sqlite_datareader.GetString(35);
                anexo27_e.condicion_migratoria_donatorio = sqlite_datareader.GetString(36);
                anexo27_e.direccion_vivienda = sqlite_datareader.GetString(37);
                list.Add(anexo27_e);
            }
            
            return list;
        }
    }
}