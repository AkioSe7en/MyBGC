using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
