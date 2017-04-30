using System;

namespace ParkingPOS
{
	public partial class Caseta : Gtk.Window
	{
		private string currentTicket;
		private SQLConnection connector;

		public Caseta (ref SQLConnection sqlConnector) : base (Gtk.WindowType.Toplevel)
		{
			connector = sqlConnector;
			this.Build ();
		}

		protected void OnKeyRelease (object o, Gtk.KeyReleaseEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.Return) {
				Console.WriteLine ("Ticket ingresado");
				Console.WriteLine ("No: {0}", entry3.Text);
				currentTicket = entry3.Text;
				entry3.DeleteText (0, -1);
				try{
					string caseta = currentTicket.Substring(0, 1);
					string folio = currentTicket.Substring (1, 8);
					string hora = currentTicket.Substring (9, 4);
					string fecha = currentTicket.Substring (13, 2);
					Console.WriteLine ("Caseta: {0}\n" +
						"Folio: {1}\n" +
						"Hora: {2}:{3}\n" +
						"Fecha: {4}", caseta, folio, hora.Substring(0,2),
						hora.Substring(2, 2), fecha);
				}
				catch(Exception e) {
					Console.WriteLine ("Error: {0}", e.Message);
				}
			}
		}
	}
}

