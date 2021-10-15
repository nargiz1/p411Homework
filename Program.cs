using System;

namespace Homework16._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement ad1 = new Advertisement();
            ad1.Name = "Hunger Games";
            ad1.Price = 15;
            ad1.SellerName = "Ali&Nino";
            ad1.category = Category.Books;
            
            Advertisement ad2 = new Advertisement();
            ad2.Name = "Hunger Games 2";
            ad2.Price = 12;
            ad2.SellerName = "Ali&Nino";
            ad2.category = Category.Books;

            Advertiser adv1 = new Advertiser();
            adv1.UserName = "Kamil";
            adv1.UserSurname = "Memmedov";
            adv1.UserAge = 37;
            adv1.Advert = ad1;

            Advertisement[] arr = new Advertisement[2];
            arr[0] = ad1;
            arr[1] = ad2;
            try
            {
                Array.Sort(arr);
                foreach (Advertisement item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {
                Console.WriteLine("wrong input");
            }

            Console.WriteLine(ad1>ad2);
            Console.WriteLine(ad1.Sum(ad2));

        }

        
    }
}
