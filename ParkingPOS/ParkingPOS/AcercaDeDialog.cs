using System;

namespace ParkingPOS
{
	public partial class AcercaDeDialog : Gtk.AboutDialog
	{
		public AcercaDeDialog ()
		{
			this.ProgramName = "Parking POS";
			this.Version = "alpha1";
			this.Logo = new Gdk.Pixbuf("img/icon.png");
			this.Comments = @"Prueba de Conexion entre ventanas";
			this.Website = "https://github.com/erickisos/ParkingPOS";
			this.Build ();
		}
	}
}

