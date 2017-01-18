using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections;

namespace FragmentStackTest
{
    [Activity(Label = "FragmentStackTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static ArrayList myFragments = new ArrayList();
        FragmentOne fm1 ;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            fm1 = new FragmentOne();
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            FragmentManager fm = FragmentManager;
            FragmentTransaction tx = fm.BeginTransaction();
            tx.Add(Resource.Id.frameLayout1, fm1, "ONE");
            myFragments.Add(fm1);
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

            Fragment lastFragment = (Fragment)(myFragments[myFragments.Count - 1]);


            if (lastFragment.Tag.Equals("ONE"))
            {
                myFragments.Clear();
                Finish();
                
            }
            else
            {
                if (FragmentManager.BackStackEntryCount > 0)
                {

                    FragmentManager.PopBackStackImmediate(new FragmentOne().Id, PopBackStackFlags.None);
                    myFragments.RemoveRange(1, myFragments.Count-1);
                }

                else
                {
                    base.OnBackPressed();
                }
            }

            

            //base.OnBackPressed();


        }
    }
}

