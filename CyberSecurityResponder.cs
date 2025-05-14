using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public static class CyberSecurityResponses
    {
        public static string GetAnswer(string question)
        {
            question = question.ToLower();

            if (question.Contains("password"))
            {
                return "A strong password should be at least 12-16 characters long. Use uppercase, lowercase, numbers, and special symbols.\n" +
                       "Avoid using common words or predictable patterns. Consider using a password manager.";
            }
            else if (question.Contains("phishing") || question.Contains("scam") || question.Contains("fraud"))
            {
                return "Phishing emails trick users into revealing personal information. Look out for:\n" +
                       "- Urgent language (e.g., 'Your account will be closed!')\n" +
                       "- Suspicious links (hover over links before clicking)\n" +
                       "- Poor grammar or unfamiliar senders\n" +
                       "Always verify emails by contacting the company directly.";
            }
            else if (question.Contains("hackers") || question.Contains("cyber attack") || question.Contains("hacked"))
            {
                return "To protect yourself from hackers:\n" +
                       "- Keep your software and OS updated\n" +
                       "- Use two-factor authentication (2FA)\n" +
                       "- Avoid public Wi-Fi for sensitive transactions\n" +
                       "- Monitor your accounts for suspicious activity";
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
            else
            {
                return "I'm not sure about that, but always be cautious online! 😊\n" +
                       "Try asking about passwords, phishing, firewalls, malware, social media safety, VPNs, or data breaches.";
            }
        }
    }
}
