using System;

namespace JuegoDelCalamar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            console.Writeline("Bienvenido al juego del calamar ppeeeerrrrro");
            // INCISO 1: DECLARAR LAS CONSTANTES DEL JUEGO
            const string NOMBRE_JUEGO = "EL JUEGO DEL CALAMAR";
            const int TOTAL_CUPOS = 3;
            const int EDAD_MINIMA = 18;
            const double PREMIO_TOTAL = 45600000000;
            const string PRUEBA_1 = "Luz roja, luz verde";
            const string PRUEBA_2 = "Dalgona";
            const string PRUEBA_3 = "Tira y afloja";
            const string ESTADO_VIVO = "SOBREVIVE";
            const string ESTADO_FUERA = "ELIMINADO";

            // VARIABLES NECESARIAS
            string jugador1;
            string jugador2;
            string jugador3;
            string jugadorElegido = "";
            string pruebaElegida = "NO REALIZADA";
            string estadoFinal = "";
            string clasificacion = "";

            int numeroJugador = 0;
            int opcionJugador = 0;
            int opcionPrueba = 0;
            int decision = 0;
            int edad = 0;
            int puntaje = 0;

            // PRESENTACION DEL JUEGO
            Console.WriteLine("==============================================");
            Console.WriteLine("          " + NOMBRE_JUEGO);
            Console.WriteLine("        UNICEN - Programacion II");
            Console.WriteLine("==============================================");
            Console.WriteLine("Premio acumulado : " + PREMIO_TOTAL + " wones");
            Console.WriteLine("Cupos habilitados: " + TOTAL_CUPOS);
            Console.WriteLine("Edad minima      : " + EDAD_MINIMA + " anios");
            Console.WriteLine();

            // INCISO 2: REGISTRAR Y MOSTRAR TRES JUGADORES
            Console.WriteLine("--- REGISTRO DE JUGADORES ---");
            Console.Write("Nombre del jugador 1: ");
            jugador1 = Console.ReadLine();

            Console.Write("Nombre del jugador 2: ");
            jugador2 = Console.ReadLine();

            Console.Write("Nombre del jugador 3: ");
            jugador3 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Jugadores inscritos:");
            Console.WriteLine("001 - " + jugador1);
            Console.WriteLine("002 - " + jugador2);
            Console.WriteLine("003 - " + jugador3);
            Console.WriteLine();

            // INCISO 3: ELEGIR UN JUGADOR CON IF, ELSE IF Y ELSE
            Console.WriteLine("--- SELECCION DE JUGADOR ---");
            Console.WriteLine("1) " + jugador1);
            Console.WriteLine("2) " + jugador2);
            Console.WriteLine("3) " + jugador3);
            Console.Write("Que jugador entra a la arena (1-3): ");
            opcionJugador = int.Parse(Console.ReadLine());

            if (opcionJugador == 1)
            {
                jugadorElegido = jugador1;
                numeroJugador = 1;
            }
            else if (opcionJugador == 2)
            {
                jugadorElegido = jugador2;
                numeroJugador = 2;
            }
            else if (opcionJugador == 3)
            {
                jugadorElegido = jugador3;
                numeroJugador = 3;
            }
            else
            {
                jugadorElegido = "SIN JUGADOR";
                numeroJugador = 0;
                estadoFinal = ESTADO_FUERA;
                pruebaElegida = "OPCION DE JUGADOR INVALIDA";

                Console.WriteLine();
                Console.WriteLine("La opcion escrita no corresponde a ningun jugador.");
            }

            // Solo se continua cuando la seleccion del jugador es valida.
            if (numeroJugador != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Jugador seleccionado: 00" + numeroJugador + " - " + jugadorElegido);
                Console.Write("Ingrese la edad de " + jugadorElegido + ": ");
                edad = int.Parse(Console.ReadLine());

                if (edad < EDAD_MINIMA)
                {
                    estadoFinal = ESTADO_FUERA;
                    pruebaElegida = "NO REALIZADA";

                    Console.WriteLine("ACCESO DENEGADO. No cumple la edad minima.");
                }
                else
                {
                    puntaje = puntaje + 20;

                    Console.WriteLine("ACCESO PERMITIDO. Puede competir.");
                    Console.WriteLine();

                    Console.WriteLine("--- SELECCION DE PRUEBA ---");
                    Console.WriteLine("1) " + PRUEBA_1);
                    Console.WriteLine("2) " + PRUEBA_2 + " (galleta de azucar)");
                    Console.WriteLine("3) " + PRUEBA_3);
                    Console.Write("Elija una prueba (1-3): ");
                    opcionPrueba = int.Parse(Console.ReadLine());

                    // PRUEBA 1: LUZ ROJA, LUZ VERDE
                    if (opcionPrueba == 1)
                    {
                        pruebaElegida = PRUEBA_1;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_1);
                        Console.WriteLine("La muneca gigante giro la cabeza. Que hace " + jugadorElegido + "?");
                        Console.WriteLine("1) Seguir corriendo");
                        Console.WriteLine("2) Quedarse completamente inmovil");
                        Console.WriteLine("3) Esconderse detras de otro jugador");
                        Console.Write("Respuesta: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("La muneca detecto el movimiento.");
                        }
                        else if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 70;
                            Console.WriteLine("Se quedo inmovil y supero la prueba.");
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 40;
                            Console.WriteLine("El escondite funciono esta vez.");
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("Esa respuesta no existe.");
                        }
                    }

                    // PRUEBA 2: DALGONA
                    else if (opcionPrueba == 2)
                    {
                        pruebaElegida = PRUEBA_2 + " (galleta de azucar)";

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + pruebaElegida);
                        Console.WriteLine("Elija la figura de la galleta:");
                        Console.WriteLine("1) Triangulo (facil)");
                        Console.WriteLine("2) Estrella (media)");
                        Console.WriteLine("3) Sombrilla (dificil)");
                        Console.Write("Figura elegida: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 50;
                            Console.WriteLine("El triangulo salio completo.");
                        }
                        else if (decision == 2)
                        {
                            Console.Write("Lame la parte posterior de la galleta (1 = si / 2 = no): ");
                            decision = int.Parse(Console.ReadLine());

                            if (decision == 1)
                            {
                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 65;
                                Console.WriteLine("La estrella se desprendio sin romperse.");
                            }
                            else
                            {
                                estadoFinal = ESTADO_FUERA;
                                Console.WriteLine("La estrella se rompio.");
                            }
                        }
                        else if (decision == 3)
                        {
                            Console.Write("Usa una aguja calentada (1 = si / 2 = no): ");
                            decision = int.Parse(Console.ReadLine());

                            if (decision == 1)
                            {
                                estadoFinal = ESTADO_VIVO;
                                puntaje = puntaje + 80;
                                Console.WriteLine("La sombrilla salio completa.");
                            }
                            else
                            {
                                estadoFinal = ESTADO_FUERA;
                                Console.WriteLine("La sombrilla se quebro.");
                            }
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("Esa figura no esta disponible.");
                        }
                    }

                    // PRUEBA 3: TIRA Y AFLOJA
                    else if (opcionPrueba == 3)
                    {
                        pruebaElegida = PRUEBA_3;

                        Console.WriteLine();
                        Console.WriteLine("PRUEBA: " + PRUEBA_3);
                        Console.WriteLine("Que estrategia propone " + jugadorElegido + " al equipo?");
                        Console.WriteLine("1) Jalar con toda la fuerza desde el inicio");
                        Console.WriteLine("2) Inclinarse hacia atras y avanzar juntos");
                        Console.WriteLine("3) Soltar la cuerda");
                        Console.Write("Estrategia: ");
                        decision = int.Parse(Console.ReadLine());

                        if (decision == 1)
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("El equipo perdio el equilibrio.");
                        }
                        else if (decision == 2)
                        {
                            estadoFinal = ESTADO_VIVO;
                            puntaje = puntaje + 75;
                            Console.WriteLine("La estrategia coordinada funciono.");
                        }
                        else if (decision == 3)
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("El equipo cayo al soltar la cuerda.");
                        }
                        else
                        {
                            estadoFinal = ESTADO_FUERA;
                            Console.WriteLine("Esa estrategia no existe.");
                        }
                    }
                    else
                    {
                        pruebaElegida = "OPCION DE PRUEBA INVALIDA";
                        estadoFinal = ESTADO_FUERA;

                        Console.WriteLine("La prueba seleccionada no existe.");
                    }
                }
            }

            if (puntaje >= 90)
            {
                clasificacion = "FINALISTA";
            }
            else if (puntaje >= 60)
            {
                clasificacion = "AVANZA A LA SIGUIENTE RONDA";
            }
            else if (puntaje >= 30)
            {
                clasificacion = "PASA CON OBSERVACIONES";
            }
            else
            {
                clasificacion = "FUERA DE COMPETENCIA";
            }

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("       REPORTE FINAL - " + NOMBRE_JUEGO);
            Console.WriteLine("==============================================");
            Console.WriteLine("Jugador       : " + jugadorElegido);
            Console.WriteLine("Numero        : 00" + numeroJugador);
            Console.WriteLine("Prueba        : " + pruebaElegida);
            Console.WriteLine("Estado        : " + estadoFinal);
            Console.WriteLine("Puntaje       : " + puntaje + " / 100");
            Console.WriteLine("Clasificacion : " + clasificacion);

            // El premio aparece unicamente cuando el jugador sobrevivio.
            if (estadoFinal == ESTADO_VIVO)
            {
                Console.WriteLine("Premio en juego: " + PREMIO_TOTAL + " wones");
            }

            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.Write("Presione ENTER para terminar...");
            Console.ReadLine();
        }
    }
}