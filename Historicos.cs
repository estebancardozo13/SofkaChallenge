using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Sofka_challenge
{
    class Historicos
    {
        private static string _path = "./puntajesHistoricos.json";
        public List<Jugador> Jugadores {get; set;}
       
        //Funciones
        public static List<Jugador> GetJugador(string jugador, int puntos)
        {
            if (CargarHistoricos() != null)
            {
                var jugadores = CargarHistoricos();

                jugadores.Add(new Jugador
                {
                    Nombre = jugador,
                    Premio = new Premio
                    {
                        Puntos = puntos,
                        Fecha = DateTime.Now
                    }
                });
                return jugadores;
            }
            else
            {
                List<Jugador> jugadores = new List<Jugador>
                {
                new Jugador
                {
                    Nombre = jugador,
                    Premio = new Premio
                    {
                        Puntos = puntos,
                        Fecha = DateTime.Now
                    }
                },

                };
                return jugadores;
            }
            

            
        }

        public static void EscribirHistoricos(List<Jugador> jugadores)
        {
            string contactJson = JsonConvert.SerializeObject(jugadores.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, contactJson);
        }

        public static List<Jugador> CargarHistoricos()
        {
            string HistoricosDesdeJson;
            using (var reader = new StreamReader(_path))
            { HistoricosDesdeJson = reader.ReadToEnd(); }
            var registros = JsonConvert.DeserializeObject<List<Jugador>>(HistoricosDesdeJson);
            return registros;
        }

    }
}

