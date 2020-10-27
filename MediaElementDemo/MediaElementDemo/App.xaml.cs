﻿using MediaElementDemo.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MediaElementDemo
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            InitializeComponent();

            MainPage = new MultiMediaDesdeCodeBehind();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        
    }
}
