using System;
using System.Collections.Generic;
using UIKit;

namespace iOSCustomTableView
{
	public class MyTableSource : UITableViewSource
	{
		List<Character> characters;
		public MyTableSource(List<Character> _characters)
		{
			characters = _characters;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return characters.Count;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("characterCell") as CustomTableViewCell;

			cell.UpdateCell(characters[indexPath.Row]);

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			return 100f;
		}
	}

	public class Character
	{
		public string name { get; set;}
		public int age { get; set;}
		public string picture { get; set;}
		public override string ToString()
		{
			return string.Format("[Character: name={0}, age={1}, picture={2}]", name, age, picture);
		}
	}
}
