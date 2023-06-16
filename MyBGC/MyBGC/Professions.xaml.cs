
using MyBGC.ProfessionPages;

namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Professions : ContentPage
	{
		public Professions ()
		{
			InitializeComponent ();
			TapGestureRecognizer tapProf = new TapGestureRecognizer();
			tapProf.Tapped += (s, e) =>
			{
				
				Navigation.PushAsync(new ProfPage(((StackLayout)s).StyleId));
			
			};
			Prof1.GestureRecognizers.Add(tapProf);
			Prof2.GestureRecognizers.Add(tapProf);
			Prof3.GestureRecognizers.Add(tapProf);
			Prof4.GestureRecognizers.Add(tapProf);
			Prof5.GestureRecognizers.Add(tapProf);
			Prof6.GestureRecognizers.Add(tapProf);
			Prof7.GestureRecognizers.Add(tapProf);
			Prof8.GestureRecognizers.Add(tapProf);
			Prof9.GestureRecognizers.Add(tapProf);
			Prof10.GestureRecognizers.Add(tapProf);
			Prof11.GestureRecognizers.Add(tapProf);
			Prof12.GestureRecognizers.Add(tapProf);
			Prof13.GestureRecognizers.Add(tapProf);
			Prof14.GestureRecognizers.Add(tapProf);
			Prof15.GestureRecognizers.Add(tapProf);
			Prof16.GestureRecognizers.Add(tapProf);
			Prof17.GestureRecognizers.Add(tapProf);
			Prof18.GestureRecognizers.Add(tapProf);
			Prof19.GestureRecognizers.Add(tapProf);
			Prof20.GestureRecognizers.Add(tapProf);
			Prof21.GestureRecognizers.Add(tapProf);
			Prof22.GestureRecognizers.Add(tapProf);
		}
	}
}