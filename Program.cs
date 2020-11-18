using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que tabuda você gostaria de saber?");
            
            int tabuada = int.Parse(Console.ReadLine());
            
            int contador = 0;
            
            while(contador<=10){
                Console.WriteLine(tabuada * contador);
                contador = contador + 1;
                
            }

        }
    }
}
