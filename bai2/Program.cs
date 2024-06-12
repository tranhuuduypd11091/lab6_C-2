using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main()
        {
            List<Shop> shops = new List<Shop>
        {
            new Shop { ShopId = 1, ShopName = "Shop A" },
            new Shop { ShopId = 2, ShopName = "Shop B" }
        };

            List<Phone> phones = new List<Phone>
        {
            new Phone { PhoneId = 1, PhoneName = "Phone 1", ShopId = 1 },
            new Phone { PhoneId = 2, PhoneName = "Phone 2", ShopId = 1 },
            new Phone { PhoneId = 3, PhoneName = "Phone 3", ShopId = 2 }
        };

            var queryResult = from shop in shops
                              join phone in phones on shop.ShopId equals phone.ShopId
                              into phoneGroup
                              select new
                              {
                                  ShopName = shop.ShopName,
                                  PhoneNames = phoneGroup.Select(p => p.PhoneName).ToList()
                              };

            foreach (var result in queryResult)
            {
                Console.WriteLine("Shop Name: " + result.ShopName);
                foreach (var phoneName in result.PhoneNames)
                {
                    Console.WriteLine("Phone Name: " + phoneName);
                }
            }
        }
    }
}
