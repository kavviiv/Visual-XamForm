﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Al.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cataloge : ContentPage
    {
        public Cataloge()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirm());
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirm());
        }

        async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirm());
        }

        async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirm());
        }

        async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Confirm());
        }
    }
}