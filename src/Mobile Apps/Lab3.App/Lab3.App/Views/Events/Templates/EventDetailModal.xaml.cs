using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3.App.Views.Events.Templates
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventDetailModal : ContentView
	{
		public EventDetailModal ()
		{
			InitializeComponent ();
		}

        protected override async void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == IsVisibleProperty.PropertyName)
            {
                if (IsVisible)
                {
                    Opacity = 0;
                    base.OnPropertyChanged(propertyName);
                    await this.FadeTo(1, 300, Easing.Linear);
                }
                else
                {
                    Opacity = 1;
                    await this.FadeTo(0, 300, Easing.Linear);
                    base.OnPropertyChanged(propertyName);
                }
            }
            else
            {
                base.OnPropertyChanged(propertyName);
            }
        }
    }
}