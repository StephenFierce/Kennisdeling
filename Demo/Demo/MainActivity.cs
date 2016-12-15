using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Demo
{
    [Activity(Label = "Demo Kennisdeling", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            DateTime five = DateTime.Parse("17:00:00");
            DateTime startDate = DateTime.Now;
            TimeSpan t = five - startDate;
            string countDown = string.Format("{1} uur, {2} minuten en {3} seconden", t.Hours, t.Minutes, t.Seconds);
            var label = FindViewById<TextView>(Resource.Id.textView3);
            var radio = FindViewById<RadioButton>(Resource.Id.radioButton1);
            var radio2 = FindViewById<RadioButton>(Resource.Id.radioButton2);
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            if (radio.Enabled = true || DateTime.Now >= five)
            {
                label.Text = "Ja, het is tijd voor bier!";
            }
            else if (DateTime.Now < five)
            {
                label.Text = $"Nee, nog {countDown} te gaan.";
            }
        }
    }
}

