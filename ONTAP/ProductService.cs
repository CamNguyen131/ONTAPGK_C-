using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ONTAP
{
    public class ProductService
    {
        public List<Product> products = new List<Product>()
    {
        new Product{Id=1, Name="Laptop", Price=1500, Category="Electronics"},
        new Product{Id=2, Name="Mouse", Price=200, Category="Electronics"},
        new Product{Id=3, Name="Keyboard", Price=350, Category="Electronics"},
        new Product{Id=4, Name="Phone", Price=900, Category="Electronics"},
        new Product{Id=5, Name="Table", Price=700, Category="Furniture"},
        new Product{Id=6, Name="Chair", Price=400, Category="Furniture"}
    };

        public void ShowAll()
        {
            Console.WriteLine("===== DANH SACH SAN PHAM =====");

            foreach (var p in products)
            {
                p.Show();
            }
        }

        public void PriceGreater500()
        {
            Console.WriteLine("\nSan pham gia > 500");

            var result = products.Where(p => p.Price > 500);

            foreach (var p in result)
            {
                p.Show();
            }
        }

        public void Statistics()
        {
            double total = products.Sum(p => p.Price);
            double avg = products.Average(p => p.Price);

            Console.WriteLine("\n===== THONG KE =====");
            Console.WriteLine("Tong gia tri: " + total);
            Console.WriteLine("Gia trung binh: " + avg);
        }
    }
}
