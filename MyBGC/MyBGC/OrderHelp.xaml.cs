using TdLib;

namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderHelp : ContentPage
	{
		public OrderHelp ()
		{
			InitializeComponent ();
		}

        private void CheckBoxVoenkom_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked)
            {
                VoenkomEntry.IsVisible=true;
            }
            else
            {
                VoenkomEntry.IsVisible = false;
            }
        }

        private void CheckBoxStipend_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (((CheckBox)sender).IsChecked)
            {
                StipendEntry.IsVisible = true;
            }
            else
            {
                StipendEntry.IsVisible = false;
            }
        }

        private void Count_OnTextChanged(object sender, TextChangedEventArgs e)
        {
           var numberSTR = ((Entry)sender).Text;
           // if (numberSTR.EndsWith(","))
           //  {
           //      numberSTR=numberSTR.TrimEnd(',');
           //  }

           numberSTR = numberSTR.Replace(",", "");
           var checkNum= int.TryParse(numberSTR, out int number);
            if (number<1 && checkNum)
            {
               numberSTR = "1";
            }
            if (number>10 && checkNum)
            {
                numberSTR = "10";
            }

            ((Entry)sender).Text = numberSTR;
        }

        private async void Send_OnClicked(object sender, EventArgs e)
        {
            var message = new EmailMessage
            {
                Subject = $"ЗАКАЗ СПРАВКИ: {FIO.Text} {Group.Text}",
                Body = $"Я, {FIO.Text} N:{Number.Text} из группы {Group.Text}, хочу заказать справки в кол-во {Count.Text} шт.: \n"
                ,To = new List<string> { NeedInfo.srtEmailForEmails },
            };

            if (Check1.IsChecked)
            {
                message.Body += $"{Check1Label.Text}\n";
            }
            if (Check2.IsChecked)
            {
                message.Body += $"{Check2Label.Text}, {VoenkomEntry.Text}\n";
            }

            if (Check3.IsChecked)
            {
                message.Body += $"{Check3Label.Text}\n";
            }

            if (Check4.IsChecked)
            {
                message.Body += $"{Check4Label.Text}, за {StipendEntry.Text} мес.\n";
            }
            
            message.Body += $"{DateTime.Now:U}";
            try
            {
                await Email.ComposeAsync(message);
                FIO.Text = "";
                Group.Text = "";
                Count.Text = "";
                Check1.IsChecked = false;
                Check2.IsChecked = false;
                Check3.IsChecked = false;
                Check4.IsChecked = false;

                VoenkomEntry.Text = "";
                StipendEntry.Text = "";
                Number.Text = "";
                await Navigation.PopAsync();
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
    }
}