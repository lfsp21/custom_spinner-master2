using System;
using System.Collections;
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

namespace DD_App.Activities
{
    [Activity(Label = "Dialog_Demo", MainLauncher = true)]
    public class Dialog_Demo : AppCompatActivity
    {
        private Button dialogBtn;
        private Button dialogBtn2;
        private string[] SpItems;
        private ArrayAdapter SpAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.dialog_main_layout);
            // Create your application here

            SpItems = Resources.GetStringArray(Resource.Array.spinner_items);
            SpAdapter = ArrayAdapter.CreateFromResource(this, Resource.Array.spinner_items, Resource.Layout.spinner_selected_item);

            FindViews();
            HandleEvents();


        }

        void FindViews()
        {
            dialogBtn = FindViewById<Button>(Resource.Id.btndialog);
            dialogBtn2 = FindViewById<Button>(Resource.Id.button1);
        }

        void HandleEvents()
        {
            dialogBtn.Click += dialogBtn_Click;
        }

        private void dialogBtn_Click(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void ShowDialog()
        {
            Android.App.AlertDialog.Builder ad = new Android.App.AlertDialog.Builder(this);
            ad.SetTitle("Opciones");
           
            string[] items = new string[] { "Item 1", "Item 2", "Item 3", "Item 4" };
            ad.SetSingleChoiceItems(items, 0, new EventHandler<DialogClickEventArgs>(delegate (object sender, DialogClickEventArgs e) {
                // Get reference to AlertDialog
                var d = (sender as Android.App.AlertDialog);

                // Do something with selected index
                Toast.MakeText(this, $"SelectedItemIndex: {e.Which}", ToastLength.Short).Show();

                // Dismiss Dialog
                d.Dismiss();
            }));

            ad.SetPositiveButton("OK", delegate { });
            ad.Show();
        }//sd
 

        }
    }
