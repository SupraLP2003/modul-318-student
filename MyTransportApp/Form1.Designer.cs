namespace MyTransportApp
{
  partial class Form1
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
      this.StartstationsText = new System.Windows.Forms.TextBox();
      this.EndstationText = new System.Windows.Forms.TextBox();
      this.AbfahrtAnkunftBox = new System.Windows.Forms.ComboBox();
      this.ZeitBox = new System.Windows.Forms.ComboBox();
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
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // StartstationsText
      // 
      this.StartstationsText.Location = new System.Drawing.Point(104, 73);
      this.StartstationsText.Name = "StartstationsText";
      this.StartstationsText.Size = new System.Drawing.Size(100, 22);
      this.StartstationsText.TabIndex = 0;
      // 
      // EndstationText
      // 
      this.EndstationText.Location = new System.Drawing.Point(265, 72);
      this.EndstationText.Name = "EndstationText";
      this.EndstationText.Size = new System.Drawing.Size(100, 22);
      this.EndstationText.TabIndex = 1;
      // 
      // AbfahrtAnkunftBox
      // 
      this.AbfahrtAnkunftBox.FormattingEnabled = true;
      this.AbfahrtAnkunftBox.Items.AddRange(new object[] {
            "Ankunftszeit",
            "Abfahrtszeit"});
      this.AbfahrtAnkunftBox.Location = new System.Drawing.Point(408, 71);
      this.AbfahrtAnkunftBox.Name = "AbfahrtAnkunftBox";
      this.AbfahrtAnkunftBox.Size = new System.Drawing.Size(121, 24);
      this.AbfahrtAnkunftBox.TabIndex = 2;
      // 
      // ZeitBox
      // 
      this.ZeitBox.FormattingEnabled = true;
      this.ZeitBox.Items.AddRange(new object[] {
            "00.00",
            "01.00",
            "02.00",
            "03.00",
            "04.00",
            "05.00",
            "06.00",
            "07.00",
            "08.00",
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00",
            "19.00",
            "20.00",
            "21.00",
            "22.00",
            "23.00"});
      this.ZeitBox.Location = new System.Drawing.Point(557, 70);
      this.ZeitBox.Name = "ZeitBox";
      this.ZeitBox.Size = new System.Drawing.Size(103, 24);
      this.ZeitBox.TabIndex = 3;
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
      // 
      // KarteButton
      // 
      this.KarteButton.Location = new System.Drawing.Point(757, 166);
      this.KarteButton.Name = "KarteButton";
      this.KarteButton.Size = new System.Drawing.Size(75, 23);
      this.KarteButton.TabIndex = 7;
      this.KarteButton.Text = "Karte";
      this.KarteButton.UseVisualStyleBackColor = true;
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
            this.Ankunft});
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(994, 550);
      this.Controls.Add(this.VerbindungenGrid);
      this.Controls.Add(this.DatumLabel);
      this.Controls.Add(this.ZeitLabel);
      this.Controls.Add(this.EndstationLabel);
      this.Controls.Add(this.Startstationlabel);
      this.Controls.Add(this.KarteButton);
      this.Controls.Add(this.FahrplanButton);
      this.Controls.Add(this.VerbindungSuchenButton);
      this.Controls.Add(this.DatePicker);
      this.Controls.Add(this.ZeitBox);
      this.Controls.Add(this.AbfahrtAnkunftBox);
      this.Controls.Add(this.EndstationText);
      this.Controls.Add(this.StartstationsText);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox StartstationsText;
    private System.Windows.Forms.TextBox EndstationText;
    private System.Windows.Forms.ComboBox AbfahrtAnkunftBox;
    private System.Windows.Forms.ComboBox ZeitBox;
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
  }
}

