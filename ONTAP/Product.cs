using System;
using System.Collections.Generic;
using System.Text;

namespace ONTAP
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public void Show()
        {
            Console.WriteLine($"{Id} - {Name} - {Price} - {Category}");
        }
    }
}
