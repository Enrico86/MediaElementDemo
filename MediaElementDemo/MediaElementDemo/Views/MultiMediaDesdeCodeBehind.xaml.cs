using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MediaElementDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiMediaDesdeCodeBehind : ContentPage
    {
        public MultiMediaDesdeCodeBehind()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var uri = new Uri("https://sec.ch9.ms/ch9/5d93/a1eab4bf-3288-4faf-81c4-294402a85d93/XamarinShow_mid.mp4");
            mediaElement.Source = MediaSource.FromUri(uri);

            mediaElement2.Source = MediaSource.FromFile("Recuerdame_CocoDisneyLetra.mp3");
        }

    }
}