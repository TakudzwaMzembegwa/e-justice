
using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.Collections;

namespace e_justice
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private RadioGroup radioGroup;
        private RadioButton radioButton;

        /*
         * When Activity is Created.
         */
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            LinearLayout linearLayout = new LinearLayout(this)
            {
                LayoutParameters =
                    new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                Orientation = Orientation.Vertical
            };

            createMultipleRadioButtons();
            linearLayout.AddView(radioGroup);
            SetContentView(linearLayout);

            radioGroup.CheckedChange += RadioGroupCheckedChange;

        }


        /*
         * Create a group of radio buttons from the crime list
         */
        private void createMultipleRadioButtons()
        {

            ArrayList cases = new ArrayList();
            cases.Add("Theft");
            cases.Add("Murder");
            cases.Add("Rape");
            cases.Add("Arson");
            radioGroup = new RadioGroup(this);
            radioButton = new RadioButton(this)
            {
                Id = 1,
                Text = (string)cases[0],
                Checked = true,
                LayoutParameters =
                    new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
            };
            radioGroup.AddView(radioButton);
            for (int i = 1; i < cases.Count; i++)
            {
                radioButton = new RadioButton(this)
                {
                    Id = i + 1,
                    Text = (string)cases[i],
                    LayoutParameters =
                    new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent)
                };
                radioGroup.AddView(radioButton);
            }

        }
        /*
        * RadioButton CheckChange Event Handler
        */
        void RadioGroupCheckedChange(object sender, RadioGroup.CheckedChangeEventArgs e)
        {
            int checkedItem = radioGroup.CheckedRadioButtonId;
            RadioButton radioButton = FindViewById<RadioButton>(checkedItem);
            Toast.MakeText(this, radioButton.Text, ToastLength.Short).Show();
        }

    }
}