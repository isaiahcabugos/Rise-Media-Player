﻿using Rise.App.Helpers;
using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Rise.App.Settings
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OnlineServicesPage : Page
    {

        internal static OnlineServicesPage Current;
        public OnlineServicesPage()
        {
            this.InitializeComponent();
            Current = this;
        }

        internal bool AccountMenuText
        {
            get => LastFMStatus.IsEnabled;
            set => LastFMStatus.IsEnabled = value;
        }
        private async void LastFmFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await LastFMHelper.LogIn();
                LastFMStatus.IsEnabled = false;
            }
            catch (Exception e1)
            {
                Debug.WriteLine(e1.Message);
            }
        }
    }
}
