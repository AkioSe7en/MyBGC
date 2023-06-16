namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{
		public Main ()
		{
            InitializeComponent ();
            TapGestureRecognizer tapMaps = new TapGestureRecognizer();
            tapMaps.Tapped += (s, e) =>
            {
                OpenMapsAsync((Label)s);
            };
            corp1.GestureRecognizers.Add(tapMaps);
            corp2.GestureRecognizers.Add(tapMaps);
            corp3.GestureRecognizers.Add(tapMaps);
            corp4.GestureRecognizers.Add(tapMaps);
            corp5.GestureRecognizers.Add(tapMaps);
            
            TapGestureRecognizer tapPhone = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1
            };
            tapPhone.Tapped += (s, e) =>
            {
                PhoneDialer.Open(phoneOrg.Text);
            };
            PhoneOrg.GestureRecognizers.Add(tapPhone);
            
            TapGestureRecognizer tapEmail = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1
            };
            tapEmail.Tapped += (s, e) =>
            {
                EmailSendAsync();
            };
            EmailOrg.GestureRecognizers.Add(tapEmail);
           
            TapGestureRecognizer tapSite = new TapGestureRecognizer
            {
                NumberOfTapsRequired = 1
            };
            tapSite.Tapped += (s, e) =>
            {
                OpenBrowser();
            };
            SiteOrg.GestureRecognizers.Add(tapSite);
        }

        async Task EmailSendAsync()
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = "",
                    Body = "",
                    To = new List<string> { emailOrg.Text },
                };
                await Email.ComposeAsync(message);
            }
        catch (FeatureNotSupportedException fbsEx)
        {
            DisplayAlert("Ошибка", "Установите приложение для электронной почты", "ОК");
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", "Неизвестная ошибка, попробуйте еще раз", "ОК");
        }
        }
        
        public async Task OpenBrowser()
        {
            try
            {
                await Browser.OpenAsync(new Uri("http://" + siteOrg.Text + "/"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Ошибка", "Установите браузер", "ОК"); 
            }
        }

        async Task OpenMapsAsync(Label s)
        {
            try
            {
                switch (s.StyleId)
                {
                    case "l1":
                        await Launcher.OpenAsync(
                            "geo:52.517360140738894,85.15646159648895?q=Бийский+государственный+колледж+");
                        break;
                    case "l2":
                        await Launcher.OpenAsync(
                            "geo:52.51428826952712,85.14075994491579?q=Бийский+государственный+колледж+корпус+2");
                        break;
                    case "l3":
                        await Launcher.OpenAsync(
                            "geo:52.54337918406897,85.22839844226837?q=Бийский+государственный+колледж+корпус+3");
                        break;
                    case "l4":
                        await Launcher.OpenAsync(
                            "geo:52.49383738925455,85.14074921607973?q=Бийский+государственный+колледж+корпус+4");
                        break;
                    case "l5":
                        await Launcher.OpenAsync(
                            "geo:52.59497022882498,85.2478337287903?q=52.59497022882498,85.2478337287903(Бийский Государственный колледж, центр аграрного образования)");
                        break;
                }
            }
            catch (Exception ex)
        {
            DisplayAlert("Ошибка", "Установите приложение для открытия карт", "ОК");
        }
        }

        private async void ButVK_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://vk.com/bgk_official_22"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Ошибка", "Установите браузер", "ОК"); 
            }
        }

        private async void ButTG_OnClicked(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://t.me/bgtc_2022"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Ошибка", "Установите браузер", "ОК"); 
            }
        }

        private async void ButOK_OnClicked(object sender, EventArgs e)
        {
            try
            {
            await Browser.OpenAsync(new Uri("https://ok.ru/group/70000001849098"), BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", "Установите браузер", "ОК"); 
        }
        }
    }
}