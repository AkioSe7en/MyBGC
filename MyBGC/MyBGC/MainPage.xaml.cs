namespace MyBGC
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("О приложении", "    Разрабочик: Осокин Тимофей Сергеевич.\n" +
                                           "    Заказчик: Бийский государственный колледж\n\n" +
                                           "Приложение было разработано по заказу Карпова Александра Владимировича для БГК\n" +
                                           "    2023 г.","Ок");
        }
    }
}
