using System;

namespace ParkingPOS
{
	public partial class ErrorDialog : Gtk.MessageDialog
	{
		public ErrorDialog(string MessageError)
		{
			this.MessageType = Gtk.MessageType.Error;
			this.Text = MessageError;
			this.Run();
			this.Destroy();
			// this.Build();
		}
	}
}
