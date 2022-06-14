using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var kreds1 = new Kreds("1", "VanløseKreds", "Vanløse", 0);
            var kreds2 = new Kreds("2", "HolbækKreds", "Holbæk", 5);
            var kreds3 = new Kreds("3", "RingstedKreds", "Ringsted", 5);


            var badetidsperiode1 = new BadetidsPeriode("Mot", DayOfWeek.Sunday, new DateTime(2023, 06, 14), new DateTime(2022, 06, 15));

            Console.WriteLine();
            
            
                badetidsperiode1.AddKreds(kreds1);
                badetidsperiode1.AddKreds(kreds2);
            Console.WriteLine();
                Console.WriteLine(badetidsperiode1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); 


            badetidsperiode1.DeleteKreds($"1");
                Console.WriteLine(badetidsperiode1);
            Console.WriteLine();

            
             BadeTidsPeriodeForLoopAndList b1 = new BadeTidsPeriodeForLoopAndList("ttf", DayOfWeek.Sunday, new DateTime(2023, 06, 14), new DateTime(2022, 06, 15));
            b1.AddKreds(kreds1);
            Console.WriteLine(b1);
           









        }
    }
}
