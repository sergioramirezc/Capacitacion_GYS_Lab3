using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.App.ViewModels.Events
{
    public class EventMapViewModel : Base.ViewModelBase
    {
        private ObservableCollection<Models.Events.Event> _eventPins;

        public ObservableCollection<Models.Events.Event> EventPins
        {
            get { return _eventPins; }
            set
            {
                _eventPins = value;
                RaisePropertyChanged(() => EventPins);
            }
        }

        public override async Task InitializeAsync(object navigationData)
        {
            try
            {
                IsBusy = true;
                await base.InitializeAsync(navigationData);
                var Event = navigationData as Models.Events.Event;
                EventPins = new ObservableCollection<Models.Events.Event>() { Event};
            }
            catch (Exception ex)
            {
                //Do nothing
            }
            finally
            {
                IsBusy = false;
            }

        }
    }
}
