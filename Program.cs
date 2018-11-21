using System;

namespace ThatOneThing {

    class Program {

        public static int time = 25;
    
        static void Main(string[] args) 
        {
            Console.WriteLine ();
            Console.WriteLine ("Testing objects:");
            Missile Bill = new Missile (5000.00);
            RaceCar McQueen = new RaceCar (250.00);

            Console.WriteLine ();
            Console.WriteLine ("Missile distance traveled: " + Bill.MathCalculator (time, Bill.rate) + " meters");
            Console.WriteLine ();
            Console.WriteLine ("Racecar distance traveled: " + McQueen.MathCalculator (time, McQueen.rate) + " meters");
            Console.WriteLine ();
        }
    }
}
