﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ChromaticMethod
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

		async void Search_Clicked(object sender, System.EventArgs e)
        {
			await Navigation.PushAsync(new Search());
        }

        async void C_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("C"));
        }

        async void D_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("D"));
        }

        async void E_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("E"));
        }

        async void F_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("F"));
        }

        async void G_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("G"));
        }

        async void A_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("A"));
        }

        async void B_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new KeyAnalyzer("B"));
        }

        async void CsDb_Clicked(object sender, System.EventArgs e)
        {
            var CsDb = await DisplayAlert("Enharmonic Equivalents", "Select either C# or Db", "Db", "C#");
            if (CsDb)
            {
                await Navigation.PushAsync(new KeyAnalyzer("Db"));
            }
            else
            {
                await Navigation.PushAsync(new KeyAnalyzer("C#"));
            }
        }

        async void DsEb_Clicked(object sender, System.EventArgs e)
        {
            var DsEb = await DisplayAlert("Enharmonic Equivelants", "Select either D# or Eb", "Eb", "D#");
            if (DsEb)
            {
                await Navigation.PushAsync(new KeyAnalyzer("Eb"));
            }
            else
            {
                await Navigation.PushAsync(new KeyAnalyzer("D#"));
            }
        }

        async void FsGb_Clicked(object sender, System.EventArgs e)
        {
            var FsGb = await DisplayAlert("Enharmonic Equivelants", "Select either F# or Gb", "Gb", "F#");
            if (FsGb)
            {
                await Navigation.PushAsync(new KeyAnalyzer("Gb"));
            }
            else
            {
                await Navigation.PushAsync(new KeyAnalyzer("F#"));
            }
        }

        async void GsAb_Clicked(object sender, System.EventArgs e)
        {
            var GsAb = await DisplayAlert("Enharmonic Equivelants", "Select either G# or Ab", "Ab", "G#");
            if (GsAb)
            {
                await Navigation.PushAsync(new KeyAnalyzer("Ab"));
            }
            else
            {
                await Navigation.PushAsync(new KeyAnalyzer("G#"));
            }
        }

        async void AsBb_Clicked(object sender, System.EventArgs e)
        {
            var AsBb = await DisplayAlert("Enharmonic Equivelants", "Select either A# or Bb", "Bb", "A#");
            if (AsBb)
            {
                await Navigation.PushAsync(new KeyAnalyzer("Bb"));
            }
            else 
            {
                await Navigation.PushAsync(new KeyAnalyzer("A#"));
            }
        }
    }
}
