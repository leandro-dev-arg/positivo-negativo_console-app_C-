using System;

namespace U3_programa2
{
    class Program
    {
        static void Main(string[] args)
        { int n1;
           Console.WriteLine("ingrese un numero por favor");
           n1=int.Parse(Console.ReadLine());

           if (n1>0){
            Console.WriteLine("el número es positivo");
           }else{
            Console.WriteLine("el numero es negativo");
           }
        }

        
    }
}
