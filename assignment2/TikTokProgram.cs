using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class TikTokProgram
    {
        static void Main(string[] args)
        {
            InputTiktokToFile();
            
            static void InputTiktokToFile()
            {
                TikTokManager.Initialize();
                TikTokManager.WriteTiktokToFile();
            }


            Console.WriteLine("\n\nShow All TikToks");
            TikTokManager.Show();

            string tag = "Animalvideo";
            Console.WriteLine("\n\nTiktok which has a tag, {0}", tag);
            TikTokManager.Show(tag);

            int length=15;
            Console.WriteLine("\n\nTiktok which has a length greater than, {0}", length);
            TikTokManager.Show(length);


            string audience="Audience.World";
            Console.WriteLine("\n\nTiktok which has a audience matching to its argument, {0}", audience);
            TikTokManager.Show(Audience.World);

            Console.ReadLine();
        }
    }
}
