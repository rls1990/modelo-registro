using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo26_m
    {
        private SQLiteConnection connection;

        public Anexo26_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo26_e anexo26_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_contrayente", "sexo_contrayente", "lugar_nacimiento_municipio_contrayente", "lugar_nacimiento_provincia_contrayente", "fecha_nacimineto_contrayente", "estado_civil_contrayente", "ciudadania_contrayente", "ocupacion_contrayente", "direccion_particular_contrayente", "carne_pasaporte_contrayente", "condicion_migratoria_contrayente", "fecha_celebracion", "tomo", "folio", "registro_civil_municipio", "patria_potestad", "nombre_apellido_menor", "pension_alimenticia", "regimen_comunicacion" };
            object[] values = new object[] { anexo26_e.fecha_solicitud, anexo26_e.nombre_poderante, anexo26_e.sexo_poderante, anexo26_e.lugar_nacimiento_municipio_poderante, anexo26_e.lugar_nacimiento_provincia_poderante, anexo26_e.fecha_nacimineto_poderante, anexo26_e.estado_civil_poderante, anexo26_e.ciudadania_poderante, anexo26_e.ocupacion_poderante, anexo26_e.direccion_particular_poderante, anexo26_e.carne_pasaporte_poderante, anexo26_e.condicion_migratoria_poderante, anexo26_e.correo_poderante, anexo26_e.celular_poderante, anexo26_e.nombre_apoderado, anexo26_e.sexo_apoderado, anexo26_e.lugar_nacimiento_municipio_apoderado, anexo26_e.lugar_nacimiento_provincia_apoderado, anexo26_e.fecha_nacimineto_apoderado, anexo26_e.estado_civil_apoderado, anexo26_e.ciudadania_apoderado, anexo26_e.ocupacion_apoderado, anexo26_e.direccion_particular_apoderado, anexo26_e.carne_pasaporte_apoderado, anexo26_e.condicion_migratoria_apoderado, anexo26_e.nombre_contrayente, anexo26_e.sexo_contrayente, anexo26_e.lugar_nacimiento_municipio_contrayente, anexo26_e.lugar_nacimiento_provincia_contrayente, anexo26_e.fecha_nacimineto_contrayente, anexo26_e.estado_civil_contrayente, anexo26_e.ciudadania_contrayente, anexo26_e.ocupacion_contrayente, anexo26_e.direccion_particular_contrayente, anexo26_e.carne_pasaporte_contrayente, anexo26_e.condicion_migratoria_contrayente, anexo26_e.fecha_celebracion, anexo26_e.tomo, anexo26_e.folio, anexo26_e.registro_civil_municipio, anexo26_e.patria_potestad, anexo26_e.nombre_apellido_menor, anexo26_e.pension_alimenticia, anexo26_e.regimen_comunicacion };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo26 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo26_e anexo26_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_poderante", "sexo_poderante", "lugar_nacimiento_municipio_poderante", "lugar_nacimiento_provincia_poderante", "fecha_nacimineto_poderante", "estado_civil_poderante", "ciudadania_poderante", "ocupacion_poderante", "direccion_particular_poderante", "carne_pasaporte_poderante", "condicion_migratoria_poderante", "correo_poderante", "celular_poderante", "nombre_apoderado", "sexo_apoderado", "lugar_nacimiento_municipio_apoderado", "lugar_nacimiento_provincia_apoderado", "fecha_nacimineto_apoderado", "estado_civil_apoderado", "ciudadania_apoderado", "ocupacion_apoderado", "direccion_particular_apoderado", "carne_pasaporte_apoderado", "condicion_migratoria_apoderado", "nombre_contrayente", "sexo_contrayente", "lugar_nacimiento_municipio_contrayente", "lugar_nacimiento_provincia_contrayente", "fecha_nacimineto_contrayente", "estado_civil_contrayente", "ciudadania_contrayente", "ocupacion_contrayente", "direccion_particular_contrayente", "carne_pasaporte_contrayente", "condicion_migratoria_contrayente", "fecha_celebracion", "tomo", "folio", "registro_civil_municipio", "patria_potestad", "nombre_apellido_menor", "pension_alimenticia", "regimen_comunicacion" };
            object[] values = new object[] { anexo26_e.fecha_solicitud, anexo26_e.nombre_poderante, anexo26_e.sexo_poderante, anexo26_e.lugar_nacimiento_municipio_poderante, anexo26_e.lugar_nacimiento_provincia_poderante, anexo26_e.fecha_nacimineto_poderante, anexo26_e.estado_civil_poderante, anexo26_e.ciudadania_poderante, anexo26_e.ocupacion_poderante, anexo26_e.direccion_particular_poderante, anexo26_e.carne_pasaporte_poderante, anexo26_e.condicion_migratoria_poderante, anexo26_e.correo_poderante, anexo26_e.celular_poderante, anexo26_e.nombre_apoderado, anexo26_e.sexo_apoderado, anexo26_e.lugar_nacimiento_municipio_apoderado, anexo26_e.lugar_nacimiento_provincia_apoderado, anexo26_e.fecha_nacimineto_apoderado, anexo26_e.estado_civil_apoderado, anexo26_e.ciudadania_apoderado, anexo26_e.ocupacion_apoderado, anexo26_e.direccion_particular_apoderado, anexo26_e.carne_pasaporte_apoderado, anexo26_e.condicion_migratoria_apoderado, anexo26_e.nombre_contrayente, anexo26_e.sexo_contrayente, anexo26_e.lugar_nacimiento_municipio_contrayente, anexo26_e.lugar_nacimiento_provincia_contrayente, anexo26_e.fecha_nacimineto_contrayente, anexo26_e.estado_civil_contrayente, anexo26_e.ciudadania_contrayente, anexo26_e.ocupacion_contrayente, anexo26_e.direccion_particular_contrayente, anexo26_e.carne_pasaporte_contrayente, anexo26_e.condicion_migratoria_contrayente, anexo26_e.fecha_celebracion, anexo26_e.tomo, anexo26_e.folio, anexo26_e.registro_civil_municipio, anexo26_e.patria_potestad, anexo26_e.nombre_apellido_menor, anexo26_e.pension_alimenticia, anexo26_e.regimen_comunicacion };

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

            sqlite_cmd.CommandText = $"UPDATE anexo26 SET {data} WHERE id = {anexo26_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo26 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo26_e> list()
        {
            List<Anexo26_e> list = new List<Anexo26_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo26";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo26_e anexo26_e = new Anexo26_e();
                anexo26_e.id = sqlite_datareader.GetInt32(0);
                anexo26_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo26_e.nombre_poderante = sqlite_datareader.GetString(2);
                anexo26_e.sexo_poderante = sqlite_datareader.GetString(3);
                anexo26_e.lugar_nacimiento_municipio_poderante = sqlite_datareader.GetString(4);
                anexo26_e.lugar_nacimiento_provincia_poderante = sqlite_datareader.GetString(5);
                anexo26_e.fecha_nacimineto_poderante = sqlite_datareader.GetString(6);
                anexo26_e.estado_civil_poderante = sqlite_datareader.GetString(7);
                anexo26_e.ciudadania_poderante = sqlite_datareader.GetString(8);
                anexo26_e.ocupacion_poderante = sqlite_datareader.GetString(9);
                anexo26_e.direccion_particular_poderante = sqlite_datareader.GetString(10);
                anexo26_e.carne_pasaporte_poderante = sqlite_datareader.GetString(11);
                anexo26_e.condicion_migratoria_poderante = sqlite_datareader.GetString(12);
                anexo26_e.correo_poderante = sqlite_datareader.GetString(13);
                anexo26_e.celular_poderante = sqlite_datareader.GetString(14);
                anexo26_e.nombre_apoderado = sqlite_datareader.GetString(15);
                anexo26_e.sexo_apoderado = sqlite_datareader.GetString(16);
                anexo26_e.lugar_nacimiento_municipio_apoderado = sqlite_datareader.GetString(17);
                anexo26_e.lugar_nacimiento_provincia_apoderado = sqlite_datareader.GetString(18);
                anexo26_e.fecha_nacimineto_apoderado = sqlite_datareader.GetString(19);
                anexo26_e.estado_civil_apoderado = sqlite_datareader.GetString(20);
                anexo26_e.ciudadania_apoderado = sqlite_datareader.GetString(21);
                anexo26_e.ocupacion_apoderado = sqlite_datareader.GetString(22);
                anexo26_e.direccion_particular_apoderado = sqlite_datareader.GetString(23);
                anexo26_e.carne_pasaporte_apoderado = sqlite_datareader.GetString(24);
                anexo26_e.condicion_migratoria_apoderado = sqlite_datareader.GetString(25);
                anexo26_e.nombre_contrayente = sqlite_datareader.GetString(26);
                anexo26_e.sexo_contrayente = sqlite_datareader.GetString(27);
                anexo26_e.lugar_nacimiento_municipio_contrayente = sqlite_datareader.GetString(28);
                anexo26_e.lugar_nacimiento_provincia_contrayente = sqlite_datareader.GetString(29);
                anexo26_e.fecha_nacimineto_contrayente = sqlite_datareader.GetString(30);
                anexo26_e.estado_civil_contrayente = sqlite_datareader.GetString(31);
                anexo26_e.ciudadania_contrayente = sqlite_datareader.GetString(32);
                anexo26_e.ocupacion_contrayente = sqlite_datareader.GetString(33);
                anexo26_e.direccion_particular_contrayente = sqlite_datareader.GetString(34);
                anexo26_e.carne_pasaporte_contrayente = sqlite_datareader.GetString(35);
                anexo26_e.condicion_migratoria_contrayente = sqlite_datareader.GetString(36);
                anexo26_e.fecha_celebracion = sqlite_datareader.GetString(37);
                anexo26_e.tomo = sqlite_datareader.GetString(38);
                anexo26_e.folio = sqlite_datareader.GetString(39);
                anexo26_e.registro_civil_municipio = sqlite_datareader.GetString(40);
                anexo26_e.patria_potestad = sqlite_datareader.GetString(41);
                anexo26_e.nombre_apellido_menor = sqlite_datareader.GetString(42);
                anexo26_e.pension_alimenticia = sqlite_datareader.GetString(43);
                anexo26_e.regimen_comunicacion = sqlite_datareader.GetString(44);
                list.Add(anexo26_e);
            }
            
            return list;
        }
    }
}