using System;

using Xamarin.Forms;

namespace newApp
{
	public class FirstScreen : ContentPage
	{
		public FirstScreen(){

			Button b1 = new Button {Text = "Button1",
				//HorizontalOptions = LayoutOptions.StartAndExpand
			};
			Button b2 = new Button {Text = "Button2"};
			Button b3 = new Button{Text = "Button3"} ;
			Button b4 = new Button {Text = "Button4"};

			var relativeLayout = new RelativeLayout();
			relativeLayout.Children.Add(b1,
				xConstraint: Constraint.RelativeToParent(l => l.Bounds.Width/2),
				yConstraint: Constraint.RelativeToParent(l=> l.Bounds.Height/2)
			);

			relativeLayout.Children.Add(b2,
			xConstraint: Constraint.RelativeToView(b1,(l,v)=> v.X-10),
		    yConstraint: Constraint.RelativeToView(b1,(l,v)=> v.Bounds.Bottom+20 ));

			relativeLayout.Children.Add(b3,
			xConstraint: Constraint.RelativeToView(b2,(l,v)=> v.X-10),
			yConstraint: Constraint.RelativeToView(b2,(l,v)=> v.Bounds.Bottom+20 ));

			relativeLayout.Children.Add(b4,
			xConstraint: Constraint.RelativeToView(b3,(l,v)=> v.X-10),
			yConstraint: Constraint.RelativeToView(b3,(l,v)=> v.Bounds.Bottom+20 ));
			

			Device.OnPlatform (iOS: () => {
				relativeLayout.Padding = new Thickness(0,20,0,0);
			});
			
			Content = relativeLayout;

		}
	}

}

