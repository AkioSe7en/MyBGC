namespace MyBGC.ProfessionPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ProfPage : ContentPage
{
    public ProfPage(string NumProf)
    {
        InitializeComponent();
        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            WebView.Source = $"http://q9609419.beget.tech/{NumProf}.html";
        }
        else
        {
            StackLayout Stack = new StackLayout();
            Stack.Children.Add(new Label{Text = "Отсутствует подключение к интернету", HorizontalTextAlignment = TextAlignment.Center, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand});
            this.Content = Stack;
        }
    }
}