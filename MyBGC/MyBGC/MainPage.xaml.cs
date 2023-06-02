namespace MyBGC
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            
            for (int i = 0; i < 150; i++)
            {
             // stack.Children.Add(new Label{Text = "Строка номер "+i});  
            }
        }
    }
}
