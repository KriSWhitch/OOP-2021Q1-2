using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace lab6n7
{
    //[XmlInclude(typeof(BitmapImage))]
    public class Advert
    {
        public string fullName; // Полное название товара
        public string shortName; // Краткое название товара
        public string category; // Категория товара
        public double raiting; // Рейтинг товара
        public decimal cost; // Цена товара
        public int amount; // Количество товара на складе
        public List<Picture> images = new List<Picture>(); // Картинки к объявлению
    }
}
