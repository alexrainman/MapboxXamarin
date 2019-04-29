using System;
using CoreLocation;
using Foundation;
using MapboxBindings;
using UIKit;

namespace mapboxdemo.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MGLAccountManager.AccessToken = "YOUR API KEY HERE";


            var mapView = new MGLMapView(
               View.Bounds,
               new NSUrl("mapbox://styles/mapbox/light-v9")
            )
            {
                WeakDelegate = this
            };

            var center = new CLLocationCoordinate2D(29.7604, -95.3698);

            // Starting point
            mapView.SetCenterCoordinate(center, zoomLevel: 8, direction: 0, animated: false);

            // Zoom levels
            mapView.MinimumZoomLevel = 8;
            mapView.MaximumZoomLevel = 15;

            View.AddSubview(mapView);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.     
        }
    }
}
