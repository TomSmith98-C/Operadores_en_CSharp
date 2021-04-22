using System;

namespace Operadores_en_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 23;

            double numero1 = 1;
            double numero2 = 2;

            numero1++;
            Console.WriteLine($"La suma de {numero1} y {numero2} es igual a: "+(numero1+numero2));
            Console.WriteLine($"La resta de {numero1} y {numero2} es igual a: " + (numero1 - numero2));
            Console.WriteLine($"El producto de {numero1} y {numero2} es igual a: " + (numero1 * numero2));
            Console.WriteLine($"La division de {numero1} y {numero2} es igual a: " + (numero1 / numero2));
            Console.WriteLine($"El residuo de {numero1} y {numero2} es igual a: " + (numero1 % numero2));

            Console.WriteLine("Hello World, I'm have " + edad + " years old.");
            Console.WriteLine($"Hello Wolrd, I'm have {edad} years old");
            //Uso de las conversiones de variables usando la forma implicita y explicita

            //Forma Implicita
            int Variable_Entera = 2300;
            double Variable_Double;

            Variable_Double = Variable_Entera;

            Console.WriteLine("La variable ahora sera double "+ Variable_Double);

            //Forma Explicita
            int Entero;
            double Pi = 3.1416;

            Entero = (int)Pi;
            Console.WriteLine("Ahora es del tipo entero Pi = 3.1416 "+ Entero);

            //Cambiar String a int

            int Var = 323;
            String Temperatura = Var.ToString(); 
            Console.WriteLine($"La Temperatura es de: {Temperatura}");

        }
    }
}
