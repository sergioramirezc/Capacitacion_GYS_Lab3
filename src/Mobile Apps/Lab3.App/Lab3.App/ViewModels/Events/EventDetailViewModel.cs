using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab3.App.ViewModels.Events
{
    public class EventDetailViewModel : Base.ViewModelBase
    {
        public EventDetailViewModel()
        {
            ViewMoreCommand = new Command(() => ViewMore());
            FavoriteCommand = new Command(() => Favorite());
        }

        private Models.Events.Event _event;

        public Models.Events.Event Event
        {
            get { return _event; }
            set
            {
                _event = value;
                RaisePropertyChanged(() => Event);
            }
        }

        public ICommand ViewMoreCommand { get; set; }
        public ICommand FavoriteCommand { get; set; }

        private async Task ViewMore()
        {
            DetailModalShow = !DetailModalShow;
        }

        private async Task Favorite()
        {
            Event.IsFavorite = !Event.IsFavorite;
        }

        private bool _detailModalShow = false;

        public bool DetailModalShow
        {
            get { return _detailModalShow; }
            set
            {
                _detailModalShow = value;
                RaisePropertyChanged(() => DetailModalShow);
            }
        }


        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;
            try
            {
                await base.InitializeAsync(navigationData);
                if (navigationData is Models.Events.Event)
                {
                    Event = navigationData as Models.Events.Event;
                }
            }
            catch (Exception)
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
