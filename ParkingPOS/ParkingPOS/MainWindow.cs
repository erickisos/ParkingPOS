using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public static ParkingPOS.AcercaDeDialog about;


	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		about = new ParkingPOS.AcercaDeDialog ();
		about.Run ();
		about.Destroy ();
	}

	void OnClicksito (object sender, EventArgs a)
	{
		about = new ParkingPOS.AcercaDeDialog ();
		about.Run ();
		about.Destroy ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
