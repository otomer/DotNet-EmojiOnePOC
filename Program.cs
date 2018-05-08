using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EmojiPoc
{
    class Program
    {
        public static readonly IList<String> UnicodedEmojies = new ReadOnlyCollection<string>(new List<String>
        {
            "😄", "x", "👨‍👩‍👧‍👦", "🙂", "🐌" , "😃", "💩", "👍", "👍🏻", "Hello😄What'sup"
        });

        static void Main(string[] args)
        {
            Console.WriteLine("EmojiOne POC Intergration");
            Console.WriteLine("-------------------------");

            foreach (var unicode in UnicodedEmojies)
            {
                Console.WriteLine("Unicode: " + unicode);
                var shortName = EmojiOne.EmojiOne.ToShort(unicode);
                if (unicode.Equals(shortName))
                {
                    Console.WriteLine("(x) No shortname");
                }
                else
                {
                    Console.WriteLine("(v) shortname: " + shortName);
                }

                var ascii = EmojiOne.EmojiOne.ShortnameToAscii(shortName);
                if (shortName.Equals(ascii))
                {
                    Console.WriteLine("(x) No ASCII");
                }
                else
                {
                    Console.WriteLine("(v) ASCII: " + ascii);
                }

                Console.WriteLine("");
            }

            Console.WriteLine("Application Ended. Press <Enter> to exit...");
            Console.ReadLine();
        }
    }
}
