

using System;

namespace MainTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi i'm Islam's Carpet Cleaning Service");
            
            //declare variables
            int priceSmallRoom = 25;
            int priceLargeRoom = 35;
            int taxRate = 6;
            string massageEstimates = "This estimate is valid for 30 days";

            //to get inputs from user
            Console.WriteLine();
            Console.WriteLine("Number of small rooms");
            string inputSmallRooms = Console.ReadLine();
            int smallRooms = Convert.ToInt32(inputSmallRooms);

            Console.WriteLine("Number of large rooms");
            string inputLargeRooms = Console.ReadLine();
            int largeRooms = Convert.ToInt32(inputLargeRooms);

            //calculate the cost
            double cost = (smallRooms * priceSmallRoom) + (largeRooms * priceLargeRoom);

            //calculate the tax
            double tax = cost * taxRate / 100;

            //calculate the total cost
            double totalCost = cost + tax;

            //display the result
            //Console.WriteLine("Number of small carpets: "+smallRooms);
            //Console.WriteLine("Number of large carpets: "+largeRooms);
           
            Console.WriteLine("Price per small room: " + priceSmallRoom+"$");
            Console.WriteLine("Price per large room: " + priceLargeRoom+"$");
            Console.WriteLine("Cost : " + cost+"$");
            Console.WriteLine("Tax: " + tax + "$");
            Console.WriteLine("===============================");
            Console.WriteLine("Price per large room: " + totalCost + "$");
            Console.WriteLine(massageEstimates);
            Console.WriteLine();
            Console.WriteLine("**********Thank you for choosing Islam's Carpet Cleaning Service**********");

            Console.ReadLine();//at the end – no need to show all printer
        }
    }
}
