
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

		void OpenProfession(StackLayout prof)
		{
			var ProfNumber = prof.StyleId.Remove(0, 4);
			Navigation.PushAsync(new ProfessionPages.ProfPage(ProfNumber));
			/*
		switch (prof.StyleId)
		{
			case "Prof1": Navigation.PushAsync(new ProfessionPages.Professions("1"));
				break;
			case "Prof2": Navigation.PushAsync(new ProfessionPages.Professions("2"));
				break;
			case "Prof3": Navigation.PushAsync(new ProfessionPages.Professions("3"));
				break;
			case "Prof4": Navigation.PushAsync(new ProfessionPages.Professions("4"));
				break;
			case "Prof5": Navigation.PushAsync(new ProfessionPages.Professions("5"));
				break;
			case "Prof6": Navigation.PushAsync(new ProfessionPages.Professions("6"));
				break;
			case "Prof7": Navigation.PushAsync(new ProfessionPages.Professions("7"));
				break;
			case "Prof8": Navigation.PushAsync(new ProfessionPages.Professions("8"));
				break;
			case "Prof9": Navigation.PushAsync(new ProfessionPages.Professions("9"));
				break;
			case "Prof10": Navigation.PushAsync(new ProfessionPages.Professions("10"));
				break;
			case "Prof11": Navigation.PushAsync(new ProfessionPages.Professions("11"));
				break;
			case "Prof12": Navigation.PushAsync(new ProfessionPages.Professions("12"));
				break;
			case "Prof13": Navigation.PushAsync(new ProfessionPages.Professions("13"));
				break;
			case "Prof14": Navigation.PushAsync(new ProfessionPages.Professions("14"));
				break;
			case "Prof15": Navigation.PushAsync(new ProfessionPages.Professions("15"));
				break;
			case "Prof16": Navigation.PushAsync(new ProfessionPages.Professions("16"));
				break;
			case "Prof17": Navigation.PushAsync(new ProfessionPages.Professions("17"));
				break;
			case "Prof18": Navigation.PushAsync(new ProfessionPages.Professions("18"));
				break;
			case "Prof19": Navigation.PushAsync(new ProfessionPages.Professions("19"));
				break;
			case "Prof20": Navigation.PushAsync(new ProfessionPages.Professions("20"));
				break;
			case "Prof21": Navigation.PushAsync(new ProfessionPages.Professions("21"));
				break;
			case "Prof22": Navigation.PushAsync(new ProfessionPages.Professions("22"));
				break;
		}*/
		}
	}
}