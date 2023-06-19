namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{
		public Main ()
		{
            InitializeComponent ();

            List<CarouselViewMain> images = new List<CarouselViewMain>()
            {
                new CarouselViewMain{Title = "Корпус 1\n", Desc = "659305, Алтайский край, г. Бийск, пер. В.Мартьянова, д. 42", ImageURL = "https://www.bgtc.su/wp-content/uploads/2020/07/p1110425.jpg"},
                new CarouselViewMain{Title = "Корпус 2\n", Desc = "659315, Алтайский край, г. Бийск, ул. 8 марта, д. 16", ImageURL = "https://www.bgtc.su/wp-content/uploads/2020/08/apk5.jpeg"},
                new CarouselViewMain{Title = "Корпус 3\n", Desc = "659300, Алтайский край, г. Бийск, пер. Мопровский, д. 27", ImageURL = "https://www.bgtc.su/wp-content/uploads/2020/08/fasad-300x225.jpg"},
                new CarouselViewMain{Title = "Корпус 4\n", Desc = "659316, Алтайский край, г. Бийск ул. Социалистическая, д. 30", ImageURL = "https://www.bgtc.su/wp-content/uploads/2020/07/4-300x169.jpg"},
                new CarouselViewMain{Title = "Центр аграрного\n образования", Desc = "659363, Алтайский край, с. Первомайское,  ул. Октябрьская, д. 22з", ImageURL = "https://www.bgtc.su/wp-content/uploads/2020/07/5-300x225.jpg"},

            };
            CarouselView.ItemsSource = images;
            Device.StartTimer(TimeSpan.FromSeconds(8), (Func<bool>)(() =>
            {
                CarouselView.Position = (CarouselView.Position + 1) % images.Count;
                return true;
            }) );

            List<Image> imagesAllPhotos = new List<Image>
            { 
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta4-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/09/rov-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2021/07/bezymyannyj-1060x460.png"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2020/12/td-kallazhd-1060x460.png"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2020/06/DSCN1603-1_cr-1-1060x460.png"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2020/12/malyarka-1060x460.png"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2020/12/stu-i-otoplenie-1060x460.png"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2020/12/el-1060x460.png"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta6-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta3-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta1-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta5-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta7-1060x460.jpg"},
                new Image{Source = "https://www.bgtc.su/wp-content/uploads/2022/10/lenta8-1060x460.jpg"},
            };
            CarouselAllPhotos.ItemsSource = imagesAllPhotos;
            Device.StartTimer(TimeSpan.FromSeconds(4), (Func<bool>)(() =>
            {
                CarouselAllPhotos.Position = (CarouselAllPhotos.Position + 1) % images.Count;
                return true;
            }) );

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