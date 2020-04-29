using System;
using System.Collections.Generic;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombres = "ave, banco, comida, duda, ejercicio, fuente, girasol"; //ave, banco, comida, duda, ejercicio, fuente, girasol
List<string> nombresList = new List<string>(nombresArray);
            string[] nombresArray = nombres.Split(", ");

            parts.RemoveAt(3);


            string nombresJoined = String.Join(";", nombresArray);
            System.Console.WriteLine(nombresJoined.ToUpper());

            //System.Console.WriteLine(String.Format("[{5}, {4}, {3}, {3}, {4}]", nombresJoined.ToUpper()));

//FUENTE;EJERCICIO;DUDA;COMIDA;BANCO
//"John,Johnny,Jason,Jimmy";


            //Escaped chars
        /*    System.Console.WriteLine("\n\nEscaped chars");
            System.Console.WriteLine("System.Console.WriteLine(\"\\n\\nFormatting\");");

            //Verbatim
            System.Console.WriteLine("\n\nVerbatim");
            System.Console.WriteLine(@"C:\Projects\Program.cs");
            System.Console.WriteLine(@"Línea 1
Línea 2
Línea 3");

            //Padding
            System.Console.WriteLine("\n\nPadding");
            System.Console.WriteLine("8.00".PadLeft(7));
            System.Console.WriteLine("10.00".PadLeft(7));
            System.Console.WriteLine("123.00".PadLeft(7));
            System.Console.WriteLine("1056.00".PadLeft(7));


            //Contains
            System.Console.WriteLine("\n\nContains");
            System.Console.WriteLine(nombres.Contains("John"));
            List<string> nombresList = new List<string>(nombresArray);
            System.Console.WriteLine(nombresList.Contains("Jimmy"));

            //IndexOf
            System.Console.WriteLine("\n\nIndexOf");
            //string nombres = "John,Johnny,Jason,Jimmy";
            int indexOfJimmy = nombres.IndexOf("Jimmy");
            System.Console.WriteLine($"indexOfJimmy => {indexOfJimmy}");
            
            //LastIndexOf
            System.Console.WriteLine("\n\nLastIndexOf");
            int lastIndexOfn = nombres.LastIndexOf("n");
            System.Console.WriteLine($"lastIndexOfJ => {lastIndexOfn}");


            //Case
            System.Console.WriteLine("\n\nCase");

            //Upper case
            System.Console.WriteLine(nombres.ToUpper());
            //Lower case
            System.Console.WriteLine(nombres.ToLower());*/

        }
    }
}