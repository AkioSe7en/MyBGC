
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
				OpenProfession((StackLayout)s);
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

		void OpenProfession(StackLayout prof)
		{
			switch (prof.StyleId)
			{
				case "Prof1": Navigation.PushAsync(new Prof1());
					break;
				case "Prof2": Navigation.PushAsync(new Prof2());
					break;
				case "Prof3": Navigation.PushAsync(new Prof3());
					break;
				case "Prof4": Navigation.PushAsync(new Prof4());
					break;
				case "Prof5": Navigation.PushAsync(new Prof5());
					break;
				case "Prof6": Navigation.PushAsync(new Prof6());
					break;
				case "Prof7": Navigation.PushAsync(new Prof7());
					break;
				case "Prof8": Navigation.PushAsync(new Prof8());
					break;
				case "Prof9": Navigation.PushAsync(new Prof9());
					break;
				case "Prof10": Navigation.PushAsync(new Prof10());
					break;
				case "Prof11": Navigation.PushAsync(new Prof11());
					break;
				case "Prof12": Navigation.PushAsync(new Prof12());
					break;
				case "Prof13": Navigation.PushAsync(new Prof13());
					break;
				case "Prof14": Navigation.PushAsync(new Prof14());
					break;
				case "Prof15": Navigation.PushAsync(new Prof15());
					break;
				case "Prof16": Navigation.PushAsync(new Prof16());
					break;
				case "Prof17": Navigation.PushAsync(new Prof17());
					break;
				case "Prof18": Navigation.PushAsync(new Prof18());
					break;
				case "Prof19": Navigation.PushAsync(new Prof19());
					break;
				case "Prof20": Navigation.PushAsync(new Prof20());
					break;
				case "Prof21": Navigation.PushAsync(new Prof21());
					break;
				case "Prof22": Navigation.PushAsync(new Prof22());
					break;
			}
		}
	}
}