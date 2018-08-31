using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaBeisol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo equipo1 = new Equipo();
            equipo1.Nombre = "Halcones";
            equipo1.CiudadOrigen = "Monterrey";
            equipo1.Entrenador = "Luis";
            equipo1.Jugadores.Add(new Jugador("Ricky", "72"));
            equipo1.Jugadores.Add(new Jugador("Eduardo", "45"));
            equipo1.Jugadores.Add(new Jugador("Jose", "33"));
            equipo1.Jugadores.Add(new Jugador("Armando", "66"));
            equipo1.Jugadores.Add(new Jugador("Oney", "81"));
            equipo1.Jugadores.Add(new Jugador("Ivan", "54"));
            equipo1.Jugadores.Add(new Jugador("Gabriel", "17"));
            equipo1.Jugadores.Add(new Jugador("Santiago", "06"));
            equipo1.Jugadores.Add(new Jugador("Jun", "83"));

            Equipo equipo2 = new Equipo();
            equipo2.Nombre = "Ratas";
            equipo2.CiudadOrigen = "Obregon";
            equipo2.Entrenador = "Ernesto";
            equipo2.Jugadores.Add(new Jugador("Kilo", "55"));
            equipo2.Jugadores.Add(new Jugador("German", "42"));
            equipo2.Jugadores.Add(new Jugador("Marcos", "51"));
            equipo2.Jugadores.Add(new Jugador("Carlos", "96"));
            equipo2.Jugadores.Add(new Jugador("Daniel", "05"));
            equipo2.Jugadores.Add(new Jugador("Juan", "49"));
            equipo2.Jugadores.Add(new Jugador("Ariel", "32"));
            equipo2.Jugadores.Add(new Jugador("Andres", "29"));
            equipo2.Jugadores.Add(new Jugador("Sebastian", "26"));

            equipos.Add(equipo1);
            equipos.Add(equipo2);


            foreach (Equipo elemento in equipos)
            {
                Console.WriteLine("Nombre de Equipo: " + elemento.Nombre);
                Console.WriteLine("Ciudad de Origen: " + elemento.CiudadOrigen);
                Console.WriteLine("Entrenador: " + elemento.Entrenador);

                foreach(Jugador elementoJ in elemento.Jugadores)
                {
                    Console.WriteLine("Nombre de Jugador :" + elementoJ.Nombre);
                    Console.WriteLine("Numero: " + elementoJ.Numero);
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}
