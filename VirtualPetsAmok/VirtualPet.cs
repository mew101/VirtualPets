using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VirtualPetsAmok
{
   public class VirtualPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Hunger { get; set; }
        public string Species { get; set; }

        public int Fatigue { get; set; }
        public int Boredom { get; set; }

        public VirtualPet()
        {
            Name = "default";
            Fatigue = 5;
            Boredom = 5;
            Hunger = 5;
            
        }
        public void TimeIncrement()
        {
            Fatigue--;
            Boredom--;
            Hunger--;
        }

        public static void Kitty(int tabs, int milliSec)
        {
            
            //int milliseconds = 400;
            
            for (int i = 0; i < tabs; i++)
            {

                Console.Clear();
                for (int t=0; t<i; t++)
                    Console.Write("\t");
                Console.WriteLine("\n\n");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" _");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"( \");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" \ \");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" / /                 |\\");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"/ /     .-`````-.    / ^`-.");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"\ \    /         \_ /  {|} `o");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@" \ \  /   .-- -.   \\ _  ,--'");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"  \ \/   /     \,   \( `^^^");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"   \   \/\      (\  )");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"    \   ) \     ) \ \");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"     ) / __ \__  ) (\ \___");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"   (___)))__))(__))(__)))");
                Thread.Sleep(milliSec);
            }


        }

    }
}
