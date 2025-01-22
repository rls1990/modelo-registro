using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo25_m
    {
        private SQLiteConnection connection;

        public Anexo25_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo25_e anexo25_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_contrallente", "sexo_contrallente", "lugar_nacimiento_municipio_contrallente", "lugar_nacimiento_provincia_contrallente", "fecha_nacimineto_contrallente", "estado_civil_contrallente", "ciudadania_contrallente", "ocupacion_contrallente", "direccion_particular_contrallente", "carne_pasaporte_contrallente", "padres_contrallente", "nivel_escolaridad_contrallente", "condicion_migratoria_contrallente" };
            object[] values = new object[] { anexo25_e.fecha_solicitud, anexo25_e.nombre_poderante, anexo25_e.sexo_poderante, anexo25_e.lugar_nacimiento_municipio_poderante, anexo25_e.lugar_nacimiento_provincia_poderante, anexo25_e.fecha_nacimineto_poderante, anexo25_e.estado_civil_poderante, anexo25_e.ciudadania_poderante, anexo25_e.ocupacion_poderante, anexo25_e.direccion_particular_poderante, anexo25_e.carne_pasaporte_poderante, anexo25_e.condicion_migratoria_poderante, anexo25_e.correo_poderante, anexo25_e.celular_poderante, anexo25_e.nombre_apoderado, anexo25_e.sexo_apoderado, anexo25_e.lugar_nacimiento_municipio_apoderado, anexo25_e.lugar_nacimiento_provincia_apoderado, anexo25_e.fecha_nacimineto_apoderado, anexo25_e.estado_civil_apoderado, anexo25_e.ciudadania_apoderado, anexo25_e.ocupacion_apoderado, anexo25_e.direccion_particular_apoderado, anexo25_e.carne_pasaporte_apoderado, anexo25_e.condicion_migratoria_apoderado, anexo25_e.nombre_contrallente, anexo25_e.sexo_contrallente, anexo25_e.lugar_nacimiento_municipio_contrallente, anexo25_e.lugar_nacimiento_provincia_contrallente, anexo25_e.fecha_nacimineto_contrallente, anexo25_e.estado_civil_contrallente, anexo25_e.ciudadania_contrallente, anexo25_e.ocupacion_contrallente, anexo25_e.direccion_particular_contrallente, anexo25_e.carne_pasaporte_contrallente, anexo25_e.padres_contrallente, anexo25_e.nivel_escolaridad_contrallente, anexo25_e.condicion_migratoria_contrallente };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo25 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo25_e anexo25_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_contrallente", "sexo_contrallente", "lugar_nacimiento_municipio_contrallente", "lugar_nacimiento_provincia_contrallente", "fecha_nacimineto_contrallente", "estado_civil_contrallente", "ciudadania_contrallente", "ocupacion_contrallente", "direccion_particular_contrallente", "carne_pasaporte_contrallente", "padres_contrallente", "nivel_escolaridad_contrallente", "condicion_migratoria_contrallente" };
            object[] values = new object[] { anexo25_e.fecha_solicitud, anexo25_e.nombre_poderante, anexo25_e.sexo_poderante, anexo25_e.lugar_nacimiento_municipio_poderante, anexo25_e.lugar_nacimiento_provincia_poderante, anexo25_e.fecha_nacimineto_poderante, anexo25_e.estado_civil_poderante, anexo25_e.ciudadania_poderante, anexo25_e.ocupacion_poderante, anexo25_e.direccion_particular_poderante, anexo25_e.carne_pasaporte_poderante, anexo25_e.condicion_migratoria_poderante, anexo25_e.correo_poderante, anexo25_e.celular_poderante, anexo25_e.nombre_apoderado, anexo25_e.sexo_apoderado, anexo25_e.lugar_nacimiento_municipio_apoderado, anexo25_e.lugar_nacimiento_provincia_apoderado, anexo25_e.fecha_nacimineto_apoderado, anexo25_e.estado_civil_apoderado, anexo25_e.ciudadania_apoderado, anexo25_e.ocupacion_apoderado, anexo25_e.direccion_particular_apoderado, anexo25_e.carne_pasaporte_apoderado, anexo25_e.condicion_migratoria_apoderado, anexo25_e.nombre_contrallente, anexo25_e.sexo_contrallente, anexo25_e.lugar_nacimiento_municipio_contrallente, anexo25_e.lugar_nacimiento_provincia_contrallente, anexo25_e.fecha_nacimineto_contrallente, anexo25_e.estado_civil_contrallente, anexo25_e.ciudadania_contrallente, anexo25_e.ocupacion_contrallente, anexo25_e.direccion_particular_contrallente, anexo25_e.carne_pasaporte_contrallente, anexo25_e.padres_contrallente, anexo25_e.nivel_escolaridad_contrallente, anexo25_e.condicion_migratoria_contrallente };

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

            sqlite_cmd.CommandText = $"UPDATE anexo25 SET {data} WHERE id = {anexo25_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo25 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo25_e> list()
        {
            List<Anexo25_e> list = new List<Anexo25_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo25";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo25_e anexo25_e = new Anexo25_e();
                anexo25_e.id = sqlite_datareader.GetInt32(0);
                anexo25_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo25_e.nombre_poderante = sqlite_datareader.GetString(2);
                anexo25_e.sexo_poderante = sqlite_datareader.GetString(3);
                anexo25_e.lugar_nacimiento_municipio_poderante = sqlite_datareader.GetString(4);
                anexo25_e.lugar_nacimiento_provincia_poderante = sqlite_datareader.GetString(5);
                anexo25_e.fecha_nacimineto_poderante = sqlite_datareader.GetString(6);
                anexo25_e.estado_civil_poderante = sqlite_datareader.GetString(7);
                anexo25_e.ciudadania_poderante = sqlite_datareader.GetString(8);
                anexo25_e.ocupacion_poderante = sqlite_datareader.GetString(9);
                anexo25_e.direccion_particular_poderante = sqlite_datareader.GetString(10);
                anexo25_e.carne_pasaporte_poderante = sqlite_datareader.GetString(11);
                anexo25_e.condicion_migratoria_poderante = sqlite_datareader.GetString(12);
                anexo25_e.correo_poderante = sqlite_datareader.GetString(13);
                anexo25_e.celular_poderante = sqlite_datareader.GetString(14);
                anexo25_e.nombre_apoderado = sqlite_datareader.GetString(15);
                anexo25_e.sexo_apoderado = sqlite_datareader.GetString(16);
                anexo25_e.lugar_nacimiento_municipio_apoderado = sqlite_datareader.GetString(17);
                anexo25_e.lugar_nacimiento_provincia_apoderado = sqlite_datareader.GetString(18);
                anexo25_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(19);
                anexo25_e.estado_civil_apoderado = sqlite_datareader.GetString(20);
                anexo25_e.ciudadania_apoderado = sqlite_datareader.GetString(21);
                anexo25_e.ocupacion_apoderado = sqlite_datareader.GetString(22);
                anexo25_e.direccion_particular_apoderado = sqlite_datareader.GetString(23);
                anexo25_e.carne_pasaporte_apoderado = sqlite_datareader.GetString(24);
                anexo25_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(25);
                anexo25_e.nombre_contrallente = sqlite_datareader.GetString(26);
                anexo25_e.sexo_contrallente = sqlite_datareader.GetString(27);
                anexo25_e.lugar_nacimiento_municipio_contrallente = sqlite_datareader.GetString(28);
                anexo25_e.lugar_nacimiento_provincia_contrallente = sqlite_datareader.GetString(29);
                anexo25_e.fecha_nacimineto_contrallente = sqlite_datareader.GetString(30);
                anexo25_e.estado_civil_contrallente = sqlite_datareader.GetString(31);
                anexo25_e.ciudadania_contrallente = sqlite_datareader.GetString(32);
                anexo25_e.ocupacion_contrallente = sqlite_datareader.GetString(33);
                anexo25_e.direccion_particular_contrallente = sqlite_datareader.GetString(34);
                anexo25_e.carne_pasaporte_contrallente = sqlite_datareader.GetString(35);
                anexo25_e.padres_contrallente = sqlite_datareader.GetString(36);
                anexo25_e.nivel_escolaridad_contrallente = sqlite_datareader.GetString(37);
                anexo25_e.condicion_migratoria_contrallente = sqlite_datareader.GetString(38);
                list.Add(anexo25_e);
            }
            
            return list;
        }
    }
}