using System;
using System.Collections.Generic;

//Build a console Guest Book.
//Ask the user for their name and how many are in the party
//keep track of how many people are in the party
//print out the guest list and total number of guest





namespace ConsoleUI
{
    class Program
    {
        private static List<string> parties = new List<string>();
        private static int totalGuets = 0;
        static void Main(string[] args)
        {
           
            LoadGuests();

            DisplayGuess();

            DisplayGuestsCount();
            
            Console.ReadLine();
        }

        private static void LoadGuests()
        {
            string moreGuestComing = "";
            do
            {
                string partyName = GetInfosFromConsole("What is the name of your party/group? ");
                parties.Add(partyName);

                totalGuets += GetPartySize();
                DisplayGuestsCount();

                moreGuestComing = GetInfosFromConsole("Do you want to add another guess yes/no ");
            } while (moreGuestComing.ToLower() == "yes");

        }

        private static void DisplayGuess()
        {
            Console.WriteLine();
            Console.WriteLine("Guess Parties at Event");

            foreach (string name in parties)
            {
                Console.WriteLine(name);
            }
        }


        public static void DisplayGuestsCount()
        {
            Console.WriteLine();
            Console.WriteLine($"Total Guest: {totalGuets}");
        }
        private static string GetInfosFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        private static int GetPartySize()
        {
            bool isValidNumber = false;
            int output = 0;
            do
            {
                string partySizeText = GetInfosFromConsole("How many people " +
                                                           "are in your party? ");
                isValidNumber = int.TryParse(partySizeText, out output);
            } while (isValidNumber == false);

            return output;
        }
    }
}
