using System;
using System.Collections.Generic;
using System.Text;
using Lab3.App.Models.Category;

namespace Lab3.App.Models.Events
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public Category.Category Category { get; set; }
        public DateTime Date { get; set; }
        public bool IsFavorite { get; set; }
        public string Address { get; set; }
    }
}
