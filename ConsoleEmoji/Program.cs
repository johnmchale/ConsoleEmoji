using System;
using System.Text;
using System.IO; 

namespace ConsoleEmoji
{
    class Program
    {
        public static void Main()
        {
            
            // creating a comment break line for logging 
            string line = new String('\u263A', 80);  // smiley face, ('\u263A', 80); // coffin 
            Console.WriteLine(line);
            
            using (var writer = new StreamWriter(@"C:\temp\test.txt"))
            {

                writer.WriteLine(line);

                for (var i = 0; i <= 100000; i++)
                {

                    int intValue = i;
                    
                    string hexValue = intValue.ToString("X");

                    string hexvalue2 = hexValue.PadLeft(4, '0');

                    string hexvalue3 = @"U+" + hexvalue2; // n.b  //"263A"; // smiley face 


                    int p = int.Parse(hexvalue3.Substring(2), System.Globalization.NumberStyles.HexNumber);
                    //writer.WriteLine((char)p);
                    
                    if (i % 132 == 0)
                    {
                        writer.WriteLine((char)p);
                    }
                    else
                    {
                        writer.Write((char)p);
                    }

                }

            }
            
            Console.ReadKey();
        }
    }
}
