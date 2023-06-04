using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyBGC;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class OrderHelpWarning : ContentPage
{
    public OrderHelpWarning()
    {
        InitializeComponent();
        TapGestureRecognizer tapMaps = new TapGestureRecognizer
        {
            NumberOfTapsRequired = 1
        };
        tapMaps.Tapped += (s, e) =>
        {
            OpenMapsAsync();
        };
        corp1.GestureRecognizers.Add(tapMaps);

        TapGestureRecognizer tapCheck = new TapGestureRecognizer
        {
            NumberOfTapsRequired = 1
        };
        tapCheck.Tapped += (s, e) =>
        {
            CheckRule.IsChecked = !CheckRule.IsChecked;
        };
        CheckRuleLabel.GestureRecognizers.Add(tapCheck);
    }

    async Task OpenMapsAsync()
    { 
        await Launcher.OpenAsync("geo:52.517360140738894,85.15646159648895?q=Бийский+государственный+колледж+");
    }
    
    private void Ok_OnClicked(object sender, EventArgs e)
    {
        if (CheckRule.IsChecked)
        {
            Navigation.PushAsync(new OrderHelp());
            CheckRule.IsChecked = false;
        }
        else
        {
            DisplayAlert("Ошибка", "Вы не согласились с правилами", "ОК");
        }
    }
}