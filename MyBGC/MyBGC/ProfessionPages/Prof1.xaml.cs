using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBGC.ProfessionPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Prof1 : ContentPage
{
    public Prof1(string NumProf)
    {
        InitializeComponent();
        WebView.Source = $"http://q9609419.beget.tech/Prof{NumProf}.html";
        
    }
}