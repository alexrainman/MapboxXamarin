using Android.App;
using Android.OS;
using Com.Mapbox.Mapboxsdk.Maps;
using Com.Mapbox.Mapboxsdk.Camera;
using Com.Mapbox.Mapboxsdk.Geometry;
using Com.Mapbox.Mapboxsdk;

namespace mapboxdemo.Droid
{
    [Activity(Label = "mapboxdemo", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private MapView mapView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Mapbox.GetInstance(this, "YOUR API KEY HERE");

            Mapbox.SetConnected(Java.Lang.Boolean.True);

            MapboxMapOptions options = new MapboxMapOptions()
                .InvokeCamera(new CameraPosition.Builder()
                .Target(new LatLng(29.7604, -95.3698))
                .Zoom(8)
                .Build());

            // create map
            mapView = new MapView(this, options);

            mapView.OnCreate(savedInstanceState);

            mapView.GetMapAsync(this);

            SetContentView(mapView);
        }



        public void OnMapReady(MapboxMap mapboxMap)
        {
            // Com.Mapbox.Mapboxsdk.Constants.Style.Light = mapbox://styles/mapbox/light-v9
            mapboxMap.SetStyle("mapbox://styles/mapbox/light-v9", new OnStyleLoadedListener(mapboxMap));
        }

        protected override void OnStart()
        {
            base.OnStart();
            mapView.OnStart();
        }

        protected override void OnResume()
        {
            base.OnResume();
            mapView.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
            mapView.OnPause();
        }

        protected override void OnStop()
        {
            base.OnStop();
            mapView.OnStop();
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            base.OnSaveInstanceState(outState);
            mapView.OnSaveInstanceState(outState);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            mapView.OnDestroy();
        }

        public override void OnLowMemory()
        {
            base.OnLowMemory();
            mapView.OnLowMemory();
        }
    }

    public class OnStyleLoadedListener : Java.Lang.Object, Style.IOnStyleLoaded
    {
        MapboxMap mapboxMap;

        public OnStyleLoadedListener(MapboxMap _mapboxMap)
        {
            mapboxMap = _mapboxMap;
        }

        public void OnStyleLoaded(Style p0)
        {
            // Zoom levels
            mapboxMap.SetMinZoomPreference(8);
            mapboxMap.SetMaxZoomPreference(15);
        }
    }
}

