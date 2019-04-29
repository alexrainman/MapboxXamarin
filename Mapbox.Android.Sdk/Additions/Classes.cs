using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Mapbox.Mapboxsdk.Annotations
{
    public partial class PolygonOptions
    {
        // Metadata.xml XPath method reference: path="/api/package[@name='com.mapbox.mapboxsdk.annotations']/class[@name='PolygonOptions']/method[@name='addHole' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.mapbox.mapboxsdk.geometry.LatLng&gt;...']]"
        [Register("addHole", "([Ljava/util/List;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;", "")]
        public unsafe global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions AddHole(params global::System.Collections.Generic.IList<global::Com.Mapbox.Mapboxsdk.Geometry.LatLng>[] holes)
        {
            const string __id = "addHole.([Ljava/util/List;)Lcom/mapbox/mapboxsdk/annotations/PolygonOptions;";
            IntPtr native_holes = JNIEnv.NewArray(holes);
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue(native_holes);
                var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
                return global::Java.Lang.Object.GetObject<global::Com.Mapbox.Mapboxsdk.Annotations.PolygonOptions>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
                if (holes != null)
                {
                    JNIEnv.CopyArray(native_holes, holes);
                    JNIEnv.DeleteLocalRef(native_holes);
                }
            }
        }
    }

    public partial class MarkerOptions
    {
        public override BaseMarkerOptions This
        {
            get { return ThisMarkerOptions(); }
        }
    }

    public partial class Marker
    {
        public override int CompareTo(Java.Lang.Object obj)
        {
            return CompareTo((Marker)obj);
        }
    }

    public partial class Polygon
    {
        public override int CompareTo(Java.Lang.Object obj)
        {
            return CompareTo((Polygon)obj);
        }
    }

    public partial class Polyline
    {
        public override int CompareTo(Java.Lang.Object obj)
        {
            return CompareTo((Polyline)obj);
        }
    }
}