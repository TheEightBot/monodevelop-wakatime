
// This file has been generated by the GUI designer. Do not modify.

public partial class SettingsForm
{
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.Label labApi;
	
	private global::Gtk.Entry txtAPIKey;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Label labProxy;
	
	private global::Gtk.Entry txtProxy;
	
	private global::Gtk.CheckButton chkDebugMode;
	
	private global::Gtk.HButtonBox hbuttonbox2;
	
	private global::Gtk.Button btnOK;
	
	private global::Gtk.Button btnCancel;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget SettingsForm
		this.Name = "SettingsForm";
		this.Title = "Settings";
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Modal = true;
		this.BorderWidth = ((uint)(10));
		this.DefaultWidth = 480;
		// Container child SettingsForm.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.labApi = new global::Gtk.Label ();
		this.labApi.Name = "labApi";
		this.labApi.LabelProp = "API key :";
		this.hbox2.Add (this.labApi);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labApi]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		w1.Padding = ((uint)(6));
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtAPIKey = new global::Gtk.Entry ();
		this.txtAPIKey.CanFocus = true;
		this.txtAPIKey.Name = "txtAPIKey";
		this.txtAPIKey.IsEditable = true;
		this.txtAPIKey.InvisibleChar = '●';
		this.hbox2.Add (this.txtAPIKey);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.txtAPIKey]));
		w2.Position = 1;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.labProxy = new global::Gtk.Label ();
		this.labProxy.Name = "labProxy";
		this.labProxy.LabelProp = "Proxy :";
		this.hbox1.Add (this.labProxy);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labProxy]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		w4.Padding = ((uint)(11));
		// Container child hbox1.Gtk.Box+BoxChild
		this.txtProxy = new global::Gtk.Entry ();
		this.txtProxy.CanFocus = true;
		this.txtProxy.Name = "txtProxy";
		this.txtProxy.IsEditable = true;
		this.txtProxy.InvisibleChar = '●';
		this.hbox1.Add (this.txtProxy);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.txtProxy]));
		w5.Position = 1;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.chkDebugMode = new global::Gtk.CheckButton ();
		this.chkDebugMode.CanFocus = true;
		this.chkDebugMode.Name = "chkDebugMode";
		this.chkDebugMode.Label = "Debugging WakaTime?";
		this.chkDebugMode.DrawIndicator = true;
		this.chkDebugMode.UseUnderline = true;
		this.vbox1.Add (this.chkDebugMode);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.chkDebugMode]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox2 = new global::Gtk.HButtonBox ();
		this.hbuttonbox2.Name = "hbuttonbox2";
		this.hbuttonbox2.Spacing = 20;
		this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.btnOK = new global::Gtk.Button ();
		this.btnOK.CanFocus = true;
		this.btnOK.Name = "btnOK";
		this.btnOK.UseUnderline = true;
		this.btnOK.Label = "Save";
		this.hbuttonbox2.Add (this.btnOK);
		global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.btnOK]));
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
		this.btnCancel = new global::Gtk.Button ();
		this.btnCancel.CanFocus = true;
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.UseUnderline = true;
		this.btnCancel.Label = "Cancel";
		this.hbuttonbox2.Add (this.btnCancel);
		global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.btnCancel]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add (this.hbuttonbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox2]));
		w10.PackType = ((global::Gtk.PackType)(1));
		w10.Position = 3;
		w10.Expand = false;
		w10.Fill = false;
		w10.Padding = ((uint)(2));
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultHeight = 149;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnOK.Clicked += new global::System.EventHandler (this.btnOK_Clicked);
		this.btnCancel.Clicked += new global::System.EventHandler (this.btnCancel_Clicked);
	}
}
