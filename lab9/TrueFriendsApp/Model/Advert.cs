using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;

namespace TrueFriendsApp
{
    public class Advert : DependencyObject
    {
        private int id;
        private string shortName;
        private string category;
        private double raiting;
        private decimal cost;
        private Picture image;
        private ImageSource imageSource = null;

        public static readonly DependencyProperty FullNameProperty;
        public static readonly DependencyProperty AmountProperty;

        public int ID // Идентификатор объявления
        { 
            get { return id; } 
            set { id = value; } 
        } 
        public string FullName // Полное название товара
        {
            get { return (string)GetValue(FullNameProperty);}
            set { SetValue(FullNameProperty, value);}
        } 
        public string ShortName // Краткое название товара
        {
            get { return shortName; }
            set { shortName = value; }
        } 
        public string Category // Категория товара
        {
            get { return category; }
            set { category = value; }
        } 
        public double Raiting // Рейтинг товара
        {
            get { return raiting; }
            set { raiting = value; }
        } 
        public decimal Cost // Цена товара
        {
            get { return cost; }
            set { cost = value; }
        } 
        public int Amount // Количество товара на складе
        {
            get { return (int)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        } 
        public Picture Image 
        {
            get { return image; }
            set { image = value; }
        } // Картинка к объявлению

        public ImageSource ImageSource
        {
            get { return imageSource; }
            set { imageSource = value; }
        }

        static Advert()
        {
            FullNameProperty = DependencyProperty.Register("FullName", typeof(string), typeof(Advert));
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            AmountProperty = DependencyProperty.Register("Amount", typeof(int), typeof(Advert), metadata, new ValidateValueCallback(ValidateValue));
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 1000)  // если больше 1000, возвращаем 1000
            {
                MessageBox.Show("CorrectValue", "Мы вам поможем!", MessageBoxButton.OK);
                return 1000;
            }   
            return currentValue; // иначе возвращаем текущее значение
        }

        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
            {
                MessageBox.Show("ValidateValue", "True!", MessageBoxButton.OK);
                return true;
            }
            return false;
        }

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
