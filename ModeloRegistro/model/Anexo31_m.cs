using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo31_m
    {
        private SQLiteConnection connection;

        public Anexo31_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo31_e anexo31_e)
        {
            string[] columns = new string[] { "nombre_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "registro_estado_civil_poderante", "tomo_poderante", "folio_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "nombre_apellido_padres_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "registro_estado_civil_apoderado", "tomo_apoderado", "folio_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "nombre_apellido_padres_apoderado", "condicion_migratoria_apoderado", "clausula", "id" };
            object[] values = new object[] { anexo31_e.nombre_poderante, anexo31_e.lugar_nacimiento_municipio_poderante, anexo31_e.lugar_nacimiento_provincia_poderante, anexo31_e.fecha_nacimineto_poderante, anexo31_e.registro_estado_civil_poderante, anexo31_e.tomo_poderante, anexo31_e.folio_poderante, anexo31_e.estado_civil_poderante, anexo31_e.ciudadania_poderante, anexo31_e.ocupacion_poderante, anexo31_e.direccion_particular_poderante, anexo31_e.carne_pasaporte_poderante, anexo31_e.nombre_apellido_padres_poderante, anexo31_e.condicion_migratoria_poderante, anexo31_e.correo_poderante, anexo31_e.celular_poderante, anexo31_e.nombre_apoderado, anexo31_e.lugar_nacimiento_municipio_apoderado, anexo31_e.lugar_nacimiento_provincia_apoderado, anexo31_e.fecha_nacimineto_apoderado, anexo31_e.registro_estado_civil_apoderado, anexo31_e.tomo_apoderado, anexo31_e.folio_apoderado, anexo31_e.estado_civil_apoderado, anexo31_e.ciudadania_apoderado, anexo31_e.ocupacion_apoderado, anexo31_e.direccion_particular_apoderado, anexo31_e.carne_pasaporte_apoderado, anexo31_e.nombre_apellido_padres_apoderado, anexo31_e.condicion_migratoria_apoderado, anexo31_e.clausula, anexo31_e.id };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo31 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo31_e anexo31_e)
        {
            string[] columns = new string[] { "nombre_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "registro_estado_civil_poderante", "tomo_poderante", "folio_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "nombre_apellido_padres_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "registro_estado_civil_apoderado", "tomo_apoderado", "folio_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "nombre_apellido_padres_apoderado", "condicion_migratoria_apoderado", "clausula", "id" };
            object[] values = new object[] { anexo31_e.nombre_poderante, anexo31_e.lugar_nacimiento_municipio_poderante, anexo31_e.lugar_nacimiento_provincia_poderante, anexo31_e.fecha_nacimineto_poderante, anexo31_e.registro_estado_civil_poderante, anexo31_e.tomo_poderante, anexo31_e.folio_poderante, anexo31_e.estado_civil_poderante, anexo31_e.ciudadania_poderante, anexo31_e.ocupacion_poderante, anexo31_e.direccion_particular_poderante, anexo31_e.carne_pasaporte_poderante, anexo31_e.nombre_apellido_padres_poderante, anexo31_e.condicion_migratoria_poderante, anexo31_e.correo_poderante, anexo31_e.celular_poderante, anexo31_e.nombre_apoderado, anexo31_e.lugar_nacimiento_municipio_apoderado, anexo31_e.lugar_nacimiento_provincia_apoderado, anexo31_e.fecha_nacimineto_apoderado, anexo31_e.registro_estado_civil_apoderado, anexo31_e.tomo_apoderado, anexo31_e.folio_apoderado, anexo31_e.estado_civil_apoderado, anexo31_e.ciudadania_apoderado, anexo31_e.ocupacion_apoderado, anexo31_e.direccion_particular_apoderado, anexo31_e.carne_pasaporte_apoderado, anexo31_e.nombre_apellido_padres_apoderado, anexo31_e.condicion_migratoria_apoderado, anexo31_e.clausula, anexo31_e.id };

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

            sqlite_cmd.CommandText = $"UPDATE anexo31 SET {data} WHERE id = {anexo31_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo31 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo31_e> list()
        {
            List<Anexo31_e> list = new List<Anexo31_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo31";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo31_e anexo31_e = new Anexo31_e();
                anexo31_e.fecha_solicitud = sqlite_datareader.GetString(0);
                anexo31_e.nombre_poderante = sqlite_datareader.GetString(1);
                anexo31_e.lugar_nacimiento_municipio_poderante = sqlite_datareader.GetString(2);
                anexo31_e.lugar_nacimiento_provincia_poderante = sqlite_datareader.GetString(3);
                anexo31_e.fecha_nacimineto_poderante = sqlite_datareader.GetString(4);
                anexo31_e.registro_estado_civil_poderante = sqlite_datareader.GetString(5);
                anexo31_e.tomo_poderante = sqlite_datareader.GetString(6);
                anexo31_e.folio_poderante = sqlite_datareader.GetString(7);
                anexo31_e.estado_civil_poderante = sqlite_datareader.GetString(8);
                anexo31_e.ciudadania_poderante = sqlite_datareader.GetString(9);
                anexo31_e.ocupacion_poderante = sqlite_datareader.GetString(10);
                anexo31_e.direccion_particular_poderante = sqlite_datareader.GetString(11);
                anexo31_e.carne_pasaporte_poderante = sqlite_datareader.GetString(12);
                anexo31_e.nombre_apellido_padres_poderante = sqlite_datareader.GetString(13);
                anexo31_e.condicion_migratoria_poderante = sqlite_datareader.GetString(14);
                anexo31_e.correo_poderante = sqlite_datareader.GetString(15);
                anexo31_e.celular_poderante = sqlite_datareader.GetString(16);
                anexo31_e.nombre_apoderado = sqlite_datareader.GetString(17);
                anexo31_e.lugar_nacimiento_municipio_apoderado = sqlite_datareader.GetString(18);
                anexo31_e.lugar_nacimiento_provincia_apoderado = sqlite_datareader.GetString(19);
                anexo31_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(20);
                anexo31_e.registro_estado_civil_apoderado = sqlite_datareader.GetString(21);
                anexo31_e.tomo_apoderado = sqlite_datareader.GetString(22);
                anexo31_e.folio_apoderado = sqlite_datareader.GetString(23);
                anexo31_e.estado_civil_apoderado = sqlite_datareader.GetString(24);
                anexo31_e.ciudadania_apoderado = sqlite_datareader.GetString(25);
                anexo31_e.ocupacion_apoderado = sqlite_datareader.GetString(26);
                anexo31_e.direccion_particular_apoderado = sqlite_datareader.GetString(27);
                anexo31_e.carne_pasaporte_apoderado = sqlite_datareader.GetString(28);
                anexo31_e.nombre_apellido_padres_apoderado = sqlite_datareader.GetString(29);
                anexo31_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(30);
                anexo31_e.clausula = sqlite_datareader.GetString(31);
                anexo31_e.id = sqlite_datareader.GetInt32(32);
                list.Add(anexo31_e);
            }
            
            return list;
        }
    }
}