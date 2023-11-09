using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidApp1
{
    [Activity(Label = "@string/Act2")]
    public class Act2 : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Act2);

            string surename = Intent.GetStringExtra("surename");

            TextView TV1 = FindViewById<TextView>(Resource.Id.TV1);

            ImageView iv1 = FindViewById<ImageView>(Resource.Id.iv1);

            TV1.Text = surename;

            iv1.SetImageResource(Resource.Drawable.two);
        }
    }
}
