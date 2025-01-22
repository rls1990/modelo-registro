using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo13_m
    {
        private SQLiteConnection connection;

        public Anexo13_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo13_e anexo13_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_comparece", "no_pasaporte_comparece", "nombre_inscripcion", "m", "f", "primer_apellido_inscripcion", "segundo_apellido_inscripcion", "hora_nacimiento", "fecha_nacimineto", "referencia_territorio_registro_civil", "tomo_referencia_registral", "folio_referencia_registral", "nro_asiento", "lugar_nacimineto", "nombre_padre", "primer_apellido_padre", "segundo_apellido_padre", "ciudadania_padre", "natural_de_padre", "nro_pasaporte_padre", "domicilio_padre", "nombre_madre", "primer_apellido_madre", "segundo_apellido_madre", "ciudadania_madre", "natural_de_madre", "nro_pasaporte_madre", "domicilio_madre", "nombre_abuelo_paterno", "nombre_abuela_paterna", "nombre_abuelo_materno", "nombre_abuela_materna", "nombre_apellido_soltera_madre", "nombre_inscrito_pais_nacimineto", "inscripcion_practicada_en_virtud_de", "observaciones" };
            object[] values = new object[] { anexo13_e.fecha_solicitud, anexo13_e.nombre_comparece, anexo13_e.no_pasaporte_comparece, anexo13_e.nombre_inscripcion, anexo13_e.m, anexo13_e.f, anexo13_e.primer_apellido_inscripcion, anexo13_e.segundo_apellido_inscripcion, anexo13_e.hora_nacimiento, anexo13_e.fecha_nacimineto, anexo13_e.referencia_territorio_registro_civil, anexo13_e.tomo_referencia_registral, anexo13_e.folio_referencia_registral, anexo13_e.nro_asiento, anexo13_e.lugar_nacimineto, anexo13_e.nombre_padre, anexo13_e.primer_apellido_padre, anexo13_e.segundo_apellido_padre, anexo13_e.ciudadania_padre, anexo13_e.natural_de_padre, anexo13_e.nro_pasaporte_padre, anexo13_e.domicilio_padre, anexo13_e.nombre_madre, anexo13_e.primer_apellido_madre, anexo13_e.segundo_apellido_madre, anexo13_e.ciudadania_madre, anexo13_e.natural_de_madre, anexo13_e.nro_pasaporte_madre, anexo13_e.domicilio_madre, anexo13_e.nombre_abuelo_paterno, anexo13_e.nombre_abuela_paterna, anexo13_e.nombre_abuelo_materno, anexo13_e.nombre_abuela_materna, anexo13_e.nombre_apellido_soltera_madre, anexo13_e.nombre_inscrito_pais_nacimineto, anexo13_e.inscripcion_practicada_en_virtud_de, anexo13_e.observaciones };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo13 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo13_e anexo13_e)
        {
            string[] columns = new string[] { "fecha_solicitud", "nombre_comparece", "no_pasaporte_comparece", "nombre_inscripcion", "m", "f", "primer_apellido_inscripcion", "segundo_apellido_inscripcion", "hora_nacimiento", "fecha_nacimineto", "referencia_territorio_registro_civil", "tomo_referencia_registral", "folio_referencia_registral", "nro_asiento", "lugar_nacimineto", "nombre_padre", "primer_apellido_padre", "segundo_apellido_padre", "ciudadania_padre", "natural_de_padre", "nro_pasaporte_padre", "domicilio_padre", "nombre_madre", "primer_apellido_madre", "segundo_apellido_madre", "ciudadania_madre", "natural_de_madre", "nro_pasaporte_madre", "domicilio_madre", "nombre_abuelo_paterno", "nombre_abuela_paterna", "nombre_abuelo_materno", "nombre_abuela_materna", "nombre_apellido_soltera_madre", "nombre_inscrito_pais_nacimineto", "inscripcion_practicada_en_virtud_de", "observaciones" };
            object[] values = new object[] { anexo13_e.fecha_solicitud, anexo13_e.nombre_comparece, anexo13_e.no_pasaporte_comparece, anexo13_e.nombre_inscripcion, anexo13_e.m, anexo13_e.f, anexo13_e.primer_apellido_inscripcion, anexo13_e.segundo_apellido_inscripcion, anexo13_e.hora_nacimiento, anexo13_e.fecha_nacimineto, anexo13_e.referencia_territorio_registro_civil, anexo13_e.tomo_referencia_registral, anexo13_e.folio_referencia_registral, anexo13_e.nro_asiento, anexo13_e.lugar_nacimineto, anexo13_e.nombre_padre, anexo13_e.primer_apellido_padre, anexo13_e.segundo_apellido_padre, anexo13_e.ciudadania_padre, anexo13_e.natural_de_padre, anexo13_e.nro_pasaporte_padre, anexo13_e.domicilio_padre, anexo13_e.nombre_madre, anexo13_e.primer_apellido_madre, anexo13_e.segundo_apellido_madre, anexo13_e.ciudadania_madre, anexo13_e.natural_de_madre, anexo13_e.nro_pasaporte_madre, anexo13_e.domicilio_madre, anexo13_e.nombre_abuelo_paterno, anexo13_e.nombre_abuela_paterna, anexo13_e.nombre_abuelo_materno, anexo13_e.nombre_abuela_materna, anexo13_e.nombre_apellido_soltera_madre, anexo13_e.nombre_inscrito_pais_nacimineto, anexo13_e.inscripcion_practicada_en_virtud_de, anexo13_e.observaciones };

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

            sqlite_cmd.CommandText = $"UPDATE anexo13 SET {data} WHERE id = {anexo13_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo13 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo13_e> list()
        {
            List<Anexo13_e> list = new List<Anexo13_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo13";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo13_e anexo13_e = new Anexo13_e();
                anexo13_e.id = sqlite_datareader.GetInt32(0);
                anexo13_e.fecha_solicitud = sqlite_datareader.GetString(1);
                anexo13_e.nombre_comparece = sqlite_datareader.GetString(2);
                anexo13_e.no_pasaporte_comparece = sqlite_datareader.GetString(3);
                anexo13_e.nombre_inscripcion = sqlite_datareader.GetString(4);
                anexo13_e.m = sqlite_datareader.GetString(5);
                anexo13_e.f = sqlite_datareader.GetString(6);
                anexo13_e.primer_apellido_inscripcion = sqlite_datareader.GetString(7);
                anexo13_e.segundo_apellido_inscripcion = sqlite_datareader.GetString(8);
                anexo13_e.hora_nacimiento = sqlite_datareader.GetString(9);
                anexo13_e.fecha_nacimineto = sqlite_datareader.GetString(10);
                anexo13_e.referencia_territorio_registro_civil = sqlite_datareader.GetString(11);
                anexo13_e.tomo_referencia_registral = sqlite_datareader.GetString(12);
                anexo13_e.folio_referencia_registral = sqlite_datareader.GetString(13);
                anexo13_e.nro_asiento = sqlite_datareader.GetString(14);
                anexo13_e.lugar_nacimineto = sqlite_datareader.GetString(15);
                anexo13_e.nombre_padre = sqlite_datareader.GetString(16);
                anexo13_e.primer_apellido_padre = sqlite_datareader.GetString(17);
                anexo13_e.segundo_apellido_padre = sqlite_datareader.GetString(18);
                anexo13_e.ciudadania_padre = sqlite_datareader.GetString(19);
                anexo13_e.natural_de_padre = sqlite_datareader.GetString(20);
                anexo13_e.nro_pasaporte_padre = sqlite_datareader.GetString(21);
                anexo13_e.domicilio_padre = sqlite_datareader.GetString(22);
                anexo13_e.nombre_madre = sqlite_datareader.GetString(23);
                anexo13_e.primer_apellido_madre = sqlite_datareader.GetString(24);
                anexo13_e.segundo_apellido_madre = sqlite_datareader.GetString(25);
                anexo13_e.ciudadania_madre = sqlite_datareader.GetString(26);
                anexo13_e.natural_de_madre = sqlite_datareader.GetString(27);
                anexo13_e.nro_pasaporte_madre = sqlite_datareader.GetString(28);
                anexo13_e.domicilio_madre = sqlite_datareader.GetString(29);
                anexo13_e.nombre_abuelo_paterno = sqlite_datareader.GetString(30);
                anexo13_e.nombre_abuela_paterna = sqlite_datareader.GetString(31);
                anexo13_e.nombre_abuelo_materno = sqlite_datareader.GetString(32);
                anexo13_e.nombre_abuela_materna = sqlite_datareader.GetString(33);
                anexo13_e.nombre_apellido_soltera_madre = sqlite_datareader.GetString(34);
                anexo13_e.nombre_inscrito_pais_nacimineto = sqlite_datareader.GetString(35);
                anexo13_e.inscripcion_practicada_en_virtud_de = sqlite_datareader.GetString(36);
                anexo13_e.observaciones = sqlite_datareader.GetString(37);
                list.Add(anexo13_e);
            }
            
            return list;
        }
    }
}