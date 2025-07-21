using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter number of players: ");
                int numPlayers = Convert.ToInt32(Console.ReadLine());
                if(numPlayers < 2)
                {
                    Console.WriteLine("Should not less that 2");
                    continue;
                }
                int trackLength = 100;
                int[] positions = new int[numPlayers];
                Random rand = new Random();
                bool raceOver = false;

                Console.Clear();
                Console.WriteLine(number3);
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(number2);
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(number1);
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(start);
                Thread.Sleep(1000);

                while (!raceOver)
                {
                    Console.Clear();

                    for (int i = 0; i < numPlayers; i++)
                    {
                        positions[i] += rand.Next(1, 7);

                        Console.Write("Player " + (i + 1) + ": ");
                        for (int j = 0; j < trackLength; j++)
                        {
                            if (j == positions[i])
                            {
                                Console.Write("&");
                            }
                            else
                            {
                                Console.Write("-");
                            }
                        }

                        Console.WriteLine();

                        if (positions[i] >= trackLength)
                        {
                            raceOver = true;
                        }
                    }

                    Thread.Sleep(700);
                }

                Console.WriteLine("\n " + winner + "\n");
                for (int i = 0; i < numPlayers; i++)
                {
                    if (positions[i] >= trackLength)
                    {
                        Console.WriteLine("                          Player " + (i + 1) + " wins!");
                    }

                }

                Console.Write("\nPress any key to try again...");
                Console.ReadKey();
            }
        }

        public static string number3 = @"

                   
                   
 333333333333333   
3:::::::::::::::33 
3::::::33333::::::3
3333333     3:::::3
            3:::::3
            3:::::3
    33333333:::::3 
    3:::::::::::3  
    33333333:::::3 
            3:::::3
            3:::::3
            3:::::3
3333333     3:::::3
3::::::33333::::::3
3:::::::::::::::33 
 333333333333333   
                   
                   
                   
                   
                   
                   
                   
";

        public static string number2 = @"

                    
                    
 222222222222222    
2:::::::::::::::22  
2::::::222222:::::2 
2222222     2:::::2 
            2:::::2 
            2:::::2 
         2222::::2  
    22222::::::22   
  22::::::::222     
 2:::::22222        
2:::::2             
2:::::2             
2:::::2       222222
2::::::2222222:::::2
2::::::::::::::::::2
22222222222222222222
                    
                    
                    
                    
                    
                    
                    
";

        public static string number1 = @"

            
            
  1111111   
 1::::::1   
1:::::::1   
111:::::1   
   1::::1   
   1::::1   
   1::::1   
   1::::l   
   1::::l   
   1::::l   
   1::::l   
   1::::l   
111::::::111
1::::::::::1
1::::::::::1
111111111111
            
            
            
            
            
            
            
";

        public static string start = @"

                                             
                                             
        GGGGGGGGGGGGG     OOOOOOOOO      !!! 
     GGG::::::::::::G   OO:::::::::OO   !!:!!
   GG:::::::::::::::G OO:::::::::::::OO !:::!
  G:::::GGGGGGGG::::GO:::::::OOO:::::::O!:::!
 G:::::G       GGGGGGO::::::O   O::::::O!:::!
G:::::G              O:::::O     O:::::O!:::!
G:::::G              O:::::O     O:::::O!:::!
G:::::G    GGGGGGGGGGO:::::O     O:::::O!:::!
G:::::G    G::::::::GO:::::O     O:::::O!:::!
G:::::G    GGGGG::::GO:::::O     O:::::O!:::!
G:::::G        G::::GO:::::O     O:::::O!!:!!
 G:::::G       G::::GO::::::O   O::::::O !!! 
  G:::::GGGGGGGG::::GO:::::::OOO:::::::O     
   GG:::::::::::::::G OO:::::::::::::OO  !!! 
     GGG::::::GGG:::G   OO:::::::::OO   !!:!!
        GGGGGG   GGGG     OOOOOOOOO      !!! 
                                             
                                             
                                             
                                             
                                             
                                             
                                             
";


        public static string winner = @"
                           _   _     _   _   U _____ u   ____     
 __        __     ___     | \ |""|   | \ |""|  \| ___""|/U |  _""\ u  
 \""\      /""/    |_""_|   <|  \| |> <|  \| |>  |  _|""   \| |_) |/  
 /\ \ /\ / /\     | |    U| |\  |u U| |\  |u  | |___    |  _ <    
U  \ V  V /  U  U/| |\u   |_| \_|   |_| \_|   |_____|   |_| \_\   
.-,_\ /\ /_,-.-,_|___|_,-.||   \\,-.||   \\,-.<<   >>   //   \\_  
 \_)-'  '-(_/ \_)-' '-(_/ (_"")  (_/ (_"")  (_/(__) (__) (__)  (__) ";
    }
}
