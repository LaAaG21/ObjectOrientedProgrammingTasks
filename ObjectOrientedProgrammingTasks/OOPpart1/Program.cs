namespace OOPpart1
{

    class Room
    {
        public string roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvalibale;

        public void displayRoom()
        {

        }        

        public Room(string No, string t, double p)
        {
            roomNumber = No;
            roomType = t;
            pricePerNight = p;
            isAvalibale = true;
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

        public Guest(string id, string n, string d, double t)
        {
            guestId = id;
            guestName = n;
            roomNumber = "Not Assigned";
            checkInDate = d;
            totalNights = t;
            
        }
    }


    internal class Program
    {
        public static List<Room>  rooms  = new List<Room>();
        public static List<Guest> guests = new List<Guest>();

        static bool menulop = true;
        static string roomNo;
        static string roomT;
        static double pric;

        static string id;
        static string gName;
        static string cDate;
        static int noNights;

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

        public static void Newroom()
        {
            Console.Write("Enter Room Number: ");
            roomNo = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter Room Type (Single / Double / Suite): ");
            roomT = Console.ReadLine().Trim().ToLower();

            Console.WriteLine();

            Console.Write("Enter Price Per Night: ");
            pric = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            if (rooms.Any(r => r.roomNumber == roomNo))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Room Number Is Already Exists!..");
                Console.ResetColor();
                return;
            }

            if (roomT != "single" || roomT != "double" || roomT != "suite")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Room Type You Wrote Is Wrong!..");
                Console.ResetColor();
                return;
            }

            rooms.Add(new Room(roomNo, roomT, pric));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Seccessfully Added The Room..");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"Room Number: {roomNo}   |   Room Type: {roomT}  |   Price Per Night: {pric}");
            Console.WriteLine();
            Console.WriteLine($"Total Rooms Are: {rooms.Count()}");
        }

        public static void Register()
        {
            Console.Write("Enter Your Name: ");
            gName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter The Date, Example'21/6/2026' : ");
            cDate = Console.ReadLine().Trim();

            Console.WriteLine();

            Console.Write("Enter Number of Nights: ");
            noNights = Convert.ToInt32(Console.ReadLine());

            if (noNights <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Number of Nights Most Be Positive");
                Console.ResetColor();
            }

            id = "G" + (guests.Count() + 1).ToString("D3");
            Console.WriteLine();

            guests.Add(new Guest(id, gName, cDate, noNights));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Seccessfully Added The Room..");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"ID: {id}    |   Guest Name: {gName} |   Check-in Date: {cDate}  |   Number of Nights: {noNights}");

        }

        static void Main(string[] args)
        {         

            rooms.Add(new Room("F110", "single", 35.4));
            rooms.Add(new Room("F111", "double", 55.5));
            rooms.Add(new Room("F112", "single", 35.4));
            rooms.Add(new Room("F113", "double", 55.5));
            rooms.Add(new Room("F114", "suite" , 80.2));
            rooms.Add(new Room("F115", "suite" , 80.2));


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
                        //Console.WriteLine("Under Devalopment..");

                        Newroom();

                        break;

                    case "2":

                        Console.ResetColor();

                        Console.WriteLine();
                        //Console.WriteLine("Under Devalopment..");

                        Register();

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
