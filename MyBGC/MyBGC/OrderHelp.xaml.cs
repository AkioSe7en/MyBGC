namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderHelp : ContentPage
	{
		public OrderHelp ()
		{
			InitializeComponent ();
            TapGestureRecognizer tapCheck1 = new TapGestureRecognizer();
            tapCheck1.Tapped += (s, e) =>
            {
                Check1.IsChecked = !Check1.IsChecked;
            };
            Check1Label.GestureRecognizers.Add(tapCheck1);
            
            TapGestureRecognizer tapCheck2 = new TapGestureRecognizer();
            tapCheck2.Tapped += (s, e) =>
            {
                Check2.IsChecked = !Check2.IsChecked;
            };
            Check2Label.GestureRecognizers.Add(tapCheck2);
            
            TapGestureRecognizer tapCheck3 = new TapGestureRecognizer();
            tapCheck3.Tapped += (s, e) =>
            {
                Check3.IsChecked = !Check3.IsChecked;
            };
            Check3Label.GestureRecognizers.Add(tapCheck3);
            
            TapGestureRecognizer tapCheck4 = new TapGestureRecognizer();
            tapCheck4.Tapped += (s, e) =>
            {
                Check4.IsChecked = !Check4.IsChecked;
            };
            Check4Label.GestureRecognizers.Add(tapCheck4);
            
		}

        private void CheckBoxVoenkom_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            VoenkomEntry.IsVisible = ((CheckBox)sender).IsChecked;
        }

        private void CheckBoxStipend_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            StipendEntry.IsVisible = ((CheckBox)sender).IsChecked;
        }

        private void Count_OnTextChanged(object sender, TextChangedEventArgs e)
        {
           var numberSTR = ((Entry)sender).Text;

           numberSTR = numberSTR.Replace(",", "");
           var checkNum= int.TryParse(numberSTR, out int number);
            if (number<Stepper.Minimum && checkNum)
            {
               numberSTR = Stepper.Minimum.ToString();
            }
            if (number>Stepper.Maximum && checkNum)
            {
                numberSTR = Stepper.Maximum.ToString();
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