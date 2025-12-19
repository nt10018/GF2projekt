using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GF2projekt
{
    // Class for functions
    class Functions
    {
        // Create a pool for registered users
        private int[] registrations = { };

        private string[] identities = {
            "Ian Will 47 - Maple St. 13",
            "Hank Nate 71 - Magnolia St. 190",
            "Ian Gavin 74 - Fir St. 87",
            "Ivy Quincy 46 - Cedar St. 239",
            "Sam Aaron 76 - Cherry St. 40",
            "Kathy Kevin 47 - Magnolia St. 18",
            "Jill Hank 34 - Hickory St. 202",
            "Will Kevin 21 - Main St. 125",
            "Zack Quincy 61 - Birch St. 212",
            "Frank Lily 34 - Spruce St. 232",
            "Quincy Hank 43 - Sycamore St. 118",
            "Ivy Quincy 43 - Chestnut St. 145",
            "Bob Tina 27 - Spruce St. 62",
            "Olivia Jane 56 - Pine St. 65",
            "Tina Diana 61 - Chestnut St. 139",
            "Ivy Yara 31 - Dogwood St. 218",
            "Xander Quincy 77 - Birch St. 205",
            "Aaron Quinn 61 - Elm St. 180",
            "Jack Yosef 46 - Hickory St. 138",
            "Tara Kathy 31 - Oak St. 183",
            "Owen Ivy 37 - Ash St. 96",
            "Penny Nate 58 - Walnut St. 54",
            "Mason Nina 35 - Pine St. 17",
            "Lily Mona 26 - Fir St. 190",
            "Vince Riley 23 - Fir St. 96",
            "Alice Penny 55 - Cherry St. 92",
        };
        /*
        // Create a pool for user registrations, associating user ID with full names and addresses
        private Dictionary<int, string> registrationIdentity = new Dictionary<int, string>();

        // Possible default names and addresses for generating identities
        private string[] DEFAULT_NAMES =
        {
            "John", "Jane", "Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Hank",
            "Ivy", "Jack", "Kathy", "Leo", "Mona", "Nate", "Olivia", "Paul", "Quincy", "Rachel",
            "Sam", "Tina", "Uma", "Vince", "Wendy", "Xander", "Yara", "Zack",
            "Aaron", "Beth", "Cody", "Daisy", "Ethan", "Fiona", "Gavin", "Holly", "Ian", "Jill",
            "Kevin", "Lily", "Mason", "Nina", "Owen", "Penny", "Quinn", "Riley", "Sean", "Tara",
            "Ulysses", "Vera", "Will", "Xenia", "Yosef", "Zoe"
        };

        private string[] DEFAULT_ADDRESSES =
        {
            "Main St.", "Oak St.", "Pine St.", "Maple St.", "Cedar St.", "Elm St.", "Birch St.", "Walnut St.",
            "Chestnut St.", "Spruce St.", "Willow St.", "Ash St.", "Poplar St.", "Hickory St.", "Sycamore St.",
            "Cherry St.", "Magnolia St.", "Dogwood St.", "Fir St.", "Hemlock St."
        };

        public void RegisterDefaults()
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

        public void BackMenu(string msg)
        {
            byte seconds = 3;
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{msg} Returning to menu... {seconds}");
                --seconds;
            }
        }

        public void StartMenu()
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

        private void Register()
        {
            Console.WriteLine("Enter phone number to register:");

            string input = int.Parse(Console.ReadLine()).ToString();
            if (input.Length != 8)
            {
                BackMenu("Invalid input.");
            }



        }

        private void FindUser()
        {
            Console.Write("Search index: ");

        }

        private void ShowAll()
        {
            Console.WriteLine("Registered Users:\n");
            for (int i; i < identities.Length; i++)
            {
                Console.WriteLine($"- {identities[id]}");
            }
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Generate and register default users and identities
            //functions.RegisterDefaults();
            do
            {
                Functions.StartMenu();
            }
            while (true);

            Console.ReadLine();
        }
    }
}

/*
 * Function Class
 * TODO: Associate numbers with identities
 * 
 * 
 * Register()
 * TODO: input, validation
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
 * 
 * Main()
 * TODO: 
*/