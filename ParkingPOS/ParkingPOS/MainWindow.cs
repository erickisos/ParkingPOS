using System;
using System.Drawing.Printing;
using Gtk;
using ParkingPOS;

public partial class MainWindow: Gtk.Window
{
	public static AboutWindow about;
	public static Caseta caseta;
	public static Boletera boletera;
	private static SQLConnection conn;
	private static PrintDocument printer;

	public MainWindow (ref SQLConnection sqlConnector, ref PrintDocument mainPrinter) : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		conn = sqlConnector;
		printer = mainPrinter;
		caseta = new Caseta (ref conn);
	}

	void OnClicksito (object sender, EventArgs a)
	{
		about = new AboutWindow ();
		about.Run ();
		about.Destroy ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnLoginClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
		string user = entry1.Text;
		string password = entry2.Text;
		Console.WriteLine("Datos ingresados: {0}, {1}", user, password);
	}
}
