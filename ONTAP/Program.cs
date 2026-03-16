using System;
using System.Collections.Generic;
using System.Linq;

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
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01\n");

        // Bài 2: Danh sách sản phẩm
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop", Price=1500, Category="Electronics"},
            new Product{Id=2, Name="Mouse", Price=200, Category="Electronics"},
            new Product{Id=3, Name="Keyboard", Price=350, Category="Electronics"},
            new Product{Id=4, Name="Phone", Price=900, Category="Electronics"},
            new Product{Id=5, Name="Table", Price=700, Category="Furniture"},
            new Product{Id=6, Name="Chair", Price=400, Category="Furniture"}
        };

        // =============================
        // Bài 3 – LINQ
        // =============================

        // 1. Lấy sản phẩm giá > 500
        Console.WriteLine("San pham gia > 500:");
        var expensiveProducts = products.Where(p => p.Price > 500);

        foreach (var p in expensiveProducts)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
        }

        // 2. Sắp xếp theo Price tăng dần
        Console.WriteLine("\nSap xep tang dan theo gia:");

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

        // 4. Tìm kiếm theo tên nhập từ bàn phím
        Console.WriteLine("\nNhap ten san pham can tim:");
        string keyword = Console.ReadLine();

        var searchResult = products
                            .Where(p => p.Name
                            .ToLower()
                            .Contains(keyword.ToLower()));

        Console.WriteLine("Ket qua tim kiem:");

        foreach (var p in searchResult)
        {
            Console.WriteLine(p.Name + " - " + p.Price);
        }

        // =============================
        // Bài 4 – Thống kê
        // =============================

        // Tổng giá trị
        double totalPrice = products.Sum(p => p.Price);

        Console.WriteLine("\nTong gia tri san pham: " + totalPrice);

        // Giá trung bình
        double avgPrice = products.Average(p => p.Price);

        Console.WriteLine("Gia trung binh: " + avgPrice);

        Console.ReadKey();
    }
}