using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    enum Audience { World,Group,Special }
    class TikTok
    {   //Field
        private static int _ID=0;
        //Properties
        public string Originator { get; }
        public int Length { get; }
        public string HashTag { get; }
        public Audience Audience { get; }
        public string Id { get; }
        //Public Constructor
        public TikTok(string originator, int length, string hashTag,Audience audience)
        {
            this.Originator = originator;
            this.Length = length;
            this.HashTag = hashTag;
            this.Audience = audience;
            Id = Convert.ToString(_ID++);
        }
        //Constructor overloaded with ID
        public TikTok(string id, string originator, int length, string hashTag, Audience audience)
        {
            this.Id = id;
            this.Originator = originator;
            this.Length = length;
            this.HashTag = hashTag;
            this.Audience = audience;
           
        }

        public static TikTok Parse(string stringToParse)
        {
            string[] tiktok =stringToParse.Split('\t');
            TikTok result = new TikTok(tiktok[0], tiktok[1],Convert.ToInt32(tiktok[2]), tiktok[3],Audience.World);
            return result;
        }
        //Method
        public override string ToString()
        {
            return $"{Id},{Originator},{Length},{HashTag},{Audience}";
        }

    }
}