﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace RaysHotDogs
{
    [Activity(Label = "RaysHotDogs", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            //get our button from the layout resource,
            // and attach event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

        }
    }
}

