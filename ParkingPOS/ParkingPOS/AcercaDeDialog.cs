using System;

namespace ParkingPOS
{
	public partial class AcercaDeDialog : Gtk.AboutDialog
	{
		public AcercaDeDialog ()
		{
			this.ProgramName = "Parking POS";
			this.Version = "0.1_alpha1";
			this.Logo = new Gdk.Pixbuf("/home/erick/Documentos/MonoDevelop_WS/ParkingPOS/ParkingPOS/ParkingPOS/img/icon_128.png");
			this.Authors = new string[] {"Erick G. Islas-Osuna"};
			this.Comments = @"Prueba de Conexion entre ventanas";
			this.Website = "https://github.com/erickisos/ParkingPOS";
			// this.Build ();
		}
	}
}
