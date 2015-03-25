using Android.App;
using Android.OS;
using Android.Views.Animations;
using Android.Widget;

namespace buttonanimation
{
    [Activity(Label = "buttonanimation", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var animTranslate = AnimationUtils.LoadAnimation(this, Resource.Animation.anim_translate);
            var animAlpha = AnimationUtils.LoadAnimation(this, Resource.Animation.anim_alpha);
            var animScale = AnimationUtils.LoadAnimation(this, Resource.Animation.anim_scale);
            var animRotate = AnimationUtils.LoadAnimation(this, Resource.Animation.anim_rotate);

            var btnTranslate = FindViewById<Button>(Resource.Id.translate);
            var btnAlpha = FindViewById<Button>(Resource.Id.alpha);
            var btnScale = FindViewById<Button>(Resource.Id.scale);
            var btnRotate = FindViewById<Button>(Resource.Id.rotate);

            btnTranslate.Click += delegate
            {
                btnTranslate.StartAnimation(animTranslate);
            };

            btnAlpha.Click += delegate
            {
                btnAlpha.StartAnimation(animAlpha);
            };

            btnScale.Click += delegate
            {
                btnScale.StartAnimation(animScale);
            };

            btnRotate.Click += delegate
            {
                btnRotate.StartAnimation(animRotate);
            };
        }
    }
}


