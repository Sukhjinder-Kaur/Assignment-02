using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    class TikTokManager
    {
        private static List<TikTok> TIKTOKS;
        private static string FILENAME = "assignment02_tiktok.txt";
       //methods
        static TikTokManager()
        {
            TIKTOKS = new List<TikTok>();
            if (File.Exists(FILENAME))
            {

                TextReader reader = new StreamReader(FILENAME);
                string input = reader.ReadLine();
                while ((input = reader.ReadLine()) != null && input.Length != 0)
                {
                    TikTok tik= TikTok.Parse(input);
                    TIKTOKS.Add(tik);
                }
                reader.Close();
            }
        }

        public static void Initialize()
        {
            TIKTOKS = new List<TikTok>();
            TikTok tikTok1 = new TikTok("1","Viren", 30, "Zeevideo", Audience.Special);
            TIKTOKS.Add(tikTok1);
            TikTok tikTok2 = new TikTok("2","Jacc", 15, "Dogvideo", Audience.World);
            TIKTOKS.Add(tikTok2);
            TikTok tikTok3 = new TikTok("3", "Niran", 60, "Animalvideo", Audience.Group);
            TIKTOKS.Add(tikTok3);
            TikTok tikTok4 = new TikTok("4", "Abhi", 25, "Sadvideo", Audience.Special);
            TIKTOKS.Add(tikTok4);
            TikTok tikTok5 = new TikTok("5", "Shane", 40, "Happyvideo", Audience.World);
            TIKTOKS.Add(tikTok5);
        }
        public static void WriteTiktokToFile()
    {
          
            TextWriter writer = new StreamWriter(FILENAME);
            foreach (TikTok values in TIKTOKS)
            {
                writer.WriteLine(values.Id + "\t" + values.Originator + "\t" + values.Length + "\t" + values.HashTag + "\t" + values.Audience);
            }
            writer.Close();
        }
        public static void Show()
        {
            for (int i = 0; i < TIKTOKS.Count; i++)
            {
                Console.WriteLine(TIKTOKS[i]);
            }
        }
        public static void Show(string tag)
        {
            for (int i = 0; i < TIKTOKS.Count; i++)
            {

                if (TIKTOKS[i].HashTag == "Animalvideo")
                {
                    Console.WriteLine(TIKTOKS[i]);
                }
            }
        }
        public static void Show(int length)
        {
            for (int i = 0; i < TIKTOKS.Count; i++)
            {

                if (TIKTOKS[i].Length > 15)
                {
                    Console.WriteLine(TIKTOKS[i]);
                }
            }
        }
        public static void Show(Audience audience)
        {
            for (int i = 0; i < TIKTOKS.Count; i++)
            {

                if (TIKTOKS[i].Audience == Audience.World)
                {
                    Console.WriteLine(TIKTOKS[i]);
                }
            }
        }
    }
}