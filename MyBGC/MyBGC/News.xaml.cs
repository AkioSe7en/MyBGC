using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdLib;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static TdLib.TdApi;
using TdLib.Bindings;

namespace MyBGC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class News : ContentPage
    {
        public News()
        {
            InitializeComponent();
            
        }
    }
}