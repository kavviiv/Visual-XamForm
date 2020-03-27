using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Al.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Complete : ContentPage
    {
        public Complete()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cataloge());
        }
    }
}