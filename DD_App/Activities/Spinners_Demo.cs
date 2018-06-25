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
using FR.Ganfra.Materialspinner;

using Android.Support.V7.App;

namespace DD_App
{
    [Activity(Label = "Spinners_Demo")]
    public class Spinners_Demo : AppCompatActivity
    {

        private static readonly string error_msg = "lolololo akk lolololo akk lolololo akklolololo akklolololo akklolololo akklolololo akklolololo akklolololo akklolololo akklolololo akk";
        private static readonly string[] spinner_items = { "1", "2", "3" };
        private ArrayAdapter<String> adapter;
        MaterialSpinner spinner1;
        MaterialSpinner spinner2;
        MaterialSpinner spinner3;
        MaterialSpinner spinner4;
        MaterialSpinner spinner5;
        private bool shown = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            //InitStrings();
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.spinners_layout);
            var btnShowErrors = FindViewById<Button>(Resource.Id.btnShowError);
            btnShowErrors.Click += ActivateError;
            adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerItem, spinner_items);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
           
            InitSpinnerHintAndFloatingLabel();
            InitSpinnerOnlyHint();
            InitSpinnerNoHintNoFloatingLabel();
            InitSpinnerMultiline();
            InitSpinnerScrolling();
        }

        void InitStrings()
        {
            //error_msg = Resources.GetString(Resource.String.dd_errormsg);
            //spinner_items = Resources.GetStringArray(Resource.Array.items);

        }
        #region METODOS
        private void InitSpinnerHintAndFloatingLabel()
        { 
            spinner1 = FindViewById<MaterialSpinner>(Resource.Id.spinner1);
            spinner1.Adapter = adapter;
            spinner1.SetPaddingSafe(0, 0, 0, 0);
        }

        private void InitSpinnerOnlyHint()
        {
            spinner2 = FindViewById<MaterialSpinner>(Resource.Id.spinner2);
            spinner2.Adapter = adapter;
        }

        private void InitSpinnerNoHintNoFloatingLabel()
        {
            spinner3 = FindViewById<MaterialSpinner>(Resource.Id.spinner3);
            spinner3.Adapter = adapter;
        }

        private void InitSpinnerMultiline()
        {
            spinner4 = FindViewById<MaterialSpinner>(Resource.Id.spinner4);
            spinner4.Adapter = adapter;
            spinner4.Hint = "Select an item";
        }

        private void InitSpinnerScrolling()
        {
            spinner5 = FindViewById<MaterialSpinner>(Resource.Id.spinner5);
            spinner5.Adapter = adapter;
            spinner5.Hint = "Select an item";
        }

        public void ActivateError(object sender, EventArgs e)
        {
            if (!shown)
            {
                spinner4.Error = error_msg;
                spinner5.Error = error_msg;

            }

            else
            {
                spinner4.Error = null;
                spinner5.Error = null;

            }

            shown = !shown;
        }
        #endregion
    }
}