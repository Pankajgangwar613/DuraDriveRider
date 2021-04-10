using AdventureClub.Controls;
using AdventureClub.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CoustomSearchBar),typeof(CoustomSearchBarRenderer))]
namespace AdventureClub.iOS.Renderers
{
   public class CoustomSearchBarRenderer : SearchBarRenderer
    {
        private CoustomSearchBar _appSearchBar = null;
        public CoustomSearchBarRenderer()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control == null || e.OldElement != null || this.Element == null)
                return;
            //Control.SearchBarStyle = UISearchBarStyle.Minimal;
            //Control.BarTintColor = UIColor.Clear;
            _appSearchBar = (this.Element as CoustomSearchBar);
            UpdateBorderWidth(_appSearchBar);
            UpdateBorderColor(_appSearchBar);
            UpdateBorderRadius(_appSearchBar);
            Control.ClipsToBounds = true;
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (this.Element == null)
                return;
            var searchBar = Element as CoustomSearchBar;
            if (e.PropertyName == CoustomSearchBar.BorderWidthProperty.PropertyName)
            {
                UpdateBorderWidth(searchBar);
            }
            else if (e.PropertyName == CoustomSearchBar.BorderColorProperty.PropertyName)
            {
                UpdateBorderColor(searchBar);
            }
            else if (e.PropertyName == CoustomSearchBar.CornerRadiusProperty.PropertyName)
            {
                UpdateBorderRadius(searchBar);
            }
        }
        private void UpdateBorderWidth(CoustomSearchBar searchBar)
        {
            Control.Layer.BorderWidth = searchBar.BorderWidth;
        }

        private void UpdateBorderColor(CoustomSearchBar searchBar)
        {
            Control.Layer.BorderColor = searchBar.BorderColor.ToUIColor().CGColor;
        }

        private void UpdateBorderRadius(CoustomSearchBar searchBar)
        {
            Control.Layer.CornerRadius = (nfloat)searchBar.CornerRadius;
        }

    }
}
