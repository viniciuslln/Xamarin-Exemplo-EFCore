﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamExEF.ViewModels;

namespace XamExEF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}