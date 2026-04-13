using System;
using System.Collections;
using System.Threading;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class prompt_and_search
    {//start of class

        //arraylist that will hold keywords
        ArrayList keywords = new ArrayList();
        //arraylist for answers
        ArrayList answers = new ArrayList();
        //for random responses
        ArrayList phishing_tips = new ArrayList();
        Random random_answer = new Random();

        public void aibot(string username)
        {
            load_data();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(username + ": ");
                Console.ResetColor();
                string input = Console.ReadLine().ToLower();

                if (input == "exit") break;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Cipher: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    type_words("Please enter a question to get an answer or type 'exit' if you wish to stop the application");
                    Console.ResetColor();
                    continue;
                }

                search_response(input);
            }
        }

        private void search_response(string input)
        {
            bool found = false;

            //handling Random Responses for Phishing specifically
            if (input.Contains("phishing"))
            {
                int r = random_answer.Next(phishing_tips.Count);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Cipher: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                type_words(phishing_tips[r].ToString());
                found = true;
            }
            else
            {
                //for loop for standard keyword searching
                for (int i = 0; i < keywords.Count; i++)
                {
                    if (input.Contains(keywords[i].ToString()))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Cipher: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        type_words(answers[i].ToString());
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Cipher: ");
                Console.ForegroundColor = ConsoleColor.Red;
                type_words("I didn't quite understand that. Could you rephrase or Ask about passwords or malware.");
            }
            Console.ResetColor();
        }

        //helper method for word-by-word typing effect
        private void type_words(string message)
        {
            string[] words = message.Split(' ');
            foreach (string word in words)
            {
                Console.Write(word + " ");
                Thread.Sleep(150);
            }
            Console.WriteLine();
        }

        private void load_data()
        {
            //basic interaction
            keywords.Add("how are you");
            answers.Add("I am good,a secure bot functioning perfectly. Nothing more i would ask for.");
            keywords.Add("purpose");
            answers.Add("My purpose is to help you stay safe online and try my best to teach you about cybersecurity.");
            keywords.Add("What can i ask you about");
            answers.Add("You can ask me about any topics related to cybersecurity, password safety, phishing, and safe browsing.");

            //cybersecurity basics
            keywords.Add("cybersecurity");
            answers.Add("It's the practice of protecting systems and data from digital attacks.");
            keywords.Add("scam");
            answers.Add("If an offer looks too good to be true, it's likely a scam. Never share OTPs or passwords.");
            keywords.Add("privacy");
            answers.Add("Check your app permissions regularly and limit what you share on social media.");

            //password safety
            keywords.Add("password");
            answers.Add("A strong password is 8+ characters with symbols and is unique for every account.");
            keywords.Add("mfa");
            answers.Add("Multi-factor authentication adds a second layer of security (like a code on your phone).");

            //safe browsing
            keywords.Add("wifi");
            answers.Add("Avoid public Wi-Fi for banking. Use a VPN to encrypt your connection.");
            keywords.Add("vpn");
            answers.Add("A VPN hides your IP address and encrypts your internet traffic.");

            //threats
            keywords.Add("malware");
            answers.Add("It is a malicious software designed to harm your device.");
            keywords.Add("ransomware");
            answers.Add("Ransomware locks your files and demands payment. Always keep backups!");

            //random phishing tips
            phishing_tips.Add("Check for urgent or threatening language in emails.");
            phishing_tips.Add("Look for misspellings in the sender's email address.");
            phishing_tips.Add("Never click links from unknown senders—hover over them first to see the real URL.");
        }

    }//end of class
}//end of namespace
