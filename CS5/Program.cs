using System;

namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Unidad 1: Estructuras de control II
            // Unidad 2: Funciones II
            // Sesión 12: Instrucción while 30092026
            // Sintaxis: while
            // inicialización;
            // while(expresión)
            // {
            //     bloque de instrucciones
            //     iterador;
            // }
            // Iterar: repetir

            // Ejemplo 1: Ciclo ascendente (rango: 1-3)
            int m = 1; // Inicialización
            while (m <= 3)
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1;
            }

            // Ascendente
            int it1 = 1;
            while (it1 > 0)
            {
                Console.WriteLine($"it1: {it1}");
                it1++;
            }

            // Descendente
            int it2 = 99;
            while (it2 > 0)
            {
                Console.WriteLine($"it2: {it2}");
                it2--;
            }
            // Mia Rodríguez 331-33
            // Sesión 13
            double distancia = 0;
            double zancada = 0;
            int numero_hidratación = 0;
            int recorrido_hidratación = 2000;
            while (distancia < 21000)
            {
                distancia += 0.63;
                zancada += 1;
                if (distancia >= recorrido_hidratación)
                {
                    numero_hidratación += 1;
                    recorrido_hidratación += 2000;
                }
            }
            Console.WriteLine($"Zancadas necesarias: {zancada}");
            //1. Ciclo for 
            for (int n = 35; n <= 41; n += 1)
            {
                Console.WriteLine($"n: {n}");
            }
            // Sesión 14: Ciclo for 14102026
            // 1. Definir un ciclo for para la siguiente secuencia de números: -33, -34, -35, -36, -37, -38, -39
            Console.WriteLine($"Ciclo 1: Descendente");
            for (int n = -33; n >= -39; n -= 1)
            {
                Console.WriteLine($"n: {n* -1}");
            }
            Console.WriteLine($"Ciclo 2: Ascendente");
            for (int a = 9; a <= 15; a += 1)
            {
                if(a != 13)
                Console.WriteLine($"a: {a}");
            }
            // Incluir las instrucciones para omitir la impresión de 13.
            // Ejercicio Libro
            for (int l = 1; l <= 539; l += 88)
            {
                Console.WriteLine($"Titulo: {l}");
            }
        

        
        

        


        

    }
}
}
