using Android.App;
using Android.Widget;
using Android.OS;
using MyFirstApp.Models;
namespace MyFirstApp
{
    [Activity(Label = "MyFirstApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnGuardar;
        Actividad general = new Actividad();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            btnGuardar = FindViewById<Button>(Resource.Id.btnGuardar);
            btnGuardar.Click += delegate
            {
                actionButton();
            };
        }
        private void actionButton()
        {
            Actividad o = new Actividad();
            general.permanence.Add(o.crear_activity());
            Toast.MakeText(this, "Una actividad fue agregada.", ToastLength.Short).Show();
            Toast.MakeText(this, "Tienes " + general.permanence.Count + " actividades registradas.", ToastLength.Long).Show();

        }
    }
}

