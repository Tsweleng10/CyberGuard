using System;
using System.Media;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
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
            Console.WriteLine("1.) Answer most asked Cyber-Security questions.");
            Console.WriteLine("2.) I have a personalized question.");
            Console.WriteLine("3.) Check password strengh");
            Console.WriteLine("4.) Exit");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nEnter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out Help) || Help < 1 || Help > 4)
            {
                Console.WriteLine("Invalid input. Please enter a valid option (1, 2, 3, or 4).");
                continue;
            }
            if (Help == 4)
            {
                Console.WriteLine($"Goodbye, {name}! Stay safe online. ");
                break;
            }
           
            if (Help == 3)
            {
                CheckPasswordStrength();
            }

            if (Help == 1) // Predefined Questions
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nChoose a question:");
                Console.WriteLine("1.) How can I create a strong password?");
                Console.WriteLine("2.) How can I tell if an email is a phishing scam?");
                Console.WriteLine("3.) How can I protect myself from hackers?");
                Console.WriteLine("4.) Go back to the main menu.");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out questions) || questions < 1 || questions > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (1-4).");
                    continue;
                }
                if (questions == 4) continue; // Go back to the main menu

                string soundFile = questions switch
                {
                1 => "StrongPassword.wav",
                2 => "PhishingEmails.wav",
                3 => "AvoidCyberAttacks.wav",
                _ => null
                };

                if (soundFile != null)
                {
                    try
                    {
                        SoundPlayer sp = new SoundPlayer(soundFile);
                        sp.Load();
                        sp.PlaySync();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error playing sound: " + ex.Message);
                    }
                }
            }

            else if (Help == 2) // Personalized Questions
            {
                Console.WriteLine($"\nHow may I assist you? (Type 'exit' to return to the main menu)");

                while (true)
                {
                    Console.Write($"{name}: ");
                    string question = Console.ReadLine()?.ToLower().Trim();

                    if (question == "exit")
                    {
                        Console.WriteLine("Returning to the main menu...\n");
                        break;
                    }

                    string response = GetCyberSecurityAnswer(question);
                    Console.WriteLine($"Bot: {response}\n");
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

    static string GetCyberSecurityAnswer(string question)
    {
        if (question.Contains("password"))
        {
            return "A strong password should be at least 12-16 characters long, including uppercase, lowercase, numbers, and special characters.";
        }
        else if (question.Contains("phishing"))
        {
            return "Phishing emails often use urgency, fake links, and poor grammar. Avoid clicking suspicious links!";
        }
        else if (question.Contains("hackers"))
        {
            return "Protect yourself by keeping software updated, using two-factor authentication, and avoiding public Wi-Fi.";
        }
        else if (question.Contains("firewall"))
        {
            return "A firewall helps block unauthorized access to your network and should always be enabled.";
        }
        else if (question.Contains("malware"))
        {
            return "Malware is malicious software that can harm your system. Keep your antivirus updated to stay protected.";
        }
        else
        {
            return "Unfortunately, I'm not sure about that, but always be cautious online! 😊";
        }
    }

    static void CheckPasswordStrength()
    {
        Console.Write("\nEnter a password to check its strength: ");
        string password = Console.ReadLine();

        if (password.Length < 8 || !password.Any(char.IsUpper) || !password.Any(char.IsLower) ||
            !password.Any(char.IsDigit) || !password.Any(ch => "!@#$%^&*()".Contains(ch)))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ Weak Password! Use at least 8 characters, mix uppercase, lowercase, numbers, and symbols.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("✅ Strong Password!");
        }
        Console.ResetColor();
    }

}
