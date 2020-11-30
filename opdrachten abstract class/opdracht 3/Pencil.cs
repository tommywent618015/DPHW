using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class Pencil : IPencil
    {
        private int maxToWrite = 20; // number of characters to write with a sharpened pencil
        private int nrOfCharsWritten; // number of written characters

        public bool CanWrite { get { return nrOfCharsWritten < maxToWrite; } }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            if (message == "sharpen")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sharpening the pencil...");
                PencilSharpener p = new PencilSharpener();
                p.Sharpen(this);
                Console.ResetColor();
            }
            else
            {
                
                string text = "";
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < message.Length; i++)
                {
                    if (CanWrite)
                    {
                        text += message[i];
                        nrOfCharsWritten++;
                    }
                    else
                    {
                        text += "#";
                    }
                }
                Console.WriteLine(text + nrOfCharsWritten);
                Console.ResetColor();
            }
        }
    }
}
