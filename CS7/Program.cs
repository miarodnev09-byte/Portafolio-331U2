using System;
namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bloque de instrucciones 
            //Sesión 15: Funciones
            //Función: Bloque de instrucciones para realizar una tarea específica, que se ejecuta, unicamente cuando es invocada.
            /*
            Sintaxis: Definición de una función
            tipo_de_dato_devuelto nombre_de_la_función (tipo_de_dato nombre_del_parametro)
            {
                //Instrucciones
            }
            Nota 1: Los parámetros se definen incluyendo tipo de dato.
            Nota 2: Los parámetros van separados por comas.
            Sintaxis: Invocación de una función
            identificador_función(argumentos);
            Argumento: Es el valor del parámetro que se pasa a la función.
            */
            //Ejemplo 1: Función vacía sin parámetros
            // Definición
            void Saludar()
            {
                string salón = "Exactas 331";
                Console.WriteLine($"¡Hola, {salón}!");
            }
            // Invocación
            Saludar();
            // Ejercitación
            // 1. Definir e invocar una función sin parámetros para imprimir: nombre, clave y salon
            void Datos()
            {
                string nombre = "Mia Rodriguez";
                string clave = "33";
                string salon = "331";
                Console.WriteLine($"Datos del estudiante: {nombre}, {clave}, {salon}");
            }
            // 2. Definir e invocar una función sin parámetrospara desplegar el horario de hoy
            void Horario()
            {
                string hora7_00am = "Cálculo";
                string hora7_50am = "Formación Humana";
                string hora8_40am = "Programación";
                string hora9_50am = "Psicología";
                string hora10_40am = "Idiomas";
                string hora11_50am = "Dibujo Técnico";
                string hora12_40pm = "Dibujo Técnico";
                Console.WriteLine($"Horario de hoy: {hora7_00am}, {hora7_50am}, {hora8_40am}, {hora9_50am}, {hora10_40am}, {hora11_50am}, {hora12_40pm}");
            }
            Horario();
        }
    }
}
