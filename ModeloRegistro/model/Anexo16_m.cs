using System;
using System.Data.SQLite;
using System.Collections.Generic;

namespace ModeloRegistro.model
{
    public class Anexo16_m
    {
        private SQLiteConnection connection;

        public Anexo16_m(SQLite sqlite)
        {
            this.connection = sqlite.getConnection();
        }

        public void save(Anexo16_e anexo16_e)
        {
            string[] columns = new string[] { "tirista", "transeuntes", "eventos", "invitados", "estudiantes_programas_becas", "artistas", "periodistas", "religiosos", "diplomaticas", "tecnicos", "deportistas", "negocios", "otras", "fecha_solicitud", "pasaporte", "lugar_expedicion", "fecha_expedicion", "primer_apellido", "segundo_apellido", "primer_nombre", "segundo_nombre", "padre", "madre", "lugar_nacimiento_padres", "estatura", "estado_civil", "m", "f", "blue_green_claros", "black_negros", "pardos", "piel_blanca", "piel_negra", "piel_albina", "piel_amarilla", "pelo_canoso", "pelo_negro", "pelo_rubio", "pelo_castaño", "pelo_rojo", "pelo_otro", "pais", "provincia", "ciudad_municipio", "fecha_nacimiento", "direccion", "codigo_postal", "provincia_estado_region", "pais_residencia_actual", "telefono", "fax", "email", "nombre_centro_trabajo_estudio", "profecion", "ocupacion", "direccion_centro", "codigo_postal_centro", "provincia_estado_region_centro", "pais_centro", "telefono_centro", "fax_centro", "email_centro", "direccion_estancia_cuba", "nombre_apellido_persona_a_vicitar_cuba", "motivo_viaje_cuba", "tiempo_estancia", "lugar_fecha_salida_cuba", "lugar_fecha_llegada_cuba", "proposito_viaje_cuba" };
            object[] values = new object[] { anexo16_e.tirista, anexo16_e.transeuntes, anexo16_e.eventos, anexo16_e.invitados, anexo16_e.estudiantes_programas_becas, anexo16_e.artistas, anexo16_e.periodistas, anexo16_e.religiosos, anexo16_e.diplomaticas, anexo16_e.tecnicos, anexo16_e.deportistas, anexo16_e.negocios, anexo16_e.otras, anexo16_e.fecha_solicitud, anexo16_e.pasaporte, anexo16_e.lugar_expedicion, anexo16_e.fecha_expedicion, anexo16_e.primer_apellido, anexo16_e.segundo_apellido, anexo16_e.primer_nombre, anexo16_e.segundo_nombre, anexo16_e.padre, anexo16_e.madre, anexo16_e.lugar_nacimiento_padres, anexo16_e.estatura, anexo16_e.estado_civil, anexo16_e.m, anexo16_e.f, anexo16_e.blue_green_claros, anexo16_e.black_negros, anexo16_e.pardos, anexo16_e.piel_blanca, anexo16_e.piel_negra, anexo16_e.piel_albina, anexo16_e.piel_amarilla, anexo16_e.pelo_canoso, anexo16_e.pelo_negro, anexo16_e.pelo_rubio, anexo16_e.pelo_castaño, anexo16_e.pelo_rojo, anexo16_e.pelo_otro, anexo16_e.pais, anexo16_e.provincia, anexo16_e.ciudad_municipio, anexo16_e.fecha_nacimiento, anexo16_e.direccion, anexo16_e.codigo_postal, anexo16_e.provincia_estado_region, anexo16_e.pais_residencia_actual, anexo16_e.telefono, anexo16_e.fax, anexo16_e.email, anexo16_e.nombre_centro_trabajo_estudio, anexo16_e.profecion, anexo16_e.ocupacion, anexo16_e.direccion_centro, anexo16_e.codigo_postal_centro, anexo16_e.provincia_estado_region_centro, anexo16_e.pais_centro, anexo16_e.telefono_centro, anexo16_e.fax_centro, anexo16_e.email_centro, anexo16_e.direccion_estancia_cuba, anexo16_e.nombre_apellido_persona_a_vicitar_cuba, anexo16_e.motivo_viaje_cuba, anexo16_e.tiempo_estancia, anexo16_e.lugar_fecha_salida_cuba, anexo16_e.lugar_fecha_llegada_cuba, anexo16_e.proposito_viaje_cuba };

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

            sqlite_cmd.CommandText = $"INSERT INTO anexo16 {exp_columns} VALUES{exp_values};";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }

        public void update(Anexo16_e anexo16_e)
        {
            string[] columns = new string[] { "tirista", "transeuntes", "eventos", "invitados", "estudiantes_programas_becas", "artistas", "periodistas", "religiosos", "diplomaticas", "tecnicos", "deportistas", "negocios", "otras", "fecha_solicitud", "pasaporte", "lugar_expedicion", "fecha_expedicion", "primer_apellido", "segundo_apellido", "primer_nombre", "segundo_nombre", "padre", "madre", "lugar_nacimiento_padres", "estatura", "estado_civil", "m", "f", "blue_green_claros", "black_negros", "pardos", "piel_blanca", "piel_negra", "piel_albina", "piel_amarilla", "pelo_canoso", "pelo_negro", "pelo_rubio", "pelo_castaño", "pelo_rojo", "pelo_otro", "pais", "provincia", "ciudad_municipio", "fecha_nacimiento", "direccion", "codigo_postal", "provincia_estado_region", "pais_residencia_actual", "telefono", "fax", "email", "nombre_centro_trabajo_estudio", "profecion", "ocupacion", "direccion_centro", "codigo_postal_centro", "provincia_estado_region_centro", "pais_centro", "telefono_centro", "fax_centro", "email_centro", "direccion_estancia_cuba", "nombre_apellido_persona_a_vicitar_cuba", "motivo_viaje_cuba", "tiempo_estancia", "lugar_fecha_salida_cuba", "lugar_fecha_llegada_cuba", "proposito_viaje_cuba" };
            object[] values = new object[] { anexo16_e.tirista, anexo16_e.transeuntes, anexo16_e.eventos, anexo16_e.invitados, anexo16_e.estudiantes_programas_becas, anexo16_e.artistas, anexo16_e.periodistas, anexo16_e.religiosos, anexo16_e.diplomaticas, anexo16_e.tecnicos, anexo16_e.deportistas, anexo16_e.negocios, anexo16_e.otras, anexo16_e.fecha_solicitud, anexo16_e.pasaporte, anexo16_e.lugar_expedicion, anexo16_e.fecha_expedicion, anexo16_e.primer_apellido, anexo16_e.segundo_apellido, anexo16_e.primer_nombre, anexo16_e.segundo_nombre, anexo16_e.padre, anexo16_e.madre, anexo16_e.lugar_nacimiento_padres, anexo16_e.estatura, anexo16_e.estado_civil, anexo16_e.m, anexo16_e.f, anexo16_e.blue_green_claros, anexo16_e.black_negros, anexo16_e.pardos, anexo16_e.piel_blanca, anexo16_e.piel_negra, anexo16_e.piel_albina, anexo16_e.piel_amarilla, anexo16_e.pelo_canoso, anexo16_e.pelo_negro, anexo16_e.pelo_rubio, anexo16_e.pelo_castaño, anexo16_e.pelo_rojo, anexo16_e.pelo_otro, anexo16_e.pais, anexo16_e.provincia, anexo16_e.ciudad_municipio, anexo16_e.fecha_nacimiento, anexo16_e.direccion, anexo16_e.codigo_postal, anexo16_e.provincia_estado_region, anexo16_e.pais_residencia_actual, anexo16_e.telefono, anexo16_e.fax, anexo16_e.email, anexo16_e.nombre_centro_trabajo_estudio, anexo16_e.profecion, anexo16_e.ocupacion, anexo16_e.direccion_centro, anexo16_e.codigo_postal_centro, anexo16_e.provincia_estado_region_centro, anexo16_e.pais_centro, anexo16_e.telefono_centro, anexo16_e.fax_centro, anexo16_e.email_centro, anexo16_e.direccion_estancia_cuba, anexo16_e.nombre_apellido_persona_a_vicitar_cuba, anexo16_e.motivo_viaje_cuba, anexo16_e.tiempo_estancia, anexo16_e.lugar_fecha_salida_cuba, anexo16_e.lugar_fecha_llegada_cuba, anexo16_e.proposito_viaje_cuba };

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

            sqlite_cmd.CommandText = $"UPDATE anexo16 SET {data} WHERE id = {anexo16_e.id}";

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
            sqlite_cmd.CommandText = $"DELETE FROM anexo16 WHERE id = {id}";
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }


        public List<Anexo16_e> list()
        {
            List<Anexo16_e> list = new List<Anexo16_e>();

            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = connection.CreateCommand();
            sqlite_cmd.CommandText = "SELECT* FROM anexo16";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Anexo16_e anexo16_e = new Anexo16_e();
                anexo16_e.id = sqlite_datareader.GetInt32(0);
                anexo16_e.tirista = sqlite_datareader.GetString(1);
                anexo16_e.transeuntes = sqlite_datareader.GetString(2);
                anexo16_e.eventos = sqlite_datareader.GetString(3);
                anexo16_e.invitados = sqlite_datareader.GetString(4);
                anexo16_e.estudiantes_programas_becas = sqlite_datareader.GetString(5);
                anexo16_e.artistas = sqlite_datareader.GetString(6);
                anexo16_e.periodistas = sqlite_datareader.GetString(7);
                anexo16_e.religiosos = sqlite_datareader.GetString(8);
                anexo16_e.diplomaticas = sqlite_datareader.GetString(9);
                anexo16_e.tecnicos = sqlite_datareader.GetString(10);
                anexo16_e.deportistas = sqlite_datareader.GetString(11);
                anexo16_e.negocios = sqlite_datareader.GetString(12);
                anexo16_e.otras = sqlite_datareader.GetString(13);
                anexo16_e.fecha_solicitud = sqlite_datareader.GetString(14);
                anexo16_e.pasaporte = sqlite_datareader.GetString(15);
                anexo16_e.lugar_expedicion = sqlite_datareader.GetString(16);
                anexo16_e.fecha_expedicion = sqlite_datareader.GetString(17);
                anexo16_e.primer_apellido = sqlite_datareader.GetString(18);
                anexo16_e.segundo_apellido = sqlite_datareader.GetString(19);
                anexo16_e.primer_nombre = sqlite_datareader.GetString(20);
                anexo16_e.segundo_nombre = sqlite_datareader.GetString(21);
                anexo16_e.padre = sqlite_datareader.GetString(22);
                anexo16_e.madre = sqlite_datareader.GetString(23);
                anexo16_e.lugar_nacimiento_padres = sqlite_datareader.GetString(24);
                anexo16_e.estatura = sqlite_datareader.GetString(25);
                anexo16_e.estado_civil = sqlite_datareader.GetString(26);
                anexo16_e.m = sqlite_datareader.GetString(27);
                anexo16_e.f = sqlite_datareader.GetString(28);
                anexo16_e.blue_green_claros = sqlite_datareader.GetString(29);
                anexo16_e.black_negros = sqlite_datareader.GetString(30);
                anexo16_e.pardos = sqlite_datareader.GetString(31);
                anexo16_e.piel_blanca = sqlite_datareader.GetString(32);
                anexo16_e.piel_negra = sqlite_datareader.GetString(33);
                anexo16_e.piel_albina = sqlite_datareader.GetString(34);
                anexo16_e.piel_amarilla = sqlite_datareader.GetString(35);
                anexo16_e.pelo_canoso = sqlite_datareader.GetString(36);
                anexo16_e.pelo_negro = sqlite_datareader.GetString(37);
                anexo16_e.pelo_rubio = sqlite_datareader.GetString(38);
                anexo16_e.pelo_castaño = sqlite_datareader.GetString(39);
                anexo16_e.pelo_rojo = sqlite_datareader.GetString(40);
                anexo16_e.pelo_otro = sqlite_datareader.GetString(41);
                anexo16_e.pais = sqlite_datareader.GetString(42);
                anexo16_e.provincia = sqlite_datareader.GetString(43);
                anexo16_e.ciudad_municipio = sqlite_datareader.GetString(44);
                anexo16_e.fecha_nacimiento = sqlite_datareader.GetString(45);
                anexo16_e.direccion = sqlite_datareader.GetString(46);
                anexo16_e.codigo_postal = sqlite_datareader.GetString(47);
                anexo16_e.provincia_estado_region = sqlite_datareader.GetString(48);
                anexo16_e.pais_residencia_actual = sqlite_datareader.GetString(49);
                anexo16_e.telefono = sqlite_datareader.GetString(50);
                anexo16_e.fax = sqlite_datareader.GetString(51);
                anexo16_e.email = sqlite_datareader.GetString(52);
                anexo16_e.nombre_centro_trabajo_estudio = sqlite_datareader.GetString(53);
                anexo16_e.profecion = sqlite_datareader.GetString(54);
                anexo16_e.ocupacion = sqlite_datareader.GetString(55);
                anexo16_e.direccion_centro = sqlite_datareader.GetString(56);
                anexo16_e.codigo_postal_centro = sqlite_datareader.GetString(57);
                anexo16_e.provincia_estado_region_centro = sqlite_datareader.GetString(58);
                anexo16_e.pais_centro = sqlite_datareader.GetString(59);
                anexo16_e.telefono_centro = sqlite_datareader.GetString(60);
                anexo16_e.fax_centro = sqlite_datareader.GetString(61);
                anexo16_e.email_centro = sqlite_datareader.GetString(62);
                anexo16_e.direccion_estancia_cuba = sqlite_datareader.GetString(63);
                anexo16_e.nombre_apellido_persona_a_vicitar_cuba = sqlite_datareader.GetString(64);
                anexo16_e.motivo_viaje_cuba = sqlite_datareader.GetString(65);
                anexo16_e.tiempo_estancia = sqlite_datareader.GetString(66);
                anexo16_e.lugar_fecha_salida_cuba = sqlite_datareader.GetString(67);
                anexo16_e.lugar_fecha_llegada_cuba = sqlite_datareader.GetString(68);
                anexo16_e.proposito_viaje_cuba = sqlite_datareader.GetString(69);
                list.Add(anexo16_e);
            }
            
            return list;
        }
    }
}