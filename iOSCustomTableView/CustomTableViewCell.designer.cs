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

namespace iOSCustomTableView
{
    [Register ("CustomTableViewCell")]
    partial class CustomTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel txtAge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel txtName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgView != null) {
                imgView.Dispose ();
                imgView = null;
            }

            if (txtAge != null) {
                txtAge.Dispose ();
                txtAge = null;
            }

            if (txtName != null) {
                txtName.Dispose ();
                txtName = null;
            }
        }
    }
}