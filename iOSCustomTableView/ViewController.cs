using System;
using System.Collections.Generic;
using UIKit;

namespace iOSCustomTableView
{
	public partial class ViewController : UIViewController
	{
		private List<Character> characters;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			characters = getCharacters();

			characterTable.Source = new MyTableSource(characters);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private List<Character> getCharacters()
		{
			
			var _characters = new List<Character>();

			_characters.Add(new Character { name = "Goomba", age = 12, picture = "" });
			_characters.Add(new Character { name = "Bowser", age = 23, picture = "" });
			_characters.Add(new Character { name = "Mario", age = 34, picture = "" });
			_characters.Add(new Character { name = "Racoon Mario", age = 35, picture = "" });
			_characters.Add(new Character { name = "Shyguy Green", age = 11, picture = "" });
			_characters.Add(new Character { name = "MArio Baby", age = 12, picture = "" });
			_characters.Add(new Character { name = "Yoshi", age = 23, picture = "" });

			return _characters;

		}
	}
}
