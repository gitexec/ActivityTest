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
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Console.WriteLine("Activity B OnCreate");
 

            // Create your application here
        }
        protected override void OnStart()
        {
            base.OnStart();
            Console.WriteLine(GetType().FullName, "Activity B On Start");
        }
        protected override void OnResume()
        {
            Console.WriteLine(GetType().FullName, "Activity B - OnResume");
            base.OnResume();
        }

        protected override void OnPause()
        {
            Console.WriteLine(GetType().FullName, "Activity B - OnPause");
            base.OnPause();
        }

        protected override void OnStop()
        {
            Console.WriteLine(GetType().FullName, "Activity B - OnStop");
            base.OnStop();
        }

        protected override void OnDestroy()
        {
            Console.WriteLine(GetType().FullName, "Activity B - OnDestroy");
            base.OnDestroy();
        }


    }
}