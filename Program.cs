using System;
using System.Numerics;

namespace GF2projekt
{
    class Program
    {
        // Create a pool for registered users
        static int[] registrations = {
            41000000,41111111,41222222,41333333,41444444,41555555,41666666,41777777,41888888,41999999,
            51000000,51111111,51222222,51333333,51444444,51555555,51666666,51777777,51888888,51999999,
            61000000,61111111,61222222,61333333,61444444,61555555
        };

        static string[] identities = {
            // Numnber - Name Age - Address
            "41000000 - Ian Will 47 - Maple St. 13",
            "41111111 - Hank Nate 71 - Magnolia St. 190",
            "41222222 - Ian Gavin 74 - Fir St. 87",
            "41333333 - Ivy Quincy 46 - Cedar St. 239",
            "41444444 - Sam Aaron 76 - Cherry St. 40",
            "41555555 - Kathy Kevin 47 - Magnolia St. 18",
            "41666666 - Jill Hank 34 - Hickory St. 202",
            "41777777 - Will Kevin 21 - Main St. 125",
            "41888888 - Zack Quincy 61 - Birch St. 212",
            "41999999 - Frank Lily 34 - Spruce St. 232",
            "51000000 - Quincy Hank 43 - Sycamore St. 118",
            "51111111 - Ivy Quincy 43 - Chestnut St. 145",
            "51222222 - Bob Tina 27 - Spruce St. 62",
            "51333333 - Olivia Jane 56 - Pine St. 65",
            "51444444 - Tina Diana 61 - Chestnut St. 139",
            "51555555 - Ivy Yara 31 - Dogwood St. 218",
            "51666666 - Xander Quincy 77 - Birch St. 205",
            "51777777 - Aaron Quinn 61 - Elm St. 180",
            "51888888 - Jack Yosef 46 - Hickory St. 138",
            "51999999 - Tara Kathy 31 - Oak St. 183",
            "61000000 - Owen Ivy 37 - Ash St. 96",
            "61111111 - Penny Nate 58 - Walnut St. 54",
            "61222222 - Mason Nina 35 - Pine St. 17",
            "61333333 - Lily Mona 26 - Fir St. 190",
            "61444444 - Vince Riley 23 - Fir St. 96",
            "61555555 - Alice Penny 55 - Cherry St. 92",
        };

        static void Main(string[] args)
        {
            do
            {
                StartMenu();
            }
            while (true);

            //Console.ReadLine();
        }

        // Simple back to menu function with countdown
        static void BackMenu(string msg)
        {
            Console.Clear();

            byte seconds = 3;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{msg} Returning to menu... {seconds}");
                --seconds;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        static void Continue()
        {
            Thread.Sleep(300); // Small delay for readability

            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey(true);
        }

        // Start Menu function
        static void StartMenu()
        {
            Console.Clear();

            // Header
            Console.Write("Options\n\n[1] Register\n[2] Find User\n[3] Show All\n\nPress a number: ");

            char? input = Console.ReadKey(true).KeyChar;
            switch (input)
            {
                case '1':
                    Register();
                    break;
                case '2':
                    FindUser();
                    break;
                case '3':
                    ShowAll();
                    break;

                // Fallback: return to start menu
                default:
                    StartMenu();
                    break;
            }
        }

        static void Register()
        {
            Console.Clear();

            Console.Write("Enter phone number to register: ");

            string input = Console.ReadLine();
            if (input != null && input.Length != 8)
                BackMenu("Invalid input.");
            else
            {
                input = int.Parse(input).ToString();

                // Bool return method, since returning outside functions isn't allowed.
                bool registered = false;
                for (int i = 0; i < registrations.Length; i++)
                {
                    if (registrations[i].ToString() == input)
                    {
                        registered = true;
                    }
                }

                if (registered)
                    BackMenu(input + " is already registered.");
            }

            
            Continue();
        }

        static void FindUser()
        {
            Console.Clear();

            Console.Write("Search index: ");


            Continue();
        }
        
        static void ShowAll()
        {
            Console.Clear();

            Console.WriteLine("Registered Users:\n");
            for (int i = 0; i < identities.Length; i++)
            {
                Console.WriteLine($"- {identities[i]}");
            }

            Continue();
        }
    }
}

/*
 * Register()
 * TODO: input, validation - (DONE)
 * TODO: if registered, fail
 * TODO: if not, validate and ask for name, address, age, mail, etc.
 * TODO: save to identities and registrations
 * 
 * FindUser()
 * TODO: Search functionality
 * TODO: Max 14 lines
 * 
 * ShowAll()
 * TODO: 14:X Paging
 * TODO: Show average age
*/




/*
// Create a pool for user registrations, associating user ID with full names and addresses
static Dictionary<int, string> registrationIdentity = new Dictionary<int, string>();

// Possible default names and addresses for generating identities
static string[] DEFAULT_NAMES =
{
            "John", "Jane", "Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Hank",
            "Ivy", "Jack", "Kathy", "Leo", "Mona", "Nate", "Olivia", "Paul", "Quincy", "Rachel",
            "Sam", "Tina", "Uma", "Vince", "Wendy", "Xander", "Yara", "Zack",
            "Aaron", "Beth", "Cody", "Daisy", "Ethan", "Fiona", "Gavin", "Holly", "Ian", "Jill",
            "Kevin", "Lily", "Mason", "Nina", "Owen", "Penny", "Quinn", "Riley", "Sean", "Tara",
            "Ulysses", "Vera", "Will", "Xenia", "Yosef", "Zoe"
        };

static string[] DEFAULT_ADDRESSES =
{
            "Main St.", "Oak St.", "Pine St.", "Maple St.", "Cedar St.", "Elm St.", "Birch St.", "Walnut St.",
            "Chestnut St.", "Spruce St.", "Willow St.", "Ash St.", "Poplar St.", "Hickory St.", "Sycamore St.",
            "Cherry St.", "Magnolia St.", "Dogwood St.", "Fir St.", "Hemlock St."
        };

static void RegisterDefaults()
{
    int generateAmount = new Random().Next(40000, 50000);
    for (int i = 0; i < generateAmount; i++)
    {
        // Generate a new registration
        int _phoneNumber = new Random().Next(11000000, 91000000);
        Array.Resize(ref registrations, registrations.Length + 1);
        registrations[^1] = _phoneNumber;

        // Skip if already registered
        if (registrationIdentity.ContainsKey(_phoneNumber))
        { i--; continue; }

        Console.WriteLine($"Registering user {_phoneNumber}... {i}/{generateAmount}");

        // Generate identity
        string _name1 = DEFAULT_NAMES[new Random().Next(0, DEFAULT_NAMES.Length)];
        string _name2 = DEFAULT_NAMES[new Random().Next(0, DEFAULT_NAMES.Length)];
        string _address = DEFAULT_ADDRESSES[new Random().Next(0, DEFAULT_ADDRESSES.Length)];
        string _streetNumber = new Random().Next(2, 254).ToString();

        // Build record, name/age/address
        string _identity = $"{_name1} {_name2} {(byte)new Random().Next(18, 80)} - {_address} {_streetNumber}";
        registrationIdentity.Add(_phoneNumber, _identity);

    }
}
*/