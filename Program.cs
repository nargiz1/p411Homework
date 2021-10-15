using System;

namespace Homework16._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement ad1 = new Advertisement();
            ad1.Name = "Book";
            ad1.Price = 34;
            ad1.category = Category.Books;
            Advertisement ad2 = new Advertisement();
            ad2.Name = "Book1";
            ad2.Price = 32;

            ad1.Sum(ad2);
            Console.WriteLine(ad1.Sum(ad2));

            Advertisement[] AdArr = new Advertisement[2];
            AdArr[0] = ad1;
            AdArr[1] = ad2;
            Advertiser adv1 = new Advertiser();
            adv1.Advert = ad1;

            try
            {
                Array.Sort(AdArr);
                foreach (Advertisement item in AdArr)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("wrong input");
            }
            
        }

        
    }
}
