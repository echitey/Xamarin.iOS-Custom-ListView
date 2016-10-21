using Foundation;
using System;
using UIKit;

namespace iOSCustomTableView
{
    public partial class CustomTableViewCell : UITableViewCell
    {
        public CustomTableViewCell (IntPtr handle) : base (handle)
        {
        }

		public void UpdateCell(Character _char)
		{
			txtName.Text = _char.name;
			txtAge.Text = _char.age.ToString();
		}
    }
}