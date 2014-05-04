using System;
using System.Windows;

namespace WeakEventProject
{
	class Program
	{
		static void Main(string[] args)
		{
			var myObject = new MyClassWithWeakEvent();

			myObject.MyWeakEvent += MyWeakEventHandler;
			myObject
				.OnMyWeakEvent(new Object(), new EventArgs());

			myObject.MyWeakEvent -= MyWeakEventHandler;
			MessageBox.Show("No more events. Goodbye.");
			myObject
				.OnMyWeakEvent(new Object(), new EventArgs());
		}

		private static void MyWeakEventHandler(Object sender, EventArgs args)
		{
			MessageBox.Show("The Weak Event pattern works.");
		}

	}
}
