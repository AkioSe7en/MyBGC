namespace MyBGC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Appeals : ContentPage
	{
		public Appeals ()
		{
			InitializeComponent ();
		}

        private async void Send_OnClicked(object sender, EventArgs e)
        {
            var message = new EmailMessage
            {
                Subject = "ОБРАТНАЯ СВЯЗЬ, "+Subject.Text,
                Body = $"{FIO.Text}, {Number.Text} \n" +
                       $"Адрес: {Address.Text}\n" +
                       $"{Body.Text}\n" +
                       $"{DateTime.Now.AddHours(7) :U}",
                To = new List<string> { NeedInfo.srtEmailForEmails },
            };
            try
            {
            await Email.ComposeAsync(message);
            Subject.Text = "";
            FIO.Text = "";
            Number.Text = "";
            Address.Text = "";
            Body.Text = "";
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