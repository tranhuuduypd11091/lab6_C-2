using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> listInt = new List<int> { 3, 6, 8, 1, 25, 200, 210, 201, 205, 207, 5 };
        List<string> listStr = new List<string> { "Hello", "World", "Test", "Example", "Try" };

        // a/ Tìm số chẵn đầu tiên và lớn hơn 5 trong listInt
        var firstEvenGreaterThanFive = listInt.FirstOrDefault(x => x > 5 && x % 2 == 0);
        Console.WriteLine("So chan dau tien lon hon 5 " + firstEvenGreaterThanFive);

        // b/ Tìm phần tử cuối cùng trong listInt có giá trị > 200
        var lastGreaterThan200 = listInt.LastOrDefault(x => x > 200);
        Console.WriteLine("Phan tu cuoi cung trong listInt co gia tri > 200: " + lastGreaterThan200);

        // c/ Tìm phần tử đầu tiên trong listStr có giá trị bắt đầu bằng ký tự “T”
        var firstStartingWithT = listStr.FirstOrDefault(s => s.StartsWith("T"));
        Console.WriteLine("Phan tu dau tien trong listStr bat dau bang ki tu 'T': " + firstStartingWithT);

        // d/ Tính tổng các trị tại vị trí index lẻ và số đó chia hết cho 2 trong listInt
        var sumOfOddIndexDivisibleBy2 = listInt
            .Where((x, index) => index % 2 != 0 && x % 2 == 0)
            .Sum();
        Console.WriteLine("Tong cai tri tai vi tri index le va so do chia het cho 2 " + sumOfOddIndexDivisibleBy2);
    }
}