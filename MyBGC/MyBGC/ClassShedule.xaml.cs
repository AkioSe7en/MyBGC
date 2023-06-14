namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ClassShedule : ContentPage
	{
		public ClassShedule ()
		{
			InitializeComponent ();
			TapGestureRecognizer tapDoc = new TapGestureRecognizer();
			tapDoc.Tapped += (s, e) =>
			{
				OpenDocs(((Label)s).StyleId);
			};
			Dcorp1.GestureRecognizers.Add(tapDoc);
			Dcorp2.GestureRecognizers.Add(tapDoc);
			Dcorp3.GestureRecognizers.Add(tapDoc);
			Dcorp4.GestureRecognizers.Add(tapDoc);
			Wcorp1.GestureRecognizers.Add(tapDoc);
			Wcorp2.GestureRecognizers.Add(tapDoc);
			Wcorp3.GestureRecognizers.Add(tapDoc);
			Wcorp4.GestureRecognizers.Add(tapDoc);
			DPOБ21.GestureRecognizers.Add(tapDoc); 
			DPOТС11.GestureRecognizers.Add(tapDoc);
			DPOМСД2.GestureRecognizers.Add(tapDoc);
			DPOМСТ1.GestureRecognizers.Add(tapDoc);
			DPOЭЛ2.GestureRecognizers.Add(tapDoc);
			DPOЭЛ2П.GestureRecognizers.Add(tapDoc);
			DPOЭЛ1с.GestureRecognizers.Add(tapDoc);
		}

		async Task OpenDocs(string docname)
		{ 
			try
			{
				switch (docname)
				{
					case "Dcorp1": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/raspisanie/zamena1k.xlsx"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Dcorp2": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2021/03/zamena2k.xlsx"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Dcorp3": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/raspisanie/zamena3k.xlsx"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Dcorp4": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/raspisanie/zamena4k.xlsx"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Wcorp1": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/01/k1.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Wcorp2": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/01/k2.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Wcorp3": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/01/k3.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "Wcorp4": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/01/k4.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOБ21": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/01/avtoshkola.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOТС11": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/04/raspisanie-ts-11.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOМСД2": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/02/raspisanie-msd-2.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOМСТ1": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/02/raspisanie-mst-2.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOЭЛ2": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/02/raspisanie-el-2p.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOЭЛ2П": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/02/raspisanie-el-2.pdf"), BrowserLaunchMode.SystemPreferred);
						break;
					case "DPOЭЛ1с": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/04/raspisanie.pdf"), BrowserLaunchMode.SystemPreferred);
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