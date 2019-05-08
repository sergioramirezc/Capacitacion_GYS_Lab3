using Lab3.App.Extensions;
using Lab3.App.Models.Events;
using Lab3.App.Services.Events;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab3.App.ViewModels.Events
{
    public class EventListViewModel : Base.ViewModelBase
    {
        private readonly IEventsService _eventsService;

        public EventListViewModel(IEventsService _eventsService)
        {
            this._eventsService = _eventsService;
        }

        public async Task SelectedEvent(object item)
        {
            var _event = item as Event;
            Microsoft.AppCenter.Analytics.Analytics.TrackEvent("EventSelected", new Dictionary<string, string> {
                                                                                            {"Name",_event.Name},
                                                                                            {"Price",_event.Price.ToString() }
                                                                                            });
            await NavigationService.NavigateToAsync<EventDetailViewModel>(item);
        }

        private ObservableCollection<Event> _eventList;

        public ObservableCollection<Event> EventList
        {
            get { return _eventList; }
            set
            {
                _eventList = value;
                RaisePropertyChanged(() => EventList);
            }
        }

        public ICommand SelectedEventCommand => new Command<object>((item) => SelectedEvent(item)); 

        public override async Task InitializeAsync(object navigationData)
        {
            try
            {
                IsBusy = true;
                await base.InitializeAsync(navigationData);
                var list = _eventsService.GetEvents();
                EventList = list.ToObservableCollection();
                IsLoaded = true;
            }
            catch (Exception ex)
            {
                var properties = new Dictionary<string, string> {
                    { "Category", "Music" },
                    { "Wifi", "On" }
                  };
                Crashes.TrackError(ex, properties);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
