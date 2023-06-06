
namespace MyBGC;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Comission : ContentPage
{
    public Comission()
    {
        InitializeComponent();
        
        TapGestureRecognizer tapMaps = new TapGestureRecognizer();
        tapMaps.Tapped += (s, e) =>
        {
            OpenMapsAsync();
        };
        corp1.GestureRecognizers.Add(tapMaps);
        
        TapGestureRecognizer tapEmail = new TapGestureRecognizer();
        tapEmail.Tapped += (s, e) =>
        {
            EmailSendAsync();
        };
        email.GestureRecognizers.Add(tapEmail);
         
        TapGestureRecognizer tapPhoneDom = new TapGestureRecognizer();
        tapPhoneDom.Tapped += (s, e) =>
        {
            PhoneDialer.Open("8(3854)436215");
        };
        phoneDom.GestureRecognizers.Add(tapPhoneDom);
  
        TapGestureRecognizer tapPhoneSot = new TapGestureRecognizer();
        tapPhoneSot.Tapped += (s, e) =>
        {
            PhoneDialer.Open("89619928173");
        };
        phoneSot.GestureRecognizers.Add(tapPhoneSot);

        TapGestureRecognizer tapVK = new TapGestureRecognizer();
      tapVK.Tapped += (s, e) =>
      {
          OpenVK();
      };
      VK.GestureRecognizers.Add(tapVK);
   
      TapGestureRecognizer tapBrowser = new TapGestureRecognizer();
      tapBrowser.Tapped += (s, e) =>
      {
          OpenBrowser((Label)s);
      };
      NormDoc1.GestureRecognizers.Add(tapBrowser);
      NormDoc2.GestureRecognizers.Add(tapBrowser);
      NormDoc3.GestureRecognizers.Add(tapBrowser);
      NormDoc4.GestureRecognizers.Add(tapBrowser);
      NormDoc5.GestureRecognizers.Add(tapBrowser);
      NormDoc6.GestureRecognizers.Add(tapBrowser);
      NormDoc7.GestureRecognizers.Add(tapBrowser);
    }
    
    public async Task OpenBrowser(Label S)
    {
        try
        {
            switch (S.StyleId)
            {
                case "NormDoc1": await Browser.OpenAsync(new Uri("http://www.bgtc.su/wp-content/uploads/2021/01/ustav-1.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                case "NormDoc2": await Browser.OpenAsync(new Uri("http://www.bgtc.su/wp-content/uploads/2020/09/liczenziya-1.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                case "NormDoc3": await Browser.OpenAsync(new Uri("http://www.bgtc.su/wp-content/uploads/2020/09/svidetelstvo-o-gos-registraczii-1.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                case "NormDoc4": await Browser.OpenAsync(new Uri("http://www.bgtc.su/wp-content/uploads/2021/02/polozhenie-o-priemnoj-komissii.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                case "NormDoc5": await Browser.OpenAsync(new Uri("http://www.bgtc.su/wp-content/uploads/2021/02/polozhenie-o-predm.-ekzamenaczionnoj-komissii.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                case "NormDoc6": await Browser.OpenAsync(new Uri("http://www.bgtc.su/wp-content/uploads/2021/02/pravila-podachi-i-rassmotreniya-appelyaczij.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                case "NormDoc7": await Browser.OpenAsync(new Uri("https://www.bgtc.su/wp-content/uploads/2023/05/pravila-priema-2023.pdf"), BrowserLaunchMode.SystemPreferred);
                    break;
                
            }
            //await Browser.OpenAsync(new Uri("https://vk.com/join.bgtc"), BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", "Невозможно открыть ссылку. Установите браузер", "ОК"); 
        }
    }
    
     async Task EmailSendAsync()
        {
            try
            {
                var message = new EmailMessage
                {
                    To = new List<string> {"priembgc@bgtc.su",}
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
        
        public async Task OpenVK()
        {
            try
            {
                await Browser.OpenAsync(new Uri("https://vk.com/join.bgtc"), BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                DisplayAlert("Ошибка", "Невозможно открыть ссылку. Установите браузер или приложение ВКонтакте", "ОК"); 
            }
        }

        async Task OpenMapsAsync()
        {
            try
            {
                await Launcher.OpenAsync("geo:52.517360140738894,85.15646159648895?q=Бийский+государственный+колледж+");
            }
            catch (Exception ex)
            {
            DisplayAlert("Ошибка", "Установите приложение для открытия карт", "ОК");
            }
        }
}