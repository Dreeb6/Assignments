using System;

class Program
{
    static void Main()
    {
        bool doPrintText = true;
        if (doPrintText)
        {
            int playerpos = 1;
            string playerchoice; 
            Console.WriteLine("The bare landscape streches out towards the horizon in all directions. The ground beneath your feet consists of an odd ");
            Console.WriteLine("grey dust, much finer than sand or dirt. In front of you lies a narrow tower that streaches into the featureless sky ");
            Console.WriteLine("and a house painted a color you don't recognize.");
            Console.WriteLine("What do you do? (use format, 'go to x' when typing your choice)");
            playerchoice = Console.ReadLine(); 
            //first fork is here

           if (playerchoice == "go to house")
            {
                Console.WriteLine($"Chosen action: {playerchoice}");
                Console.WriteLine("You enter the front door of the home, finding a the entirior of the home to be completely normal looking and devoid of ");
                Console.WriteLine("the odd coloration of the exterior. There's a pair of staircases, one leading to the basement, and the other leading ");
                Console.WriteLine("upstairs.");
                Console.WriteLine("What do you do?");
                playerchoice = Console.ReadLine(); 


                //second fork first route is here
                if (playerchoice == "go to basement")
                {
                    Console.WriteLine($"Chosen action: {playerchoice}");
                    Console.WriteLine("You begin desending the basement, and your consciousness blinks out of existance.");
                }

                if (playerchoice == "go upstairs")
                {
                    Console.WriteLine($"Chosen action: {playerchoice}");
                    Console.WriteLine("You asend the staircase. Whatever you see makes you never want to come back.");

                }
                    
            }

           if (playerchoice== "go to tower")
            {
                Console.WriteLine($"Chosen action: {playerchoice}");
                Console.WriteLine("You enter the tower, finding an empty room and a large spiral staircase stretching both upwards and into the ground ");
                Console.WriteLine("What do you do? (Ascend or densend the tower)");
                playerchoice = Console.ReadLine(); 


                //second fork in second route is here
                if (playerchoice == "ascend the tower")
                {
                    Console.WriteLine($"Chosen action: {playerchoice}");
                    Console.WriteLine("You begin to climb the staircase, taking breaks every few hours. When you finally reach the top, you find exactly what");
                    Console.WriteLine("you've been looking for your entire life.");
                }

                if (playerchoice == "desend the tower")
                {
                    Console.WriteLine($"Chosen action: {playerchoice}");
                    Console.WriteLine("You desend the staircase, going deeper and deeper. You never come out.");
                }
            }

           //else statement to handle outliers
           else
            {
                Console.WriteLine("That is not an available choice");
            }
            
        }
    }
}