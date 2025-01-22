using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo15_m
    {
        private SQLiteConnection connection;

        public Anexo15_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo15_e anexo15_e)
        {
            string[] columns = new string[] { "nombre_fallecido", "m", "f", "primer_apellido_fallecido", "segundo_apellido_fallecido", "hora_fallecido", "fecha_fallecimineto", "lugar_nacimineto_fallecido", "municipio_provincia_pais_fallecido", "fecha_nacimiento", "pasaporte_fallecido", "edad_fallecido", "registro_civil_fallecido", "tomo_fallecido", "folio_fallecido", "estado_civil_fallecido", "ocupacion_fallecido", "padre_fallecido", "madre_fallecido", "domicilio_fallecido", "fecha_defuncion", "hora_defuncion", "lugar_fallecimiento", "causa_muerte_fallecimiento", "enfermedad_causa_fallecimiento", "nombre_medico_certifica_fallecimiento", "lugar_cepultura", "registro_civil", "tomo", "folio", "fecha_certificado", "nombre_apellido_solicita", "nro_pasaporte_carnet", "parentesco_fallecido", "direccion_solicita", "nombre_apellido_funcionario_consular" };
            object[] values = new object[] { anexo15_e.nombre_fallecido, anexo15_e.m, anexo15_e.f, anexo15_e.primer_apellido_fallecido, anexo15_e.segundo_apellido_fallecido, anexo15_e.hora_fallecido, anexo15_e.fecha_fallecimineto, anexo15_e.lugar_nacimineto_fallecido, anexo15_e.municipio_provincia_pais_fallecido, anexo15_e.fecha_nacimiento, anexo15_e.pasaporte_fallecido, anexo15_e.edad_fallecido, anexo15_e.registro_civil_fallecido, anexo15_e.tomo_fallecido, anexo15_e.folio_fallecido, anexo15_e.estado_civil_fallecido, anexo15_e.ocupacion_fallecido, anexo15_e.padre_fallecido, anexo15_e.madre_fallecido, anexo15_e.domicilio_fallecido, anexo15_e.fecha_defuncion, anexo15_e.hora_defuncion, anexo15_e.lugar_fallecimiento, anexo15_e.causa_muerte_fallecimiento, anexo15_e.enfermedad_causa_fallecimiento, anexo15_e.nombre_medico_certifica_fallecimiento, anexo15_e.lugar_cepultura, anexo15_e.registro_civil, anexo15_e.tomo, anexo15_e.folio, anexo15_e.fecha_certificado, anexo15_e.nombre_apellido_solicita, anexo15_e.nro_pasaporte_carnet, anexo15_e.parentesco_fallecido, anexo15_e.direccion_solicita, anexo15_e.nombre_apellido_funcionario_consular };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo15 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo15_e anexo15_e)
        {
            string[] columns = new string[] { "nombre_fallecido", "m", "f", "primer_apellido_fallecido", "segundo_apellido_fallecido", "hora_fallecido", "fecha_fallecimineto", "lugar_nacimineto_fallecido", "municipio_provincia_pais_fallecido", "fecha_nacimiento", "pasaporte_fallecido", "edad_fallecido", "registro_civil_fallecido", "tomo_fallecido", "folio_fallecido", "estado_civil_fallecido", "ocupacion_fallecido", "padre_fallecido", "madre_fallecido", "domicilio_fallecido", "fecha_defuncion", "hora_defuncion", "lugar_fallecimiento", "causa_muerte_fallecimiento", "enfermedad_causa_fallecimiento", "nombre_medico_certifica_fallecimiento", "lugar_cepultura", "registro_civil", "tomo", "folio", "fecha_certificado", "nombre_apellido_solicita", "nro_pasaporte_carnet", "parentesco_fallecido", "direccion_solicita", "nombre_apellido_funcionario_consular" };
            object[] values = new object[] { anexo15_e.nombre_fallecido, anexo15_e.m, anexo15_e.f, anexo15_e.primer_apellido_fallecido, anexo15_e.segundo_apellido_fallecido, anexo15_e.hora_fallecido, anexo15_e.fecha_fallecimineto, anexo15_e.lugar_nacimineto_fallecido, anexo15_e.municipio_provincia_pais_fallecido, anexo15_e.fecha_nacimiento, anexo15_e.pasaporte_fallecido, anexo15_e.edad_fallecido, anexo15_e.registro_civil_fallecido, anexo15_e.tomo_fallecido, anexo15_e.folio_fallecido, anexo15_e.estado_civil_fallecido, anexo15_e.ocupacion_fallecido, anexo15_e.padre_fallecido, anexo15_e.madre_fallecido, anexo15_e.domicilio_fallecido, anexo15_e.fecha_defuncion, anexo15_e.hora_defuncion, anexo15_e.lugar_fallecimiento, anexo15_e.causa_muerte_fallecimiento, anexo15_e.enfermedad_causa_fallecimiento, anexo15_e.nombre_medico_certifica_fallecimiento, anexo15_e.lugar_cepultura, anexo15_e.registro_civil, anexo15_e.tomo, anexo15_e.folio, anexo15_e.fecha_certificado, anexo15_e.nombre_apellido_solicita, anexo15_e.nro_pasaporte_carnet, anexo15_e.parentesco_fallecido, anexo15_e.direccion_solicita, anexo15_e.nombre_apellido_funcionario_consular };

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

            sqlite_cmd.CommandText = $"UPDATE anexo15 SET {data} WHERE id = {anexo15_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo15 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo15_e> list()
        {
            List<Anexo15_e> list = new List<Anexo15_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo15";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo15_e anexo15_e = new Anexo15_e();
                anexo15_e.id = sqlite_datareader.GetInt32(0);
                anexo15_e.nombre_fallecido = sqlite_datareader.GetString(1);
                anexo15_e.m = sqlite_datareader.GetString(2);
                anexo15_e.f = sqlite_datareader.GetString(3);
                anexo15_e.primer_apellido_fallecido = sqlite_datareader.GetString(4);
                anexo15_e.segundo_apellido_fallecido = sqlite_datareader.GetString(5);
                anexo15_e.hora_fallecido = sqlite_datareader.GetString(6);
                anexo15_e.fecha_fallecimineto = sqlite_datareader.GetString(7);
                anexo15_e.lugar_nacimineto_fallecido = sqlite_datareader.GetString(8);
                anexo15_e.municipio_provincia_pais_fallecido = sqlite_datareader.GetString(9);
                anexo15_e.fecha_nacimiento = sqlite_datareader.GetString(10);
                anexo15_e.pasaporte_fallecido = sqlite_datareader.GetString(11);
                anexo15_e.edad_fallecido = sqlite_datareader.GetString(12);
                anexo15_e.registro_civil_fallecido = sqlite_datareader.GetString(13);
                anexo15_e.tomo_fallecido = sqlite_datareader.GetString(14);
                anexo15_e.folio_fallecido = sqlite_datareader.GetString(15);
                anexo15_e.estado_civil_fallecido = sqlite_datareader.GetString(16);
                anexo15_e.ocupacion_fallecido = sqlite_datareader.GetString(17);
                anexo15_e.padre_fallecido = sqlite_datareader.GetString(18);
                anexo15_e.madre_fallecido = sqlite_datareader.GetString(19);
                anexo15_e.domicilio_fallecido = sqlite_datareader.GetString(20);
                anexo15_e.fecha_defuncion = sqlite_datareader.GetString(21);
                anexo15_e.hora_defuncion = sqlite_datareader.GetString(22);
                anexo15_e.lugar_fallecimiento = sqlite_datareader.GetString(23);
                anexo15_e.causa_muerte_fallecimiento = sqlite_datareader.GetString(24);
                anexo15_e.enfermedad_causa_fallecimiento = sqlite_datareader.GetString(25);
                anexo15_e.nombre_medico_certifica_fallecimiento = sqlite_datareader.GetString(26);
                anexo15_e.lugar_cepultura = sqlite_datareader.GetString(27);
                anexo15_e.registro_civil = sqlite_datareader.GetString(28);
                anexo15_e.tomo = sqlite_datareader.GetString(29);
                anexo15_e.folio = sqlite_datareader.GetString(30);
                anexo15_e.fecha_certificado = sqlite_datareader.GetString(31);
                anexo15_e.nombre_apellido_solicita = sqlite_datareader.GetString(32);
                anexo15_e.nro_pasaporte_carnet = sqlite_datareader.GetString(33);
                anexo15_e.parentesco_fallecido = sqlite_datareader.GetString(34);
                anexo15_e.direccion_solicita = sqlite_datareader.GetString(35);
                anexo15_e.nombre_apellido_funcionario_consular = sqlite_datareader.GetString(36);
                list.Add(anexo15_e);
            }
            
            return list;
        }
    }
}