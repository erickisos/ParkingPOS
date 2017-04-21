using System;

namespace ParkingPOS
{
	public partial class Boletera : Gtk.Window
	{
		public Boletera () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnKeyReleased (object o, Gtk.KeyReleaseEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.F3) {
				
			}
		}
	}
}

