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
	public partial class EventDetailView : ContentPage
	{
		public EventDetailView ()
		{
			InitializeComponent ();
		}

        private async void Image_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == Image.SourceProperty.PropertyName)
            {
                var image = sender as Image;
                await image.ScaleTo(.6, 400, Easing.BounceOut);
                await image.ScaleTo(1, 400, Easing.BounceIn);
            }
        }
    }
}