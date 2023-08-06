using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class PhoneBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("1. Get Name With Number");
                Console.WriteLine("2. Get Number With Name");
                Console.WriteLine("3. Add User in The PhoneBook");
                Console.WriteLine("4. Delete User from PhoneBook");
                Console.WriteLine("5. Show all Users");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Type What you want to do: ");

                var userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    Console.WriteLine("Type Number : ");
                    var number = Console.ReadLine();
                    string userfullname = GetNameWithNumber(PhoneBook, number);
                    Console.WriteLine(userfullname);

                }

                if (userInput == "2")
                {
                    Console.WriteLine("Type Full Name : ");
                    var fullname = Console.ReadLine();
                    string usernumber = GetNumberWithName(PhoneBook, fullname);
                    Console.WriteLine(usernumber);

                }

                if (userInput == "3")
                {
                    Console.WriteLine("Type New Username's Full Name :");
                    string fullName = Console.ReadLine();
                    Console.WriteLine("Type New Username's Phone Number :");
                    string phoneNumber = Console.ReadLine();
                    AddUser(PhoneBook, fullName, phoneNumber);

                }

                if (userInput == "4")
                {
                    Console.WriteLine("Type Name of an User Which you want to Remove from The Phonebook");
                    string deletedUser = Console.ReadLine();
                    DeleteUser(PhoneBook, deletedUser);
                }

                if (userInput == "5")
                {
                    DisplayAllUsers(PhoneBook);
                }

                if (userInput == "6")
                {
                    Console.WriteLine("Bye");
                    break;
                }

            }
        }

        public static string GetNameWithNumber(Dictionary<string, string> phoneBook, string number)
        {
            foreach(string key in phoneBook.Keys)
            {
                if(phoneBook[key] == number)
                {
                    return key;
                }
            }
            return "Not Found";
        }

        public static string GetNumberWithName(Dictionary<string, string> phoneBook, string fullname)
        {
            if (phoneBook.ContainsKey(fullname))
            {
                return phoneBook[fullname];
            }
            return "No such Number was found with that Name...";
            
        }

        public static void AddUser(Dictionary<string, string> phoneBook,string fullname, string number)
        {
            phoneBook[fullname] = number;
            Console.WriteLine("New User Succesfully Added!");
        }

        public static void DeleteUser (Dictionary<string, string> phoneBook, string userfullname)
        {
            phoneBook.Remove(userfullname);
            Console.WriteLine("Successfully Deleted from The List!");
        }

        public static void DisplayAllUsers(Dictionary<string, string> phoneBoook)
        {
            foreach (var pair in phoneBoook)
            {
                Console.WriteLine($"Full Name : {pair.Key}     Phone Number : {pair.Value}");
            }
        }

    }
}