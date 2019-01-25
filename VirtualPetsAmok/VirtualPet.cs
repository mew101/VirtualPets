using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VirtualPetsAmok
{
   public class VirtualPet
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Fullness { get; set; }        
        public int Energy { get; set; }
        public int Happiness { get; set; }

        public VirtualPet()
        {
            Name = "default";
            Energy = 5;
            Happiness = 5;
            Fullness = 5;
            
        }
        public void TimeIncrement()
        {
            Energy--;
            Happiness--;
            Fullness--;
        }
        public void Feed()
        {
            Fullness += 3;
            Console.WriteLine("You just FED " + Name + "!");
        }
        public void Play()
        {
            Happiness += 3;
            Console.WriteLine("You just PLAYED with" + Name + "!");
        }

        public void Nap()
        {
            Energy += 3;
            Console.WriteLine(Name + " took a NAP!");
        }
        public static void Kitty(int tabs, int milliSec)
        {
            
            //int milliseconds = 400;
            
            for (int i = 0; i < tabs; i++)
            {

                Console.Clear();
                if (i < (tabs/2))
                {
                    for (int t = 0; t < i; t++)
                        Console.Write("\n\n\n");
                }
                else
                {
                    for (int t = tabs; t > i; t--)
                        Console.Write("\n\n\n");
                }
                
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
                Console.WriteLine(@"    \   ) \     ) \ \                    ____()()");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"     ) / __ \__  ) (\ \___             /       @@");
                for (int t = 0; t < i; t++)
                    Console.Write("\t");
                Console.WriteLine(@"   (___)))__))(__))(__)))        `~~~~~\_;m__m._ >o");
                Thread.Sleep(milliSec);

            }

         //        ____()()
         //       /       @@
         // `~~~~~\_;m__m._ >o
        }

    }
}
