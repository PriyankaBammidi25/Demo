using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class sentence
    {
        static void Main(string[] args)
        {
            string sentence = "This sentence has five words.";
            // Extract the second word.
           // int startPosition = sentence.IndexOf(" ") + 1;
            //string word2 = sentence.Substring(startPosition,
                                              //sentence.IndexOf(" ", startPosition) - startPosition);
            string[] s = sentence.Split();
            Console.WriteLine(s[4]);
            // Console.WriteLine("Second word: " + word2);
            // The example displays the following output:
            //       Second word: sentence
            Console.Read();
        }
    }
}
