﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MarcTron.Plugin.Controls
{
    // ReSharper disable once InconsistentNaming
    public class MTAdView : View
    {
        public event EventHandler AdsClicked;
        public event EventHandler AdsClosed;
        public event EventHandler AdsImpression;
        public event EventHandler AdsOpened;
        public event EventHandler AdsFailedToLoad;
        public event EventHandler AdsLeftApplication;
        public event EventHandler AdsLoaded;

        public static readonly BindableProperty AdsIdProperty = BindableProperty.Create("AdsId", typeof(string), typeof(MTAdView));

        public string AdsId
        {
            get => (string)GetValue(AdsIdProperty);
            set => SetValue(AdsIdProperty, value);
        }

        public static readonly BindableProperty PersonalizedAdsProperty = BindableProperty.Create("PersonalizedAds", typeof(bool), typeof(MTAdView));

        public bool? PersonalizedAds
        {
            get => (bool?)GetValue(PersonalizedAdsProperty);
            set => SetValue(PersonalizedAdsProperty, value);
        }

        public static readonly BindableProperty ComplyFamilyPoliciesProperty = BindableProperty.Create("ComplyFamilyPolicies", typeof(bool), typeof(MTAdView));
        public bool? ComplyFamilyPolicies
        {
            get => (bool?)GetValue(ComplyFamilyPoliciesProperty);
            set => SetValue(ComplyFamilyPoliciesProperty, value);
        }

        public static readonly BindableProperty CustomParametersProperty = BindableProperty.Create("CustomParameters", typeof(Dictionary<string, string>), typeof(MTAdView));
        public Dictionary<string, string> CustomParameters
        {
            get => (Dictionary<string, string>)GetValue(CustomParametersProperty);
            set => SetValue(CustomParametersProperty, value);
        }

        internal void AdClicked(object sender, EventArgs e)
        {
            AdsClicked?.Invoke(sender,e);
        }

        internal void AdClosed(object sender, EventArgs e)
        {
            AdsClosed?.Invoke(sender, e);
        }

        internal void AdImpression(object sender, EventArgs e)
        {
            AdsImpression?.Invoke(sender, e);
        }

        internal void AdOpened(object sender, EventArgs e)
        {
            AdsOpened?.Invoke(sender, e);
        }

        internal void AdFailedToLoad(object sender, EventArgs e)
        {
            AdsFailedToLoad?.Invoke(sender, e);
        }

        internal void AdLeftApplication(object sender, EventArgs e)
        {
            AdsLeftApplication?.Invoke(sender, e);
        }

        internal void AdLoaded(object sender, EventArgs e)
        {
            AdsLoaded?.Invoke(sender, e);
        }
    }
}
