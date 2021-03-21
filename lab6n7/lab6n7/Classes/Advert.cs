using System;
using System.Collections.Generic;
using System.Linq;

namespace lab6n7
{
    public class Advert
    {
        public int ID { get; set; } // Идентификатор объявления
        public string FullName { get; set; } // Полное название товара REGEXP: ^(?i)[a-zа-я0-9-_\s]{3,32}$
        public string ShortName { get; set; } // Краткое название товара REGEXP: ^(?i)[a-zа-я0-9-_\s]{3,16}$
        public string Category { get; set; } // Категория товара
        public double Raiting { get; set; } // Рейтинг товара REGEXP: ^(\d{1},\d{1})$|^(\d{1}|1[0])$
        public decimal Cost { get; set; } // Цена товара REGEXP: ^(\d)$|^(\d*[,]\d{1,2})$
        public int Amount { get; set; } // Количество товара на складе REGEXP: ^(\d{1,20})$
        public List<Picture> Images { get; set; } = new List<Picture>(); // Картинки к объявлению

        public int GetID()
        {
            bool uniquenessFlag = true;
            List<Advert> adList = Serialization.Deserialize();
            int unicID = 0;
            Random rnd = new Random();
            while (uniquenessFlag)
            {
                unicID = rnd.Next(0, 9999);
                var linqQuery = from ad in adList where ad.ID == unicID select ad;
                if (linqQuery.Count() == 0)
                {
                    uniquenessFlag = false;
                }
            }

            return unicID;
        }
    }
}
