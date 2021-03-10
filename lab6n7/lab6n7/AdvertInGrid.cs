using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace lab6n7
{
    public class AdvertInGrid
    {
        public string FullName { get; set; } // Полное название товара
        public string ShortName { get; set; } // Краткое название товара
        public string Category { get; set; }  // Категория товара
        public double Raiting { get; set; }  // Рейтинг товара
        public decimal Cost { get; set; }  // Цена товара
        public int Amount { get; set; }  // Количество товара на складе
        public ImageSource AdvertImage { get; set; }  // Картинка для отображения в списке
        public List<Picture> Images {get; set;}
    }
}
