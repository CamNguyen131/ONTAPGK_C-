using ONTAP;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Thi Cam Nguyen - 23115053122328 - 225LTC#01\n");

        ProductService service = new ProductService();

        service.ShowAll();
        service.PriceGreater500();
        service.SortByPrice();
        service.ThreeCheapest();
        service.SearchProduct();
        service.Statistics();

        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}