using System;
using System.Collections.Generic;
using System.Linq;

// Bài 1 – Class Product
class Product
{
    public int Id;
    public string Name;
    public double Price;
    public string Category;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Thi Cam Nguyen - 23115053122328 - 225LTC#01\n");

        // Bài 2 – Danh sách 6 sản phẩm
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop", Price=1500, Category="Electronics"},
            new Product{Id=2, Name="Mouse", Price=200, Category="Electronics"},
            new Product{Id=3, Name="Keyboard", Price=350, Category="Electronics"},
            new Product{Id=4, Name="Phone", Price=900, Category="Electronics"},
            new Product{Id=5, Name="Table", Price=700, Category="Furniture"},
            new Product{Id=6, Name="Chair", Price=400, Category="Furniture"}
        };

        Console.WriteLine("===== DANH SACH SAN PHAM =====");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Category}");
        }

        // ===============================
        // Bài 3 – LINQ
        // ===============================

        // 1. Lấy sản phẩm giá > 500
        Console.WriteLine("\nSan pham co gia > 500:");

        var expensiveProducts = products.Where(p => p.Price > 500);

        foreach (var p in expensiveProducts)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
        }

        // 2. Sắp xếp theo giá tăng dần
        Console.WriteLine("\nSap xep theo gia tang dan:");

        var sortedProducts = products.OrderBy(p => p.Price);

        foreach (var p in sortedProducts)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
        }

        // 3. Lấy 3 sản phẩm rẻ nhất
        Console.WriteLine("\n3 san pham re nhat:");

        var cheapestProducts = products
                                .OrderBy(p => p.Price)
                                .Take(3);

        foreach (var p in cheapestProducts)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
        }

        // 4. Tìm kiếm sản phẩm theo tên
        Console.WriteLine("\nNhap ten san pham can tim:");

        string keyword = Console.ReadLine();

        var searchResult = products
                            .Where(p => p.Name
                            .ToLower()
                            .Contains(keyword.ToLower()));

        Console.WriteLine("\nKet qua tim kiem:");

        foreach (var p in searchResult)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
        }

        // ===============================
        // Bài 4 – Thống kê
        // ===============================

        double totalPrice = products.Sum(p => p.Price);
        double avgPrice = products.Average(p => p.Price);

        Console.WriteLine("\n===== THONG KE =====");

        Console.WriteLine("Tong gia tri san pham: " + totalPrice);
        Console.WriteLine("Gia trung binh: " + avgPrice);

        Console.WriteLine("\nNhan phim bat ky de thoat...");
        Console.ReadKey();
    }
}
