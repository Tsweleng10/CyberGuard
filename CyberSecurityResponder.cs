using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class CyberSecurityResponses
    {
        private static readonly string[] phishingtips = new string[]
        {
        "Check the sender’s email address carefully — scammers often use fake domains.",
        "Avoid clicking suspicious links — hover to preview before clicking.",
        "Phishing emails often contain bad grammar or spelling mistakes.",
        "Urgent language like 'Act Now!' is often used to create panic — be cautious.",
        "Never share sensitive info like passwords or credit card numbers via email.",
        "Don’t open unexpected attachments — they might carry malware.",
        "Use two-factor authentication for extra security.",
        "If something feels suspicious, report the email and don't respond."
        };

        private static readonly string[] hackertips = new string[]
       {
            "Keep your software and OS updated to ensure your security is able to handle threats",
            "To protect yourself from hacker Use two-factor authentication (2FA)",
            "Avoid public Wi-Fi for sensitive transactions. to avoid getting hacked",
            "Try to monitor your accounts for suspicious activity to avoid being hacked"
       };
        public static string GetAnswer(string question, ref string lastTopic)
        {
            question = question.ToLower();

            if (question.Contains("phishing"))
            {
                Random rand = new Random();
                int index = rand.Next(phishingtips.Length);
                return phishingtips[index];
            }
            if (question.Contains("password"))
            {
                return "A strong password should be at least 12-16 characters long. Use uppercase, lowercase, numbers, and special symbols.\n" +
                       "Avoid using common words or predictable patterns. Consider using a password manager.";
            }
            else if (question.Contains("hackers") || question.Contains("cyber attack") || question.Contains("hacked"))
            {
                Random rand = new Random();
                int index = rand.Next(hackertips.Length);
                return hackertips[index];
            }
            else if (question.Contains("firewall"))
            {
                return "A firewall acts as a barrier between your device and the internet, blocking unauthorized access.\n" +
                       "Ensure your firewall is enabled, whether it's built into Windows/macOS or provided by security software.";
            }
            else if (question.Contains("malware") || question.Contains("virus") || question.Contains("trojan") || question.Contains("spyware"))
            {
                return "Malware (malicious software) includes viruses, ransomware, and spyware.\n" +
                       "Prevent malware by:\n" +
                       "- Avoiding downloads from unknown sources\n" +
                       "- Keeping antivirus software updated\n" +
                       "- Not clicking suspicious links or attachments";
            }
            else if (question.Contains("vpn") || question.Contains("privacy") || question.Contains("anonymous"))
            {
                return "A VPN (Virtual Private Network) encrypts your internet connection, enhancing privacy.\n" +
                       "Use a VPN when accessing public Wi-Fi to protect your data from hackers.";
            }
            else if (question.Contains("data breach") || question.Contains("leak"))
            {
                return "A data breach occurs when sensitive information is leaked online.\n" +
                       "If your data is compromised:\n" +
                       "- Change affected passwords immediately\n" +
                       "- Enable 2FA on important accounts\n" +
                       "- Monitor for suspicious activity";
            }
            else if (question.Contains("ransomware"))
            {
                return "Ransomware locks your files and demands payment to unlock them.\n" +
                       "To prevent ransomware:\n" +
                       "- Regularly back up your data\n" +
                       "- Avoid clicking suspicious email links or attachments\n" +
                       "- Use updated antivirus protection";
            }
            else if (question.Contains("public wi-fi") || question.Contains("free wi-fi") || question.Contains("open network"))
            {
                return "Public Wi-Fi is risky because hackers can intercept your data. Protect yourself by:\n" +
                       "- Using a VPN\n" +
                       "- Avoiding online banking or shopping\n" +
                       "- Disabling automatic Wi-Fi connections";
            }
            else if (question.Contains("2fa") || question.Contains("two-factor") || question.Contains("multi-factor"))
            {
                return "Two-Factor Authentication (2FA) adds an extra security layer to your accounts.\n" +
                       "It requires a second form of verification, such as a one-time code sent to your phone or email.";
            }
            else if (question.Contains("ddos") || question.Contains("denial of service"))
            {
                return "A DDoS (Distributed Denial of Service) attack floods a website with fake traffic to take it offline.\n" +
                       "Prevent DDoS attacks by using:\n" +
                       "- Cloud-based security services\n" +
                       "- Firewalls and anti-DDoS tools";
            }
            else if (question.Contains("identity theft") || question.Contains("stolen identity"))
            {
                return "Identity theft occurs when someone uses your personal details for fraud.\n" +
                       "Protect yourself by:\n" +
                       "- Not sharing personal info online\n" +
                       "- Monitoring bank and credit reports\n" +
                       "- Using strong, unique passwords for every account";
            }
            else if (question.Contains("updates") || question.Contains("software update") || question.Contains("patch"))
            {
                return "Always install software updates as soon as they are available.\n" +
                       "Updates fix security vulnerabilities that hackers can exploit.";
            }
            else if (question.Contains("smartphone") || question.Contains("mobile security") || question.Contains("android") || question.Contains("iphone"))
            {
                return "To keep your smartphone secure:\n" +
                       "- Install apps only from official stores (Google Play/App Store)\n" +
                       "- Avoid clicking on unknown links\n" +
                       "- Use fingerprint or face recognition instead of a simple PIN";
            }
            else if (question.Contains("dark web") || question.Contains("deep web"))
            {
                return "The dark web is an encrypted part of the internet not indexed by search engines.\n" +
                       "It can be used legally for privacy reasons but is also a hub for illegal activities.\n" +
                       "Never enter personal information on unknown sites.";
            }
            else if (question.Contains("social engineering") || question.Contains("manipulation"))
            {
                return "Social engineering tricks people into revealing sensitive info (e.g., pretending to be tech support).\n" +
                       "Always verify identities before sharing personal or financial details.";
            }
            else if (question.Contains("tell me more") || question.Contains("explain") || question.Contains("more details"))
{               
                //conversation flow
                switch (lastTopic)
                {
                    //phishing
                    case "phishing":
                        return "Here's a Real-life example of phishing:" +
                            "Imagine someone calls you pretending to be from your bank. They sound very official and say your account is locked. They ask you to “confirm” your bank card number and PIN to fix the problem." +
                            "🧠 Cyber version:" +
                            "You get an email that looks like it's from your bank, with their logo and everything, saying “Your account has been compromised, click here to verify.” But the link takes you to a fake website that steals your login info.";


                    //password
                    case "password":
                        return "🏠 Real-Life Example: Password as a House Key\r\nImagine you live in a house that has a locked door. Only you and a few trusted people have the key to get inside. That key is like your password in cybersecurity." +
                            "📍Scenario:" +
                            "🔒 The Lock = Login Page" +
                            "The front door has a lock, just like a website or app has a login screen." +
                            "🔑 The Key = Password" +
                            "You need the correct key (your password) to unlock the door (gain access to your account)" +
                            "👮‍♂️ The Security Guard = The Server" +
                            "Inside your door, there's a guard who checks your key every time. But the guard doesn’t have a list of real keys; instead, they have a special code (a hash of your password) to check against." +
                            "🛠️ What Happens When You Try to Enter:" +
                            "1. You walk to the door and insert your key (you type your password)." +
                            "2. The lock checks if the key fits (the system compares it with the stored hash)." +
                            "3. If the key fits, the door opens (you are granted access)." +
                            "4. If not, the door stays locked." +
                            "🧠 How Do You Stay Safe?" +
                            "Just like you:" +
                            "Use a unique and complicated key (strong password)." +
                            "Change your lock if you think your key was stolen (reset your password)." +
                            "Install a security alarm (use multi-factor authentication like OTPs or fingerprint).";

                    // Privacy
                    case "privacy":
                        return "Okay. Here's a Real-life example:" +
                            "You go to a clinic and share personal health information. You expect the staff to keep it private and not tell anyone else." +
                            "🧠 Cyber version:" +
                            "When you use a social media app, your personal data (location, contacts, habits) should be kept private. But if the app shares or sells your data without your permission, your privacy is being violated.";


                    //Cyber Attack
                    case "cyberattack":
                        return "Real-life example:" +
                            "Someone breaks into your office, smashes your computer, and steals important files." +
                            "A hacker gains access to your company’s server, deletes files, or takes control of your website — that’s a cyber attack. For example, a DDoS attack floods a website with traffic and causes it to crash.🧠 Cyber version:";



                    default:
                        return "Could you clarify what you'd like to know more about?";
                }
            }

            else
            {
                return "I'm not sure about that, but always be cautious online! 😊\n" +
                       "Try asking about passwords, phishing, firewalls, malware, social media safety, VPNs, or data breaches.";
            }
        }
    }
}
