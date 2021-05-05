using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI
{
    public class MainMenu:IMenu
    {
        public void Start() {
            
            bool repeat = true;
            
            do {
                Console.WriteLine("Welcome to My Restaurant Reviews Application?");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] View a restaurant");
                Console.WriteLine("[1] Exit");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "0":
                        ViewRestaurant();
                        break;
                    case "1":
                        Console.WriteLine("Goodbye cruel world.");
                        repeat = false;
                        break;
                    default:
                    Console.WriteLine("input something valid");
                    break;
                }
            } while(repeat);
            
        }
        private void ViewRestaurant(){
            
            Resturant goodTaste = new Resturant("Good Taste", "Tampa", "Florida");
            
            goodTaste.Reviews = new List<Review>
            {
                new Review{
                    Rating = 5,
                    Description = "Okurrrrrrr"
                },
                new Review{
                    Rating = 5,
                    Description = "Heck yeah, dis bussin"
                }
            };
            
            Console.WriteLine(goodTaste.ToString());
            
            foreach (Review review in goodTaste.Reviews)
            {
                Console.WriteLine(review.ToString());
            }
        }
    }
}