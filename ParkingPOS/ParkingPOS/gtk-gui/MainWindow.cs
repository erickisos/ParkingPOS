
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.ComboBox combobox2;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Entry entry1;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Entry entry2;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Button button3;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Parking POS");
		this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "../../img/icon.png"));
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Seleccione Punto de Venta");
		this.vbox3.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.combobox2 = global::Gtk.ComboBox.NewText ();
		this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("Caseta"));
		this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("Boletera"));
		this.combobox2.Name = "combobox2";
		this.combobox2.Active = 1;
		this.hbox2.Add (this.combobox2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.combobox2]));
		w2.Position = 0;
		w2.Fill = false;
		this.vbox3.Add (this.hbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox2]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 1F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Usuario:");
		this.hbox4.Add (this.label2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label2]));
		w4.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.hbox4.Add (this.entry1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry1]));
		w5.Position = 1;
		w5.Fill = false;
		this.vbox4.Add (this.hbox4);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox4]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.Xalign = 1F;
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Contraseña:");
		this.hbox6.Add (this.label4);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label4]));
		w7.Position = 0;
		// Container child hbox6.Gtk.Box+BoxChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.hbox6.Add (this.entry2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.entry2]));
		w8.Position = 1;
		w8.Fill = false;
		this.vbox4.Add (this.hbox6);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox6]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox3.Add (this.vbox4);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button ();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString ("Aceptar");
		this.hbox1.Add (this.button3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button3]));
		w12.Position = 0;
		w12.Fill = false;
		this.vbox2.Add (this.hbox1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 333;
		this.DefaultHeight = 155;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
