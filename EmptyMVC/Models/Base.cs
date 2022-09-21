using System;
namespace EmptyMVC.Models
{
    public class Base
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}

