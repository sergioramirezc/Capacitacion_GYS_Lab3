using System;
using System.Collections.Generic;
using System.Text;
using Lab3.App.Models.Category;
using Xamarin.Forms.Maps;

namespace Lab3.App.Models.Events
{
    public class Event : ViewModels.Base.ExtendedBindableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public double Price { get; set; }
        public Category.Category Category { get; set; }
        public DateTime Date { get; set; }
        private bool _isFavorite;
        public bool IsFavorite { get { return _isFavorite; } set { _isFavorite = value; RaisePropertyChanged(() => IsFavorite); } }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Position EventPosition { get { return new Position(Latitude, Longitude); } }
    }
}
