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

namespace FragmentStackTest
{
    public class FragmentThree : Fragment
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            View view = inflater.Inflate(Resource.Layout.FragmentThree, container, false);
            Button bt1 = view.FindViewById<Button>(Resource.Id.button1);
            bt1.Click += Bt1_Click; ;
            return view;
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            Toast.MakeText(Activity, " i am a btn in Fragment three",
                ToastLength.Long).Show();
        }
    }
}