using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace lab6n7
{
    public class Advert
    {
        public string FullName { get; set; } // Полное название товара REGEXP: ^[a-zа-я0-9-_\s]{3,32}$
        public string ShortName { get; set; } // Краткое название товара REGEXP: ^[a-zа-я0-9-_\s]{3,16}$
        public string Category { get; set; } // Категория товара
        public double Raiting { get; set; } // Рейтинг товара REGEXP: ^(([0-9]|1[0]).[0-9]{1})|([0-9]|1[0])$
        public decimal Cost { get; set; } // Цена товара REGEXP: ^((\d{1,20}).(\d{1,2}))|(\d{1,20})$
        public int Amount { get; set; } // Количество товара на складе REGEXP: ^(\d{1,20})$
        public List<Picture> Images { get; set; } = new List<Picture>(); // Картинки к объявлению
    }
}
