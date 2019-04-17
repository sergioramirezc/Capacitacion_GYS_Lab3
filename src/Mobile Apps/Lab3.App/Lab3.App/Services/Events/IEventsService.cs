using Lab3.App.Models.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.App.Services.Events
{
    public interface IEventsService
    {
        List<Event> GetEvents();
    }
}
