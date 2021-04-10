using DuraDriveRider.Controls;
using DuraDriveRider.Droid.Renderers;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly : ExportRenderer(typeof(CoustomSearchBar),typeof(CoustomSearchBarRenderer))]
namespace DuraDriveRider.Droid.Renderers
{
   public class CoustomSearchBarRenderer : SearchBarRenderer
    {
        private CoustomSearchBar _appSearchBar = null;
        private const GravityFlags DefaultGravity = GravityFlags.CenterVertical;

        public CoustomSearchBarRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control == null || e.OldElement != null || this.Element == null)
                return;
            Control.Background = null;
            _appSearchBar = (this.Element as CoustomSearchBar);
            UpdatePadding(_appSearchBar);
            UpdateTextAlighnment(_appSearchBar);
            UpdateBackground(_appSearchBar);
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Element == null)
                return;
            var searchBar = Element as CoustomSearchBar;
            if (e.PropertyName == CoustomSearchBar.BorderWidthProperty.PropertyName ||
                e.PropertyName == CoustomSearchBar.BorderColorProperty.PropertyName ||
                e.PropertyName == CoustomSearchBar.CornerRadiusProperty.PropertyName)
            {
                UpdateBackground(searchBar);
            }
            else if (e.PropertyName == CoustomSearchBar.HorizontalTextAlignmentProperty.PropertyName)
            {
                UpdateTextAlighnment(searchBar);
            }
        }
        private void UpdatePadding(CoustomSearchBar searchBar)
        {
            // Set padding for the internal text from border  
            Control.SetPadding((int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingTop, (int)DpToPixels(this.Context, Convert.ToSingle(12)), Control.PaddingBottom);
        }

        private void UpdateTextAlighnment(SearchBar searchBar)
        {
            var gravity = DefaultGravity;
            switch (searchBar.HorizontalTextAlignment)
            {
                case Xamarin.Forms.TextAlignment.Start:
                    gravity |= GravityFlags.Start;
                    break;
                case Xamarin.Forms.TextAlignment.Center:
                    gravity |= GravityFlags.CenterHorizontal;
                    break;
                case Xamarin.Forms.TextAlignment.End:
                    gravity |= GravityFlags.End;
                    break;
            }
            //Control.Gravity = gravity;
        }


        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
        private void UpdateBackground(CoustomSearchBar searchBar)
        {
            // creating gradient drawable for the curved background  
            var _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(searchBar.BackgroundColor.ToAndroid());

            // Thickness of the stroke line  
            _gradientBackground.SetStroke(searchBar.BorderWidth, searchBar.BorderColor.ToAndroid());

            // Radius for the curves  
            _gradientBackground.SetCornerRadius(DpToPixels(this.Context, Convert.ToSingle(searchBar.CornerRadius)));

            // set the background of the   
            Control.SetBackground(_gradientBackground);
        }
    }
}
