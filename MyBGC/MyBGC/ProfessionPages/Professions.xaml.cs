using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBGC.ProfessionPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Professions : ContentPage
{
    public Professions(string NumProf)
    {
        InitializeComponent();
        if (Connectivity.NetworkAccess == NetworkAccess.Internet)
        {
            WebView.Source = $"http://q9609419.beget.tech/Prof{NumProf}.html";
        }
        else
        {
            StackLayout Stack = new StackLayout();
            Stack.Children.Add(new Label{Text = "Отсутствует подключение к интернету", HorizontalTextAlignment = TextAlignment.Center, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand});
            this.Content = Stack;
        }
    }
}