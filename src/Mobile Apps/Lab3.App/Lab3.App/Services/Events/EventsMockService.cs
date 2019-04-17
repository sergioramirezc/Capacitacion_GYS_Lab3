using System;
using System.Collections.Generic;
using System.Text;
using Lab3.App.Models.Events;

namespace Lab3.App.Services.Events
{
    public class EventsMockService : IEventsService
    {
        List<Event> Events = new List<Event>()
        {
            new Event() { Id = 1, Name = "La yunza - ayacucho 2019", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/119517/5c34e9e9d4877.jpg", Address = "Av Javier Heraud 291", Price = 50, Date = new DateTime(2019,04,21), IsFavorite = false, Description = "" },
            new Event() { Id = 1, Name = "La Candelaria semana santa Paracas", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/19132/5c81966fbcba5.jpg", Address = "Hotel sole Paracas", Price = 50, Date = new DateTime(2019,04,22), IsFavorite = true, Description = "" },
            new Event() { Id = 1, Name = "La yunza - ayacucho 2019", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/119517/5c34e9e9d4877.jpg", Address = "Av Javier Heraud 291", Price = 50, Date = new DateTime(2019,04,21), IsFavorite = true, Description = "" },
            new Event() { Id = 1, Name = "La Candelaria semana santa Paracas", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/19132/5c81966fbcba5.jpg", Address = "Hotel sole Paracas", Price = 50, Date = new DateTime(2019,04,22), IsFavorite = false, Description = "" },
            new Event() { Id = 1, Name = "La yunza - ayacucho 2019", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/119517/5c34e9e9d4877.jpg", Address = "Av Javier Heraud 291", Price = 50, Date = new DateTime(2019,04,21), IsFavorite = false, Description = "" },
            new Event() { Id = 1, Name = "La Candelaria semana santa Paracas", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/19132/5c81966fbcba5.jpg", Address = "Hotel sole Paracas", Price = 50, Date = new DateTime(2019,04,22), IsFavorite = false, Description = "" },
            new Event() { Id = 1, Name = "La yunza - ayacucho 2019", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/119517/5c34e9e9d4877.jpg", Address = "Av Javier Heraud 291", Price = 50, Date = new DateTime(2019,04,21), IsFavorite = false, Description = "" },
            new Event() { Id = 1, Name = "La Candelaria semana santa Paracas", Category = new Models.Category.Category { Name ="Otros"}, ImgUrl = "https://s3-us-west-2.amazonaws.com/joinnus.com/user/19132/5c81966fbcba5.jpg", Address = "Hotel sole Paracas", Price = 50, Date = new DateTime(2019,04,22), IsFavorite = false, Description = "" },
        };

        public List<Event> GetEvents()
        {
            return Events;
        }
    }
}
