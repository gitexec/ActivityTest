using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace ActivityTest
{
    [Activity(Label = "ActivityTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {   int counter = 0;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Console.WriteLine(GetType().FullName, "Activity A - OnCreate");
            SetContentView(Resource.Layout.Main);
            FindViewById<Button>(Resource.Id.myButton).Click += (sender, args) =>
            {
                var intent = new Intent(this, typeof(SecondActivity));
                StartActivity(intent);
            };
            if(bundle != null)
            {
                counter = bundle.GetInt("click_counter", 0);
                Console.WriteLine("RECOVERING BUNDLE INSTANCES");
            }
            var clickButton = FindViewById<Button>(Resource.Id.clickButton);
            clickButton.Text = Resources.GetString(
                Resource.String.ClickButton, counter);
            clickButton.Click += (object sender, EventArgs e) =>
            {
                counter++;
                Console.WriteLine("Counting " + counter);
                clickButton.Text = Resources.GetString(
                    Resource.String.ClickButton, counter
                    );
            };
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("click_counter", counter);
            Console.WriteLine("OnSaveInstanceState " + counter);
            base.OnSaveInstanceState(outState);

        }

        protected override void OnDestroy()
        {
            Console.WriteLine(GetType().FullName, "Activity A - On Destroy");
            base.OnDestroy();
        }

        protected override void OnPause()
        {
            Console.WriteLine(GetType().FullName, "Activity A - OnPause");
            base.OnPause();
        }

        protected override void OnRestart()
        {
            Console.WriteLine(GetType().FullName, "Activity A - OnRestart");
            base.OnRestart();
        }

        protected override void OnResume()
        {
            Console.WriteLine(GetType().FullName, "Activity A - OnResume");
            base.OnResume();
        }

        protected override void OnStart()
        {
            Console.WriteLine(GetType().FullName, "Activity A - OnStart");
            base.OnStart();
        }

        protected override void OnStop()
        {
            Console.WriteLine(GetType().FullName, "Activity A - OnStop");
            base.OnStop();
        }
    }
}

