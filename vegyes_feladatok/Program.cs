namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1() { }


        static void feladat2() { }

        static void feladat3() { }

        static void feladat4() { }






        static void Main(string[] args)
        {






                Console.Write("Add az osszes erteket: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Add a pozitiv erteket: ");
                int p = int.Parse(Console.ReadLine());

                int szazalek = p / n * 100;


                if (szazalek >= 90)
                {
                    Console.Write("Az értékelés nagyon pozitív volt");
                }
                else if (szazalek >= 75)
                {
                    Console.Write("Az értékelés  pozitív volt");
                }
                else if (szazalek >= 55)
                {
                    Console.Write("Az értékelés  volt");
                }
                else if (szazalek >= 25)
                {
                    Console.Write("Az értékelés  volt");
                }
                else if (szazalek >= 10)
                {
                    Console.Write("Az értékelés  volt");
                }
                else if (szazalek >= 0)
                {
                    Console.Write("Az értékelés  volt");
                }
        }



        
    }
}
