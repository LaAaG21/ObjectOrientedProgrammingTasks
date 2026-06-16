namespace OOPpart1
{

    class Room
    {
        public string roomNumber;
        public string roomType;
        public string pricePerNight;
        public bool isAvalibale;

        public void displayRoom()
        {

        }

        public void room(string No)
        {
            roomNumber = No;
        }

        public void room(string No, string t)
        {
            roomNumber = No;
            roomType = t;
        }
    }

    class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public double totalNights;

        public void displayGuest()
        {

        }

        public void calculateTotalCost()
        {

        }
    }


    internal class Program
    {

        static bool menulop = true;

        public static string Mainmenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=================================================");
            Console.WriteLine(); 
            Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
            Console.WriteLine(); 
            Console.WriteLine("=================================================");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("1. Add New Room");
            Console.WriteLine("2. Register New Guest");
            Console.WriteLine("3. Book a Room For a Guest");

            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            
            Console.WriteLine("4. Search & Filter Rooms");
            Console.WriteLine("5. Guest & Booking Statistics");

            Console.ForegroundColor = ConsoleColor.DarkRed; 
            
            Console.WriteLine("6. Check Out & Guest");
            Console.WriteLine("7. Remove Unavailable Rooms");

            Console.ResetColor();
            Console.WriteLine("0. Exit");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("=================================================");
            Console.WriteLine();

            Console.Write("Enter Your Choices: ");

            return Console.ReadLine();
        }




        static void Main(string[] args)
        {

            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();


            do
            {
                switch(Mainmenu())
                {
                    case "0":

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.WriteLine("We Will Miss You.. U_U <3");

                        menulop = false;

                        break;

                    case "1":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");


                        break;

                    case "2":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");

                        break;

                    case "3":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");

                        break;

                    case "4":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");

                        break;

                    case "5":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");

                        break;

                    case "6":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");

                        break;

                    case "7":

                        Console.ResetColor();

                        Console.WriteLine();
                        Console.WriteLine("Under Devalopment..");

                        break;
                }

                Console.ResetColor();

                Console.WriteLine();
                Console.WriteLine("Press Any Key To Continue..");
                Console.ReadKey();
                Console.Clear();


            } while (menulop);
        }
    }
}
