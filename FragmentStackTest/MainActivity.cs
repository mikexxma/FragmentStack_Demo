using Android.App;
using Android.Widget;
using Android.OS;

namespace FragmentStackTest
{
    [Activity(Label = "FragmentStackTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            FragmentManager fm = FragmentManager;
            FragmentTransaction tx = fm.BeginTransaction();
            tx.Add(Resource.Id.frameLayout1, new FragmentOne(), "ONE");
            tx.AddToBackStack(null);
            tx.Commit();

        }

        public override void OnBackPressed()
        {

            //if (FragmentManager.BackStackEntryCount > 0)
            //    for (int i = 0; i < FragmentManager.BackStackEntryCount; i++)
            //    {
            //        FragmentManager.PopBackStackImmediate();
            //    }

            //else
            //    base.OnBackPressed();

            if (FragmentManager.BackStackEntryCount > 0)

                FragmentManager.PopBackStackImmediate(new FragmentOne().Id, PopBackStackFlags.None);
            else
            {
                base.OnBackPressed();
            }

            //base.OnBackPressed();


        }
    }
}

