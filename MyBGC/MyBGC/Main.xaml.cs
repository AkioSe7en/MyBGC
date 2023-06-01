using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{
		public Main ()
		{
            InitializeComponent ();
            TapGestureRecognizer tapGesture = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1
            };
            tapGesture.Tapped += (s, e) =>
            {
                OpenMapsAsync((Label)s);
            };
            corp1.GestureRecognizers.Add(tapGesture);
            corp2.GestureRecognizers.Add(tapGesture);
            corp3.GestureRecognizers.Add(tapGesture);
            corp4.GestureRecognizers.Add(tapGesture);
            corp5.GestureRecognizers.Add(tapGesture);
        }

        async Task OpenMapsAsync(Label s)
        {
            switch (s.StyleId)
            {
                case "l1": await Launcher.OpenAsync("geo:52.517360140738894,85.15646159648895?q=Бийский+государственный+колледж+");
                    break;
                case "l2": await Launcher.OpenAsync("geo:52.51428826952712,85.14075994491579?q=Бийский+государственный+колледж+корпус+2");
                    break;
                case "l3": await Launcher.OpenAsync("geo:52.54337918406897,85.22839844226837?q=Бийский+государственный+колледж+корпус+3");
                    break;
                case "l4": await Launcher.OpenAsync("geo:52.49383738925455,85.14074921607973?q=Бийский+государственный+колледж+корпус+4");
                    break;
                case "l5": await Launcher.OpenAsync("geo:52.59497022882498,85.2478337287903?q=52.59497022882498,85.2478337287903(Бийский Государственный колледж, центр аграрного образования)");
                    break;
            }
        }
    }
}