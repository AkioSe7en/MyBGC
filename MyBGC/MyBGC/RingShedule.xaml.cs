namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RingShedule : ContentPage
	{
		public RingShedule ()
		{
			InitializeComponent ();
            TapGestureRecognizer tapSS = new TapGestureRecognizer {NumberOfTapsRequired = 1};
            tapSS.Tapped += (s, e) =>
            {
                OpenSS();
            };
            SpringSummer.GestureRecognizers.Add(tapSS);
            TapGestureRecognizer tabDist = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
            tabDist.Tapped += (s, e) =>
            {
                OpenDist();
            };
            Distant.GestureRecognizers.Add(tabDist);
        }

        async Task OpenSS()
        {
            await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2022/09/zvonki22.pdf"), BrowserLaunchMode.SystemPreferred);
        }

        async Task OpenDist()
        {
            await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2020/12/zvonki.pdf"), BrowserLaunchMode.SystemPreferred);
        }
    }
}