using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class choosePath
    {
        public void getStarted()
        {
            Console.WriteLine("You wake up and are laying in bed and have work in an hour, would you like to get up or stay asleep? \n(type get up or type fall asleep).");
            string userInput = Console.ReadLine();

            if (userInput == "get up")
            {
                outOfBed();
            }
            else if(userInput == "fall asleep")
            {
                Console.WriteLine("you go back to sleep and dream of puppies and rainbows but get a call later fron your boss telling you that you're fired congrats you lose.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry we didn't understand that answer please try again.");
                Console.ReadLine();
            }
        }
        public void outOfBed()
        {
            Console.WriteLine("You are now out of bed. Would you like to take a shower, go eat breakfast, or get dressed? \n(type shower, or breakfast).");
            string userInput = Console.ReadLine();

            if (userInput == "shower")
            {
                takingShowerNoEat();
            }
            else if (userInput == "breakfast")
            {
                eatingBreakfastNoShower();
            }
                
            else
            {
                Console.WriteLine("Sorry we didn't understand that answer please try again.");
                Console.ReadLine();
            }
        }
        public void takingShowerNoEat()
        {
            Console.WriteLine("You go to the bathroom shower and get ready for the day. Would you like to eat breakfast or leave for work? \n(Type breakfast or leave).\n");
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "breakfast":
                    stayOrLeave();
                    break;
                     
                case "leave":
                    
                Console.WriteLine("You leave the house starving and die from starvation on the way to work. You lose");
                Console.ReadLine();
                break;

                default:
            
                Console.WriteLine("Sorry we didn't understand that answer please try again.");
                Console.ReadLine();
                    break;

            }
        }

        public void eatingBreakfastNoShower()
        {
            Console.WriteLine("You go in the kitchen and eat breakfast. What would you like to do now? \n(Type shower, or leave).\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "shower":
                    stayOrLeave();
                    break;

                case "leave":

                    Console.WriteLine("You make it to work and your co-workers lock you in a janitors closet because you smell horrendous. You lose");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("Sorry we didn't understand that answer please try again.");
                    Console.ReadLine();
                    break;

            }
        }
        public void stayOrLeave()
        {
            Console.WriteLine("You are now both clean and full. Would you like to leave for work or stay home?\n(Type stay, or leave).\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "stay":
                    Console.WriteLine("You are clean and full but get a call later in the day from your boss saying you're fired. You lose");
                    Console.ReadLine();
                    break;

                case "leave":

                    Console.WriteLine("You make it to work both clean and full and have a good day. You win!");
                    Console.ReadLine();
                    break;

                default:

                    Console.WriteLine("Sorry we didn't understand that answer please try again.");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
