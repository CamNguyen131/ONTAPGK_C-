using ONTAP;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Chuong trinh quan ly san pham\n");

        ProductService service = new ProductService();

        service.ShowAll();

        service.PriceGreater500();

        service.Statistics();

        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}