using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public static ParkingPOS.AcercaDeDialog about;
	public static ParkingPOS.Caseta caseta;
	public static ParkingPOS.Boletera boletera;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		//about = new ParkingPOS.AcercaDeDialog ();
		//caseta = new ParkingPOS.Caseta ();
		//boletera = new ParkingPOS.Boletera ();
		//about.Run ();
		//about.Destroy ();
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

	protected void OnLoginClicked (object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
		string user = entry1.Text;
		string password = entry2.Text;
		Console.WriteLine("Datos ingresados: {0}, {1}", user, password);
	}
}
