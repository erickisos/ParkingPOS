using System;

namespace ParkingPOS
{
	public partial class Caseta : Gtk.Window
	{
		public Caseta () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnKeyRelease (object o, Gtk.KeyReleaseEventArgs args)
		{
			throw new NotImplementedException ();
		}
	}
}

