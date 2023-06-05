﻿namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Company : ContentPage
	{
		public Company ()
		{
			InitializeComponent ();
			TapGestureRecognizer tapBrowser1 = new TapGestureRecognizer();
			tapBrowser1.Tapped += (s, e) =>
			{
				OpenBrowser1((Label)s);
			};
			Doc3.GestureRecognizers.Add(tapBrowser1);
			Doc4.GestureRecognizers.Add(tapBrowser1);
			Doc7.GestureRecognizers.Add(tapBrowser1);
			Doc8.GestureRecognizers.Add(tapBrowser1);
			Doc9.GestureRecognizers.Add(tapBrowser1);
			Doc10.GestureRecognizers.Add(tapBrowser1);
			Doc11.GestureRecognizers.Add(tapBrowser1);
			Doc12.GestureRecognizers.Add(tapBrowser1);
			Doc15.GestureRecognizers.Add(tapBrowser1);
			Doc16.GestureRecognizers.Add(tapBrowser1);

			TapGestureRecognizer tapBrowser2 = new TapGestureRecognizer();
			tapBrowser2.Tapped += (s, e) =>
			{
				OpenBrowser2((Label)s);
			};
			Doc1.GestureRecognizers.Add(tapBrowser2);
			Doc5.GestureRecognizers.Add(tapBrowser2);
			Doc13.GestureRecognizers.Add(tapBrowser2);
				
			TapGestureRecognizer tapBrowser3 = new TapGestureRecognizer();
			tapBrowser3.Tapped += (s, e) =>
				{
					OpenBrowser3((Label)s);
				};
			Doc2.GestureRecognizers.Add(tapBrowser3);
			Doc6.GestureRecognizers.Add(tapBrowser3);
			Doc14.GestureRecognizers.Add(tapBrowser3);
		}

		private async void OpenBrowser1(Label sender)
		{
			try {
			switch (sender.FormattedText.Spans[0].StyleId)
				{
					case "Doc3":
						await Browser.OpenAsync(new Uri("https://www.bgtc.su/abiturientam/rejting-postupayushhih-2/"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc4":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2022/06/perechen-osnovnyh-professionalnyh-obrazovatelnyh-programm-2022-2023.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc7":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2023/03/perechen-dokumentov-neobhodimyh-dlya-postupleniya.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc8":
						await Browser.OpenAsync(
							new Uri("https://www.bgtc.su/wp-content/uploads/2023/03/inf.-o-prieme-dok-v-el.-forme.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc9":
						await Browser.OpenAsync(
							new Uri("https://www.bgtc.su/wp-content/uploads/2023/03/vstupitelnye-ispytaniya.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc10":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2023/03/osobennosti-provedeniya-vstupitelnyh-ispytanij-dlya-licz-s-ogr.-vozmozhnostyami.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc11":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2022/04/usloviya-priema-na-obuchenie-po-dogovoram-ob-okazanii-platnyh-obrazovatelnyh-uslug.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc12":
						await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2022/04/dogdo22.docx"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc15":
						await Browser.OpenAsync(
							new Uri("http://www.bgtc.su/wp-content/uploads/2021/06/czelevoj-dogovor.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc16":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2022/07/informacziya-po-zaseleniyu-obnovlennaya-na-19.08.2021.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
				}
			}
			catch (Exception ex)
			{
				DisplayAlert("Ошибка", "Невозможно открыть ссылку. Установите браузер", "ОК"); 
			}
		}

		private async void OpenBrowser2(Label sender)
		{
			try
			{
				switch (sender.FormattedText.Spans[1].StyleId)
				{
					case "Doc1":
						await Browser.OpenAsync(
							new Uri("https://www.bgtc.su/wp-content/uploads/2023/04/chislennost-na-01.04.23.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc5":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2023/05/obem-i-struktura-priema-byudzhet.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc13":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2023/03/raschet-stoimosti-na-2023-2024-uchebnyj-god-ochnaya-forma-obucheniya.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
				}
			}
			catch (Exception ex)
			{
				DisplayAlert("Ошибка", "Невозможно открыть ссылку. Установите браузер", "ОК"); 
			}
		}
		
		private async void OpenBrowser3(Label sender)
		{
			try {
				switch (sender.FormattedText.Spans[3].StyleId)
				{
					case "Doc2":
						await Browser.OpenAsync(
							new Uri("https://www.bgtc.su/wp-content/uploads/2023/04/chislennost-na-01.04.23.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc6":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2023/05/obem-i-struktura-priema-dogovor.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
					case "Doc14":
						await Browser.OpenAsync(
							new Uri(
								"https://www.bgtc.su/wp-content/uploads/2023/03/raschet-stoimosti-na-2023-2024-uchebnyj-god-zaochnaya-forma-obucheniya.pdf"),
							BrowserLaunchMode.SystemPreferred);
						break;
				}	
			}
			catch (Exception ex)
			{
				DisplayAlert("Ошибка", "Невозможно открыть ссылку. Установите браузер", "ОК"); 
			}
		}
			
		
	}
}