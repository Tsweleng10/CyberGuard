using System;
using System.ComponentModel.Design;
using System.Media;
using System.Threading;
using ConsoleApp6;

internal class Program
{
   
    public static void Main(string[] args)
    {
        //Declarations
        String name = "";
        int Help;
        int questions;

        Console.ForegroundColor = ConsoleColor.Cyan; // Set initial color

        //ASCII Art
        Console.WriteLine("" +
            "   ______      __              ______                     __\r\n  / ____/_  __/ /_  ___  _____/ ____/_  ______ __________/ /\r\n / /   / / / / __ \\/ _ \\/ ___/ / __/ / / / __ `/ ___/ __  / \r\n/ /___/ /_/ / /_/ /  __/ /  / /_/ / /_/ / /_/ / /  / /_/ /  \r\n\\____/\\__, /_.___/\\___/_/   \\____/\\__,_/\\__,_/_/   \\__,_/   \r\n     /____/                                                 ");

        //Greeting message 
        try
        {
            SoundPlayer sp = new SoundPlayer("Greeting message2.wav");
            sp.Load();
            sp.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing sound: " + ex.Message);
        }


        Console.WriteLine("Enter name");
        while (string.IsNullOrWhiteSpace(name))
        {
            name = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("I'm sorry I didn't get that, please re-enter your name");
            }
        }
        Console.WriteLine($"Welcome,{name}! Let's enhance your Cyber Security awareness.");



        



        while (true)  // Main Menu Loop
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHow may I assist you today?");
            Console.WriteLine("1.) I have a personalized question.");
            Console.WriteLine("2.) Check password strengh");
            Console.WriteLine("3.) Exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out Help) || Help < 1 || Help > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid option (1, 2, or 3).");
                continue;
            }
            if (Help == 3)
            {
                Console.WriteLine($"Goodbye, {name}! Stay safe online. ");
                break;
            }
           
            if (Help == 2)
            {
                Console.Write("\nEnter a password to check: ");
                string pwd = Console.ReadLine();
                string result = PasswordChecker.EvaluateStrength(pwd);
                SimulateTyping(result);
            }

            else if (Help == 1) // Personalized Questions
            {
                Console.WriteLine($"\nHow may I assist you? (Type 'exit' to return to the main menu)");

                string lastTopic = null;

                while (true)
                {
                    Console.Write($"{name}: ");
                    string question = Console.ReadLine()?.ToLower().Trim();

                    if (question == "exit")
                    {
                        Console.WriteLine("Returning to the main menu...\n");
                        break;
                    }

                    string response = CyberSecurityResponses.GetAnswer(question, ref lastTopic);
                    SimulateTyping(response);
                }
            }

            // Function to simulate typing animation
            static void SimulateTyping(string message)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Bot: ");
                foreach (char c in message)
                {
                    Console.Write(c);
                    Thread.Sleep(25); // Typing effect speed
                }
                Console.WriteLine("\n");
                Console.ResetColor();
            }

            // Function to display error messages in red
            static void ShowError(string message)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
        
    }

}
