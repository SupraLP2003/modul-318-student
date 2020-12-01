namespace MyTransportApp
{
  partial class Main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.AbfahrtAnkunftBox = new System.Windows.Forms.ComboBox();
      this.DatePicker = new System.Windows.Forms.DateTimePicker();
      this.VerbindungSuchenButton = new System.Windows.Forms.Button();
      this.FahrplanButton = new System.Windows.Forms.Button();
      this.KarteButton = new System.Windows.Forms.Button();
      this.Startstationlabel = new System.Windows.Forms.Label();
      this.EndstationLabel = new System.Windows.Forms.Label();
      this.ZeitLabel = new System.Windows.Forms.Label();
      this.DatumLabel = new System.Windows.Forms.Label();
      this.VerbindungenGrid = new System.Windows.Forms.DataGridView();
      this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Pfeil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StartstationsText = new System.Windows.Forms.ComboBox();
      this.EndstationText = new System.Windows.Forms.ComboBox();
      this.Gridbutton = new System.Windows.Forms.DataGridViewButtonColumn();
      this.TimePicker = new System.Windows.Forms.DateTimePicker();
      this.StationaufKarte = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // AbfahrtAnkunftBox
      // 
      this.AbfahrtAnkunftBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.AbfahrtAnkunftBox.FormattingEnabled = true;
      this.AbfahrtAnkunftBox.Items.AddRange(new object[] {
            "Ankunftszeit",
            "Abfahrtszeit"});
      this.AbfahrtAnkunftBox.Location = new System.Drawing.Point(408, 71);
      this.AbfahrtAnkunftBox.Name = "AbfahrtAnkunftBox";
      this.AbfahrtAnkunftBox.Size = new System.Drawing.Size(121, 24);
      this.AbfahrtAnkunftBox.TabIndex = 2;
      // 
      // DatePicker
      // 
      this.DatePicker.Location = new System.Drawing.Point(690, 73);
      this.DatePicker.Name = "DatePicker";
      this.DatePicker.Size = new System.Drawing.Size(222, 22);
      this.DatePicker.TabIndex = 4;
      // 
      // VerbindungSuchenButton
      // 
      this.VerbindungSuchenButton.Location = new System.Drawing.Point(144, 166);
      this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
      this.VerbindungSuchenButton.Size = new System.Drawing.Size(174, 23);
      this.VerbindungSuchenButton.TabIndex = 5;
      this.VerbindungSuchenButton.Text = "Verbindungen Suchen";
      this.VerbindungSuchenButton.UseVisualStyleBackColor = true;
      this.VerbindungSuchenButton.Click += new System.EventHandler(this.VerbindungSuchenButton_Click);
      // 
      // FahrplanButton
      // 
      this.FahrplanButton.Location = new System.Drawing.Point(390, 166);
      this.FahrplanButton.Name = "FahrplanButton";
      this.FahrplanButton.Size = new System.Drawing.Size(159, 23);
      this.FahrplanButton.TabIndex = 6;
      this.FahrplanButton.Text = "Fahrplan anzeigen";
      this.FahrplanButton.UseVisualStyleBackColor = true;
      this.FahrplanButton.Click += new System.EventHandler(this.FahrplanButton_Click);
      // 
      // KarteButton
      // 
      this.KarteButton.Location = new System.Drawing.Point(677, 166);
      this.KarteButton.Name = "KarteButton";
      this.KarteButton.Size = new System.Drawing.Size(155, 23);
      this.KarteButton.TabIndex = 7;
      this.KarteButton.Text = "Stationen in der nähe";
      this.KarteButton.UseVisualStyleBackColor = true;
      this.KarteButton.Click += new System.EventHandler(this.KarteButton_Click);
      // 
      // Startstationlabel
      // 
      this.Startstationlabel.AutoSize = true;
      this.Startstationlabel.Location = new System.Drawing.Point(104, 50);
      this.Startstationlabel.Name = "Startstationlabel";
      this.Startstationlabel.Size = new System.Drawing.Size(80, 17);
      this.Startstationlabel.TabIndex = 8;
      this.Startstationlabel.Text = "Startstation";
      // 
      // EndstationLabel
      // 
      this.EndstationLabel.AutoSize = true;
      this.EndstationLabel.Location = new System.Drawing.Point(265, 49);
      this.EndstationLabel.Name = "EndstationLabel";
      this.EndstationLabel.Size = new System.Drawing.Size(75, 17);
      this.EndstationLabel.TabIndex = 9;
      this.EndstationLabel.Text = "Endstation";
      // 
      // ZeitLabel
      // 
      this.ZeitLabel.AutoSize = true;
      this.ZeitLabel.Location = new System.Drawing.Point(557, 47);
      this.ZeitLabel.Name = "ZeitLabel";
      this.ZeitLabel.Size = new System.Drawing.Size(36, 17);
      this.ZeitLabel.TabIndex = 10;
      this.ZeitLabel.Text = "Zeit:";
      // 
      // DatumLabel
      // 
      this.DatumLabel.AutoSize = true;
      this.DatumLabel.Location = new System.Drawing.Point(690, 46);
      this.DatumLabel.Name = "DatumLabel";
      this.DatumLabel.Size = new System.Drawing.Size(53, 17);
      this.DatumLabel.TabIndex = 11;
      this.DatumLabel.Text = "Datum:";
      // 
      // VerbindungenGrid
      // 
      this.VerbindungenGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.VerbindungenGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Pfeil,
            this.Ankunft,
            this.Gridbutton});
      this.VerbindungenGrid.Location = new System.Drawing.Point(107, 301);
      this.VerbindungenGrid.Name = "VerbindungenGrid";
      this.VerbindungenGrid.RowHeadersWidth = 51;
      this.VerbindungenGrid.RowTemplate.Height = 24;
      this.VerbindungenGrid.Size = new System.Drawing.Size(805, 219);
      this.VerbindungenGrid.TabIndex = 12;
      // 
      // Abfahrt
      // 
      this.Abfahrt.HeaderText = "Abfahrt";
      this.Abfahrt.MinimumWidth = 6;
      this.Abfahrt.Name = "Abfahrt";
      this.Abfahrt.Width = 125;
      // 
      // Pfeil
      // 
      this.Pfeil.HeaderText = "------->";
      this.Pfeil.MinimumWidth = 6;
      this.Pfeil.Name = "Pfeil";
      this.Pfeil.Width = 125;
      // 
      // Ankunft
      // 
      this.Ankunft.HeaderText = "Ankunft";
      this.Ankunft.MinimumWidth = 6;
      this.Ankunft.Name = "Ankunft";
      this.Ankunft.Width = 125;
      // 
      // StartstationsText
      // 
      this.StartstationsText.FormattingEnabled = true;
      this.StartstationsText.Location = new System.Drawing.Point(107, 73);
      this.StartstationsText.Name = "StartstationsText";
      this.StartstationsText.Size = new System.Drawing.Size(121, 24);
      this.StartstationsText.TabIndex = 13;
      this.StartstationsText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartstationsText_KeyUp);
      // 
      // EndstationText
      // 
      this.EndstationText.FormattingEnabled = true;
      this.EndstationText.Location = new System.Drawing.Point(268, 75);
      this.EndstationText.Name = "EndstationText";
      this.EndstationText.Size = new System.Drawing.Size(121, 24);
      this.EndstationText.TabIndex = 14;
      this.EndstationText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndstationText_KeyUp);
      // 
      // Gridbutton
      // 
      this.Gridbutton.HeaderText = "Per Mail versenden";
      this.Gridbutton.MinimumWidth = 6;
      this.Gridbutton.Name = "Gridbutton";
      this.Gridbutton.Width = 125;
      // 
      // TimePicker
      // 
      this.TimePicker.CustomFormat = "HH:mm";
      this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.TimePicker.Location = new System.Drawing.Point(560, 74);
      this.TimePicker.Name = "TimePicker";
      this.TimePicker.ShowUpDown = true;
      this.TimePicker.Size = new System.Drawing.Size(94, 22);
      this.TimePicker.TabIndex = 15;
      // 
      // StationaufKarte
      // 
      this.StationaufKarte.Location = new System.Drawing.Point(107, 104);
      this.StationaufKarte.Name = "StationaufKarte";
      this.StationaufKarte.Size = new System.Drawing.Size(141, 27);
      this.StationaufKarte.TabIndex = 16;
      this.StationaufKarte.Text = "Auf Karte anzeigen";
      this.StationaufKarte.UseVisualStyleBackColor = true;
      this.StationaufKarte.Click += new System.EventHandler(this.StationaufKarte_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(994, 550);
      this.Controls.Add(this.StationaufKarte);
      this.Controls.Add(this.TimePicker);
      this.Controls.Add(this.EndstationText);
      this.Controls.Add(this.StartstationsText);
      this.Controls.Add(this.VerbindungenGrid);
      this.Controls.Add(this.DatumLabel);
      this.Controls.Add(this.ZeitLabel);
      this.Controls.Add(this.EndstationLabel);
      this.Controls.Add(this.Startstationlabel);
      this.Controls.Add(this.KarteButton);
      this.Controls.Add(this.FahrplanButton);
      this.Controls.Add(this.VerbindungSuchenButton);
      this.Controls.Add(this.DatePicker);
      this.Controls.Add(this.AbfahrtAnkunftBox);
      this.Name = "Main";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ComboBox AbfahrtAnkunftBox;
    private System.Windows.Forms.DateTimePicker DatePicker;
    private System.Windows.Forms.Button VerbindungSuchenButton;
    private System.Windows.Forms.Button FahrplanButton;
    private System.Windows.Forms.Button KarteButton;
    private System.Windows.Forms.Label Startstationlabel;
    private System.Windows.Forms.Label EndstationLabel;
    private System.Windows.Forms.Label ZeitLabel;
    private System.Windows.Forms.Label DatumLabel;
    private System.Windows.Forms.DataGridView VerbindungenGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Pfeil;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    private System.Windows.Forms.ComboBox StartstationsText;
    private System.Windows.Forms.ComboBox EndstationText;
    private System.Windows.Forms.DataGridViewButtonColumn Gridbutton;
    private System.Windows.Forms.DateTimePicker TimePicker;
    private System.Windows.Forms.Button StationaufKarte;
  }
}

