using System;

using Xamarin.Forms;

namespace newApp
{
	public class FirstScreen : ContentPage
	{
		public FirstScreen(){

			Button b1 = new Button {Text = "Button1"};
			Button b2 = new Button {Text = "Button2"};
			Button b3 = new Button{Text = "Button3"} ;
			Button b4 = new Button {Text = "Button4"};



			var sl = new StackLayout{
				Children = {b1,b2,b3,b4}
			};

			Content = sl;

			Device.OnPlatform (iOS: () => {
				sl.Padding = new Thickness(0,20,0,0);
			});
			
			

		}
	}

}

