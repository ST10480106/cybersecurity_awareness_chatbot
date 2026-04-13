using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class Program
    {//start of program class
        static void Main(string[] args)
        {//start of main method

            //creating an instance for voice_greeting class
            //with a constructor
            new voice_greeting() { };

            //creating an instance for the ascii_logo class
            //with a constructor
            new ascii_logo() { };

            //creating an instance for the welcome_and_username class
            //with an object name welcome_and_collect
            welcome_and_username welcome_and_collect = new welcome_and_username();

            //calling the method welcome
            welcome_and_collect.welcome();

            //calling the method ask_user to ask the user for name
            string name = welcome_and_collect.ask_user();

        }//end of main method

    }//end of program class
}//end of namespace
