using System;
using System.Collections.Generic;
using System.Text;

namespace Homework16._10
{
    class Advertisement : IComparable
    {
        public string Name { get; set; }
        public string SellerName { get; set; }
        public int Price { get; set; }
        public Category category;

        public override string ToString()
        {
            return $"{Name} {SellerName} {Price}";
        }

        public int CompareTo(object obj)
        {
            return Price.CompareTo(((Advertisement)obj).Price);
        }

        public static bool operator >(Advertisement ad1, Advertisement ad2)
        {
            return ad1.Price > ad2.Price;
        }

        public static bool operator <(Advertisement ad1, Advertisement ad2)
            {
            return ad1.Price < ad2.Price;
            }
    }
    enum Category
    {
        Books = 1, Apartments, Houses, Clothes, Food, Perfume
    }

    

   

}
