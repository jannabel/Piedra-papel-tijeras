using System;

namespace Piedra__Papel__Tijera
{
    class Program
    {

        public static int comprobar(int n)
        {

            switch (n)
            {
                case 1:
                    Console.Write(" Piedra. ");
                    break;
                case 2:
                    Console.Write(" Papel. ");
                    break;
                case 3:
                    Console.Write(" Tijera. ");
                    break;
            }


            return n;
        }



        static void Main(string[] args)
        {
            //Realizar un piedra, papel o tijera.
            int volver;
            int puntosA = 0, puntosB = 0;
            do
            {
                Console.Clear();
                var aleatorio = new Random().Next(1, 3);
                

                Console.WriteLine("\n .......................................");
                Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°° ");
                Console.WriteLine("           Piedra, papel, tijera ");
                Console.WriteLine(" .......................................");
                Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°° ");

                Console.WriteLine(" ~ ELIGE: ");
                Console.WriteLine("\n 1- Piedra ");
                Console.WriteLine(" 2- Papel ");
                Console.WriteLine(" 3- Tijera ");
                Console.WriteLine(" 4- Salir ");
                Console.Write(" ~ ");
                int jugada = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("\n .......................................");
                Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°° ");
                Console.WriteLine("           Piedra, papel, tijera ");
                Console.WriteLine(" .......................................");
                Console.WriteLine(" °°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°° ");

                Console.Write("\n La jugada del usuario es: ");
                comprobar(jugada);
                Console.Write("\n La jugada de la maquina es: ");
                comprobar(aleatorio);

                if (aleatorio == jugada)
                {
                    puntosA++;
                    puntosB++;
                }

                if (aleatorio == 1 && jugada == 3)
                {
                    puntosA++;
                }
                else if (aleatorio == 3 && jugada == 1)
                {
                    puntosB++;
                }

                if (aleatorio == 2 && jugada == 1)
                {
                    puntosA++;
                }
                else if (aleatorio == 1 && jugada == 2)
                {
                    puntosB++;
                }

                if (aleatorio == 3 && jugada == 2)
                {
                    puntosA++;
                }
                else if (aleatorio == 2 && jugada == 3)
                {
                    puntosB++;
                }
                Console.WriteLine("\n\n || Puntos usuario: {0}    ||   Puntos Maquina: {1} ||", puntosB, puntosA);

                if (puntosA > puntosB) Console.WriteLine("\n ~ La maquina gana ~");
                else if (puntosB > puntosA) Console.WriteLine("\n ~ El usuario gana ~ ");
                else if (puntosB == puntosA) Console.WriteLine("\n ~ Es un empate ~ ");

                Console.ReadKey();

                Console.WriteLine("\n Que Desea ? ");
                Console.WriteLine("\n 1- Salir ");
                Console.WriteLine(" 2- Volver a jugar ");
                Console.Write(" ~ ");
                volver = Convert.ToInt32(Console.ReadLine());

                if (volver == 1) Environment.Exit(0);

           
            } while (volver== 2);


        }
    }
}
