using System;
using System.Media;
using System.IO;

namespace cybersecurity_awareness_chatbot
{//start of namespace
    public class voice_greeting
    {//start of voice_greeting class
        public voice_greeting()
        {//start of a constructor

            //call the greet method
            greet();

        }//end of a constructor

        //method to play the voice
        private void greet()
        {//start of method greet
            try
            {
                //auto get the path of the voice record
                string paths = AppDomain.CurrentDomain.BaseDirectory;

                //then rename the path
                string fullpath = paths.Replace(@"bin\Debug\", "greet.wav");

                /*should be in the try catch*/
                //load the audio, then play the audio after instance
                SoundPlayer voice_play = new SoundPlayer(fullpath);
                //load the audio
                voice_play.Load();
                //then play it
                voice_play.Play();
            }
            catch (Exception)
            {
                Console.WriteLine("Audio could not play, continuing with text");
            }
        }//end of method greet

    }//end of voice_greeting class
}//end of namespace
