using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace vs2019.Views
{
    public partial class MyMaterialPage : ContentPage
    {
        public MyMaterialPage()
        {
            InitializeComponent();

        }

        public async void Handle_Clicked (object sender, EventArgs e)
        {
            await Xamarin.Essentials.Browser.OpenAsync("https://visualstudio.microsoft.com/");
        }
    }
}
