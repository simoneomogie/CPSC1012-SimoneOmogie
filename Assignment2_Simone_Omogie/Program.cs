using System;

namespace Assignment2_Simone_Omogie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Input
                Dimensions of a rectangular room (standard room height is 8 feet)
                Dimensions of a single window, entry door and closet door
                Type of paint
                Basic 29.99 / gallon (covers 300 sq feet on walls and 200 sq feet on ceilings)
                Premium 39.99 / gallon (covers 400 sq feet on walls and 250 sq feet on ceilings)
                Deluxe 49.99 / gallon (covers 500 sq feet on walls and 300 sq feet on ceilings)
                Type of flooring
                Carpet 2.75 / square foot
                Tile 3.50 / square foot
                Hardwood 4.85 / square foot
                Price of Baseboard per linear foot
                Price of Casing per linear foot
            */

            // Variables
            double rectroomheight = 8;

            int selectnum;
            int menuChoice;

            do
            {
                // Menu Choices - User inputs the number they want to go to.
                Console.WriteLine("1. Room Size");
                Console.WriteLine("2. Window Size");
                Console.WriteLine("3. Door Size");
                Console.WriteLine("4. Closet Size");
                Console.WriteLine("5. Paint Type");
                Console.WriteLine("6. Flooring Type");
                Console.WriteLine("7. Casing Price");
                Console.WriteLine("8. Baseboard Price");
                Console.WriteLine("9. Create Packing Slip");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Make a selection >>: ");
                // User makes their selection
                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Room");
                            Console.WriteLine("  Width: ");
                            double roomwidth = int.Parse(Console.ReadLine());
                            if (roomwidth > 1)
                            {
                                Console.WriteLine("  Length: ");
                                double roomlength = int.Parse(Console.ReadLine());
                            }
                            else if (roomwidth >= 'A' && roomwidth <= 'Z')
                            {
                                Console.WriteLine("Invalid Number - please type a number");
                            }
                            double roomlength = int.Parse(Console.ReadLine());
                        case 2:
                            Console.WriteLine("Window");
                            Console.WriteLine("  Width: ");
                            double windowwidth = int.Parse(Console.ReadLine());
                            if (windowwidth > 1)
                            {
                                Console.WriteLine("  Height: ");
                                double windowheight = int.Parse(Console.ReadLine());
                            }
                            else if (windowwidth >= 'A' && windowwidth <= 'Z')
                            {
                                Console.WriteLine("Invalid Choice - Try Again");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Door");
                            Console.WriteLine("  Width: ");
                            double doorwidth = int.Parse(Console.ReadLine());
                            if (doorwidth > 1)
                            {
                                Console.WriteLine("  Height: ");
                                double doorheight = int.Parse(Console.ReadLine());
                            }
                            else if (doorwidth >= 'A' && doorwidth <= 'Z')
                            {
                                Console.WriteLine("Invalid Choice - Try Again");
                            }
                            break;

                    }
                }
            }

            while (menuChoice != 0);
        }
    }
}



            

            