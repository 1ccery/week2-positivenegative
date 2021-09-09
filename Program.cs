using System;

namespace positivenegative
{
    class Program
    {
        static void Main(string[] args)
        {
             //programm palub kasutajal sisetada numrit -10 kuni 10
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab positiivne
            //kui number on negatiivne kuvab negatiivne
            // kui number on 0 siis kuvab konsool null
            Console.WriteLine("Palun sisestage number -10st 10neni!");


            int Num;
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine("Positiivne");
            }
            else if (Num < 0)
            {
                Console.WriteLine("Negatiivne.");

            }
            else
            {
                Console.WriteLine("Null.");
            }
            Console.ReadLine();

        }
    }
}
