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
            DisplayAlert("О разработчике", "Разрабочик: Осокин Тимофей Сергеевич.\n" +
                                           "Заказчик: Бийский государственный колледж","Ок");
        }
    }
}
