using Lab3.App.ViewModels.Base;
using Lab3.App.ViewModels.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3.App.Views.Events
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventListView : ContentPage
	{
		public EventListView ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await (this.BindingContext as ViewModelBase).InitializeAsync(null);
        }
    }
}