using System;

namespace ParkingPOS
{
	public partial class Caseta : Gtk.Window
	{
		private string currentTicket;
		private SQLConnection connector;
		private AboutWindow awin;

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
				if (currentTicket.Length == 18)
				{
					TicketSelection sel;
					sel = new TicketSelection();
					try
					{
						string caseta = currentTicket.Substring(0, 1);
						string folio = currentTicket.Substring(1, 8);
						string hora = currentTicket.Substring(9, 4);
						string fecha = currentTicket.Substring(13, 2);
						Console.WriteLine("Caseta: {0} \nFolio: {1} \nHora: {2}:{3} \nFecha: {4}", caseta,
							folio, hora.Substring(0, 2), hora.Substring(2, 2), fecha);
					}
					catch (Exception e)
					{
						Console.WriteLine("Error: {0}", e.Message);
					}
				}
			}
		}

		protected void OnAboutClicked (object sender, EventArgs e)
		{
			awin = new AboutWindow ();
			awin.Run ();
			awin.Destroy ();
		}

		protected void OnDepurarClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnRepararClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnPreferencesClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

