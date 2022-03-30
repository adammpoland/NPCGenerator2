using Android.Content;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Views;
using NPCGenerator2.CustomControls;
using NPCGenerator2.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace NPCGenerator2.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {   
                Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.roundcorners);
                //Control.Gravity = GravityFlags.CenterVertical;
                //Control.SetPadding(10, 10, 10, 10); 
                //Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);

            }
        }
    }
}