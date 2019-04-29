using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace MapboxBindings
{
	[Native]
	public enum MGLAnnotationViewDragState : ulong
	{
		None = 0,
		Starting,
		Dragging,
		Canceling,
		Ending
	}

	[Native]
	public enum MGLErrorCode : int
	{
		Unknown = -1,
		NotFound = 1,
		BadServerResponse = 2,
		ConnectionFailed = 3,
		ParseStyleFailed = 4,
		LoadStyleFailed = 5,
		SnapshotFailed = 6,
		SourceIsInUseCannotRemove = 7,
		SourceIdentifierMismatch = 8
	}

	[Flags]
	[Native]
	public enum MGLMapDebugMaskOptions : ulong
	{
		TileBoundariesMask = 1uL << 1,
		TileInfoMask = 1uL << 2,
		TimestampsMask = 1uL << 3,
		CollisionBoxesMask = 1uL << 4,
		OverdrawVisualizationMask = 1uL << 5
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLTransition
	{
		public double duration;

		public double delay;
	}

	static class CFunctions
	{
		// NSString * _Nonnull MGLStringFromMGLTransition (MGLTransition transition) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString MGLStringFromMGLTransition (MGLTransition transition);

		// MGLTransition MGLTransitionMake (NSTimeInterval duration, NSTimeInterval delay) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLTransition MGLTransitionMake (double duration, double delay);

		// MGLCoordinateSpan MGLCoordinateSpanMake (CLLocationDegrees latitudeDelta, CLLocationDegrees longitudeDelta) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLCoordinateSpan MGLCoordinateSpanMake (double latitudeDelta, double longitudeDelta);

		// MGLMapPoint MGLMapPointMake (CGFloat x, CGFloat y, CGFloat zoomLevel) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLMapPoint MGLMapPointMake (nfloat x, nfloat y, nfloat zoomLevel);

		// BOOL MGLCoordinateSpanEqualToCoordinateSpan (MGLCoordinateSpan span1, MGLCoordinateSpan span2) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool MGLCoordinateSpanEqualToCoordinateSpan (MGLCoordinateSpan span1, MGLCoordinateSpan span2);

		// MGLCoordinateBounds MGLCoordinateBoundsMake (CLLocationCoordinate2D sw, CLLocationCoordinate2D ne) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLCoordinateBounds MGLCoordinateBoundsMake (CLLocationCoordinate2D sw, CLLocationCoordinate2D ne);

		// MGLCoordinateQuad MGLCoordinateQuadMake (CLLocationCoordinate2D topLeft, CLLocationCoordinate2D bottomLeft, CLLocationCoordinate2D bottomRight, CLLocationCoordinate2D topRight) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLCoordinateQuad MGLCoordinateQuadMake (CLLocationCoordinate2D topLeft, CLLocationCoordinate2D bottomLeft, CLLocationCoordinate2D bottomRight, CLLocationCoordinate2D topRight);

		// MGLCoordinateQuad MGLCoordinateQuadFromCoordinateBounds (MGLCoordinateBounds bounds) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLCoordinateQuad MGLCoordinateQuadFromCoordinateBounds (MGLCoordinateBounds bounds);

		// BOOL MGLCoordinateBoundsEqualToCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool MGLCoordinateBoundsEqualToCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2);

		// BOOL MGLCoordinateBoundsIntersectsCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool MGLCoordinateBoundsIntersectsCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2);

		// BOOL MGLCoordinateInCoordinateBounds (CLLocationCoordinate2D coordinate, MGLCoordinateBounds bounds) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool MGLCoordinateInCoordinateBounds (CLLocationCoordinate2D coordinate, MGLCoordinateBounds bounds);

		// MGLCoordinateSpan MGLCoordinateBoundsGetCoordinateSpan (MGLCoordinateBounds bounds) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLCoordinateSpan MGLCoordinateBoundsGetCoordinateSpan (MGLCoordinateBounds bounds);

		// MGLCoordinateBounds MGLCoordinateBoundsOffset (MGLCoordinateBounds bounds, MGLCoordinateSpan offset) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLCoordinateBounds MGLCoordinateBoundsOffset (MGLCoordinateBounds bounds, MGLCoordinateSpan offset);

		// BOOL MGLCoordinateBoundsIsEmpty (MGLCoordinateBounds bounds) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool MGLCoordinateBoundsIsEmpty (MGLCoordinateBounds bounds);

		// NSString * _Nonnull MGLStringFromCoordinateBounds (MGLCoordinateBounds bounds) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString MGLStringFromCoordinateBounds (MGLCoordinateBounds bounds);

		// NSString * _Nonnull MGLStringFromCoordinateQuad (MGLCoordinateQuad quad) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern NSString MGLStringFromCoordinateQuad (MGLCoordinateQuad quad);

		// CGFloat MGLRadiansFromDegrees (CLLocationDegrees degrees) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern nfloat MGLRadiansFromDegrees (double degrees);

		// CLLocationDegrees MGLDegreesFromRadians (CGFloat radians) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern double MGLDegreesFromRadians (nfloat radians);

		// extern MGLMapPoint MGLMapPointForCoordinate (CLLocationCoordinate2D coordinate, double zoomLevel) __attribute__((visibility("default")));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLMapPoint MGLMapPointForCoordinate (CLLocationCoordinate2D coordinate, double zoomLevel);

		// extern CLLocationDistance MGLAltitudeForZoomLevel (double zoomLevel, CGFloat pitch, CLLocationDegrees latitude, CGSize size) __attribute__((visibility("default")));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern double MGLAltitudeForZoomLevel (double zoomLevel, nfloat pitch, double latitude, CGSize size);

		// extern double MGLZoomLevelForAltitude (CLLocationDistance altitude, CGFloat pitch, CLLocationDegrees latitude, CGSize size) __attribute__((visibility("default")));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern double MGLZoomLevelForAltitude (double altitude, nfloat pitch, double latitude, CGSize size);

		// MGLSphericalPosition MGLSphericalPositionMake (CGFloat radial, CLLocationDirection azimuthal, CLLocationDirection polar) __attribute__((always_inline));
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern MGLSphericalPosition MGLSphericalPositionMake (nfloat radial, double azimuthal, double polar);
	}

	[Native]
	public enum MGLAttributionInfoStyle : ulong
	{
		Short = 1,
		Medium,
		Long
	}

	[Flags]
	[Native]
	public enum MGLCameraChangeReason : ulong
	{
		None = 0x0,
		Programmatic = 1uL << 0,
		ResetNorth = 1uL << 1,
		GesturePan = 1uL << 2,
		GesturePinch = 1uL << 3,
		GestureRotate = 1uL << 4,
		GestureZoomIn = 1uL << 5,
		GestureZoomOut = 1uL << 6,
		GestureOneFingerZoom = 1uL << 7,
		GestureTilt = 1uL << 8,
		TransitionCancelled = 1uL << 16
	}

	[Native]
	public enum MGLCirclePitchAlignment : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLCircleScaleAlignment : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLCircleTranslationAnchor : ulong
	{
		Map,
		Viewport
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLCoordinateSpan
	{
		public double latitudeDelta;

		public double longitudeDelta;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLMapPoint
	{
		public nfloat x;

		public nfloat y;

		public nfloat zoomLevel;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLMatrix4
	{
		public double m00;

		public double m01;

		public double m02;

		public double m03;

		public double m10;

		public double m11;

		public double m12;

		public double m13;

		public double m20;

		public double m21;

		public double m22;

		public double m23;

		public double m30;

		public double m31;

		public double m32;

		public double m33;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLCoordinateBounds
	{
		public CLLocationCoordinate2D sw;

		public CLLocationCoordinate2D ne;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLCoordinateQuad
	{
		public CLLocationCoordinate2D topLeft;

		public CLLocationCoordinate2D bottomLeft;

		public CLLocationCoordinate2D bottomRight;

		public CLLocationCoordinate2D topRight;
	}

	[Native]
	public enum MGLFillExtrusionTranslationAnchor : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLFillTranslationAnchor : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLHillshadeIlluminationAnchor : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLLightAnchor : ulong
	{
		Map,
		Viewport
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLSphericalPosition
	{
		public nfloat radial;

		public double azimuthal;

		public double polar;
	}

	[Native]
	public enum MGLLineCap : ulong
	{
		Butt,
		Round,
		Square
	}

	[Native]
	public enum MGLLineJoin : ulong
	{
		Bevel,
		Round,
		Miter
	}

	[Native]
	public enum MGLLineTranslationAnchor : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLLoggingLevel : ulong
	{
		None = 0,
		Info,
		Error,
		Fault
	}

	[Native]
	public enum MGLAnnotationVerticalAlignment : ulong
	{
		Center = 0,
		Top,
		Bottom
	}

	[Native]
	public enum MGLOrnamentPosition : ulong
	{
		TopLeft = 0,
		TopRight,
		BottomLeft,
		BottomRight
	}

	[Native]
	public enum MGLUserTrackingMode : ulong
	{
		None = 0,
		Follow,
		FollowWithHeading,
		FollowWithCourse
	}

	[Native]
	public enum MGLOfflinePackState : ulong
	{
		Unknown = 0,
		Inactive = 1,
		Active = 2,
		Complete = 3,
		Invalid = 4
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLOfflinePackProgress
	{
		public ulong countOfResourcesCompleted;

		public ulong countOfBytesCompleted;

		public ulong countOfTilesCompleted;

		public ulong countOfTileBytesCompleted;

		public ulong countOfResourcesExpected;

		public ulong maximumResourcesExpected;
	}

	[Native]
	public enum MGLResourceKind : ulong
	{
		Unknown,
		Style,
		Source,
		Tile,
		Glyphs,
		SpriteImage,
		SpriteJSON,
		Image
	}

	[Native]
	public enum MGLIconAnchor : ulong
	{
		Center,
		Left,
		Right,
		Top,
		Bottom,
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	[Native]
	public enum MGLIconPitchAlignment : ulong
	{
		Map,
		Viewport,
		Auto
	}

	[Native]
	public enum MGLIconRotationAlignment : ulong
	{
		Map,
		Viewport,
		Auto
	}

	[Native]
	public enum MGLIconTextFit : ulong
	{
		None,
		Width,
		Height,
		Both
	}

	[Native]
	public enum MGLSymbolPlacement : ulong
	{
		Point,
		Line,
		LineCenter
	}

	[Native]
	public enum MGLSymbolZOrder : ulong
	{
		ViewportY,
		Source
	}

	[Native]
	public enum MGLTextAnchor : ulong
	{
		Center,
		Left,
		Right,
		Top,
		Bottom,
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	[Native]
	public enum MGLTextJustification : ulong
	{
		Auto,
		Left,
		Center,
		Right
	}

	[Native]
	public enum MGLTextPitchAlignment : ulong
	{
		Map,
		Viewport,
		Auto
	}

	[Native]
	public enum MGLTextRotationAlignment : ulong
	{
		Map,
		Viewport,
		Auto
	}

	[Native]
	public enum MGLTextTransform : ulong
	{
		None,
		Uppercase,
		Lowercase
	}

	[Native]
	public enum MGLIconTranslationAnchor : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLTextTranslationAnchor : ulong
	{
		Map,
		Viewport
	}

	[Native]
	public enum MGLRasterResamplingMode : ulong
	{
		Linear,
		Nearest
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct MGLStyleLayerDrawingContext
	{
		public CGSize size;

		public CLLocationCoordinate2D centerCoordinate;

		public double zoomLevel;

		public double direction;

		public nfloat pitch;

		public nfloat fieldOfView;

		public MGLMatrix4 projectionMatrix;
	}

	[Native]
	public enum MGLTileCoordinateSystem : ulong
	{
		Xyz = 0,
		Tms
	}

	[Native]
	public enum MGLDEMEncoding : ulong
	{
		Mapbox = 0,
		Terrarium
	}
}
