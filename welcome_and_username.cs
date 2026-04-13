using System;
using System.Threading;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class welcome_and_username
    {//start of welcome_and_username class

        //global variable 
        private string username { get; set; }

        //void method to welcome the user
        public void welcome()
        {//start of the welcome method

            //message to welcome with text color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================================================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            type_words("        WELCOME TO CYBERSECURITY AWARENESS CHATBOT,\n        I AM HERE TO HELP YOU STAY SAFE ONLINE        ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("============================================================");
            Console.WriteLine();
            //reset the color
            Console.ResetColor();

        }//end of the welcome method

        //method to ask for the user name
        public string ask_user()
        {//start of ask_user method

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Cipher: ");
                Console.ResetColor();
                type_words("What is your name?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("User: ");
                Console.ResetColor();
                username = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(username))
                {

                    Thread.Sleep(150);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Cipher: ");
                    Console.ResetColor();
                    type_words("Hello " + username + ", my name is Cipher, How may i help you?");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Cipher: ");
                    Console.ResetColor();
                    type_words("You can type 'exit' if you wish to stop or exit.");
                    return username;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Cipher: ");
                Console.ForegroundColor = ConsoleColor.Red;
                type_words("Please enter a valid name.");
                Console.ResetColor();
            }

        }//end of ask_user method

        //helper method for word-by-word typing effect
        private void type_words(string message)
        {
            string[] words = message.Split(' ');
            foreach (string word in words)
            {
                Console.Write(word + " ");
                Thread.Sleep(150); // Slight delay between words
            }
            Console.WriteLine();
        }

    }//end of welcome_and_username class
}//end of namespace
