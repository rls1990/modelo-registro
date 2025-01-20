using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo28_m
    {
        private SQLiteConnection connection;

        public Anexo28_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo28_e anexo28_e)
        {
            string[] columns = new string[] { "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "especificar_causa_representante", "despacho_equipaje", "numero_contenedor", "bl", "total", "numeracion", "total_kg", "id" };
            object[] values = new object[] { anexo28_e.nombre_poderante, anexo28_e.sexo_poderante, anexo28_e.lugar_nacimiento_municipio_poderante, anexo28_e.lugar_nacimiento_provincia_poderante, anexo28_e.fecha_nacimineto_poderante, anexo28_e.estado_civil_poderante, anexo28_e.ciudadania_poderante, anexo28_e.ocupacion_poderante, anexo28_e.direccion_particular_poderante, anexo28_e.carne_pasaporte_poderante, anexo28_e.condicion_migratoria_poderante, anexo28_e.correo_poderante, anexo28_e.celular_poderante, anexo28_e.nombre_apoderado, anexo28_e.sexo_apoderado, anexo28_e.lugar_nacimiento_municipio_apoderado, anexo28_e.lugar_nacimiento_provincia_apoderado, anexo28_e.fecha_nacimineto_apoderado, anexo28_e.estado_civil_apoderado, anexo28_e.ciudadania_apoderado, anexo28_e.ocupacion_apoderado, anexo28_e.direccion_particular_apoderado, anexo28_e.carne_pasaporte_apoderado, anexo28_e.condicion_migratoria_apoderado, anexo28_e.especificar_causa_representante, anexo28_e.despacho_equipaje, anexo28_e.numero_contenedor, anexo28_e.bl, anexo28_e.total, anexo28_e.numeracion, anexo28_e.total_kg, anexo28_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo28 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo28_e anexo28_e)
        {
            string[] columns = new string[] { "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "especificar_causa_representante", "despacho_equipaje", "numero_contenedor", "bl", "total", "numeracion", "total_kg", "id" };
            object[] values = new object[] { anexo28_e.nombre_poderante, anexo28_e.sexo_poderante, anexo28_e.lugar_nacimiento_municipio_poderante, anexo28_e.lugar_nacimiento_provincia_poderante, anexo28_e.fecha_nacimineto_poderante, anexo28_e.estado_civil_poderante, anexo28_e.ciudadania_poderante, anexo28_e.ocupacion_poderante, anexo28_e.direccion_particular_poderante, anexo28_e.carne_pasaporte_poderante, anexo28_e.condicion_migratoria_poderante, anexo28_e.correo_poderante, anexo28_e.celular_poderante, anexo28_e.nombre_apoderado, anexo28_e.sexo_apoderado, anexo28_e.lugar_nacimiento_municipio_apoderado, anexo28_e.lugar_nacimiento_provincia_apoderado, anexo28_e.fecha_nacimineto_apoderado, anexo28_e.estado_civil_apoderado, anexo28_e.ciudadania_apoderado, anexo28_e.ocupacion_apoderado, anexo28_e.direccion_particular_apoderado, anexo28_e.carne_pasaporte_apoderado, anexo28_e.condicion_migratoria_apoderado, anexo28_e.especificar_causa_representante, anexo28_e.despacho_equipaje, anexo28_e.numero_contenedor, anexo28_e.bl, anexo28_e.total, anexo28_e.numeracion, anexo28_e.total_kg, anexo28_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo28 SET {data} WHERE id = {anexo28_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo28 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo28_e> list()
        {
            List<Anexo28_e> list = new List<Anexo28_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo28";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo28_e anexo28_e = new Anexo28_e();
                anexo28_e.fecha_solicitud = sqlite_datareader.GetString(0);
                anexo28_e.nombre_poderante = sqlite_datareader.GetString(1);
                anexo28_e.sexo_poderante = sqlite_datareader.GetString(2);
                anexo28_e.lugar_nacimiento_municipio_poderante = sqlite_datareader.GetString(3);
                anexo28_e.lugar_nacimiento_provincia_poderante = sqlite_datareader.GetString(4);
                anexo28_e.fecha_nacimineto_poderante = sqlite_datareader.GetString(5);
                anexo28_e.estado_civil_poderante = sqlite_datareader.GetString(6);
                anexo28_e.ciudadania_poderante = sqlite_datareader.GetString(7);
                anexo28_e.ocupacion_poderante = sqlite_datareader.GetString(8);
                anexo28_e.direccion_particular_poderante = sqlite_datareader.GetString(9);
                anexo28_e.carne_pasaporte_poderante = sqlite_datareader.GetString(10);
                anexo28_e.condicion_migratoria_poderante = sqlite_datareader.GetString(11);
                anexo28_e.correo_poderante = sqlite_datareader.GetString(12);
                anexo28_e.celular_poderante = sqlite_datareader.GetString(13);
                anexo28_e.nombre_apoderado = sqlite_datareader.GetString(14);
                anexo28_e.sexo_apoderado = sqlite_datareader.GetString(15);
                anexo28_e.lugar_nacimiento_municipio_apoderado = sqlite_datareader.GetString(16);
                anexo28_e.lugar_nacimiento_provincia_apoderado = sqlite_datareader.GetString(17);
                anexo28_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(18);
                anexo28_e.estado_civil_apoderado = sqlite_datareader.GetString(19);
                anexo28_e.ciudadania_apoderado = sqlite_datareader.GetString(20);
                anexo28_e.ocupacion_apoderado = sqlite_datareader.GetString(21);
                anexo28_e.direccion_particular_apoderado = sqlite_datareader.GetString(22);
                anexo28_e.carne_pasaporte_apoderado = sqlite_datareader.GetString(23);
                anexo28_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(24);
                anexo28_e.especificar_causa_representante = sqlite_datareader.GetString(25);
                anexo28_e.despacho_equipaje = sqlite_datareader.GetString(26);
                anexo28_e.numero_contenedor = sqlite_datareader.GetString(27);
                anexo28_e.bl = sqlite_datareader.GetString(28);
                anexo28_e.total = sqlite_datareader.GetString(29);
                anexo28_e.numeracion = sqlite_datareader.GetString(30);
                anexo28_e.total_kg = sqlite_datareader.GetString(31);
                anexo28_e.id = sqlite_datareader.GetInt32(32);
                list.Add(anexo28_e);
            }
            
            return list;
        }
    }
}