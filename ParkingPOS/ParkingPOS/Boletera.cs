using System;

namespace ParkingPOS
{
	public partial class Boletera : Gtk.Window
	{
		private long currentTicket = 0;
		private SQLConnection conn = null;

		public Boletera (ref SQLConnection sqlConnector) : base (Gtk.WindowType.Toplevel)
		{
			conn = sqlConnector;
			this.Build ();
		}

		private int getLastTicket()
		{
			return 0;
		}

		protected void OnKeyReleased (object o, Gtk.KeyReleaseEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.F3) {
				Console.WriteLine ("Imprimiendo Ticket");
				currentTicket++;
			}
		}
	}
}

