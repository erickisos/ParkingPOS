
// This file has been generated by the GUI designer. Do not modify.
namespace ParkingPOS
{
	public partial class AcercaDeDialog
	{
		private global::Gtk.Button button6;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ParkingPOS.AcercaDeDialog
			this.Name = "ParkingPOS.AcercaDeDialog";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child ParkingPOS.AcercaDeDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Internal child ParkingPOS.AcercaDeDialog.ActionArea
			global::Gtk.HButtonBox w2 = this.ActionArea;
			w2.Name = "dialog1_ActionArea";
			w2.Spacing = 10;
			w2.BorderWidth = ((uint)(5));
			w2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.button6 = new global::Gtk.Button ();
			this.button6.CanFocus = true;
			this.button6.Name = "button6";
			this.button6.UseUnderline = true;
			this.button6.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
			this.AddActionWidget (this.button6, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w3 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w2 [this.button6]));
			w3.Expand = false;
			w3.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
		}
	}
}
