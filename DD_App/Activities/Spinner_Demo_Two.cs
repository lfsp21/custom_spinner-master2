using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace DD_App
{
    [Activity(Label = "Spinner_Demo_Two")]
    public class Spinner_Demo_Two : AppCompatActivity
    {
        private Spinner sp;
        private string[] SpItems;
        private ArrayAdapter SpAdapter;

   
        protected override void OnCreate(Bundle savedInstanceState)
        {
            try
            {
                base.OnCreate(savedInstanceState);

                // Create your application here
                SetContentView(Resource.Layout.spinner_demo_two_lyt);
                FindViews();
                SpItems = Resources.GetStringArray(Resource.Array.spinner_items);
                SpAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.spinner_items, Resource.Layout.spinner_selected_item);
                SpAdapter.SetDropDownViewResource(Resource.Layout.spinner_dropdown_item);
                sp.Adapter = SpAdapter;
            }
            catch (Exception)
            {

                throw;
            }


        }

        void FindViews()
        {
            sp = FindViewById<Spinner>(Resource.Id.custom_sp);
        
        }
    }
}