// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace POC_iOS
{
	[Register ("LocationViewController")]
	partial class LocationViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LocationLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView MapView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LocationLabel != null) {
				LocationLabel.Dispose ();
				LocationLabel = null;
			}
			if (MapView != null) {
				MapView.Dispose ();
				MapView = null;
			}
		}
	}
}
