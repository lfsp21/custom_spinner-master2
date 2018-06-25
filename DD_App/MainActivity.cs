using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using FR.Ganfra.Materialspinner;

namespace DD_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private MaterialSpinner mdSpinner;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            FindViews();
            SpinnerHandler();

        }

        void FindViews()
        {
            mdSpinner = FindViewById<MaterialSpinner>(Resource.Id.spinner);
        }

        void SpinnerHandler()
        {
            string firstItem = mdSpinner.SelectedItem.ToString();
                mdSpinner.ItemSelected += (s, e) =>
            {
                if (firstItem.Equals(mdSpinner.SelectedItem.ToString()))
                {

                }
                else
                {
                    Toast.MakeText(this, "Seleccionado: " + e.Parent.GetItemIdAtPosition(e.Position).ToString(), ToastLength.Short).Show();

                }
            };
        }
    }
}

