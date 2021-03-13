﻿using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace lab6n7
{
    public static class Serialization
    {
        public static void Serialize(Advert ad)
        {
            List<Advert> advertsForSerialize;
            advertsForSerialize = Deserialize();
            advertsForSerialize.Add(ad);
            XmlSerializer xmlf = new XmlSerializer(advertsForSerialize.GetType());

            using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
            {
                xmlf.Serialize(fs, advertsForSerialize);
            }
        }

        public static List<Advert> Deserialize()
        {
            if (File.Exists("data.xml"))
            {
                List<Advert> advertsForSerialize = new List<Advert>();

                XmlSerializer xmlf = new XmlSerializer(advertsForSerialize.GetType());

                using (FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate))
                {
                    advertsForSerialize = (List<Advert>)xmlf.Deserialize(fs);
                }

                return advertsForSerialize;
            }
            else return new List<Advert>();
        }
    }
}
