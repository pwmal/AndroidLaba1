using Android.Content;

namespace AndroidApp1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button btn1 = FindViewById<Button>(Resource.Id.btn1);

            btn1.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Act2));

                intent.PutExtra("surename", "Малыхин");

                StartActivity(intent);
            };
        }
    }
}