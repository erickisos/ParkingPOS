using System;

namespace ParkingPOS
{
	public class AboutWindow : Gtk.AboutDialog
	{
		public AboutWindow ()
		{
			this.ProgramName = "Parking POS";
			this.Version = "v0.3";
			this.License = "Released under the GNU General Public License v3";
			this.Logo = new Gdk.Pixbuf("../../icon_128.png");
			this.Authors = new string[] {"Erick G. Islas-Osuna"};
			this.Comments = @"Punto de Venta para estacionamiento.";
			this.Website = "https://github.com/erickisos/ParkingPOS";
		}
	}
}

