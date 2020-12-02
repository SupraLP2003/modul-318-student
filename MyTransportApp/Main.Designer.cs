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
      this.Startstationlabel = new System.Windows.Forms.Label();
      this.EndstationLabel = new System.Windows.Forms.Label();
      this.ZeitLabel = new System.Windows.Forms.Label();
      this.DatumLabel = new System.Windows.Forms.Label();
      this.VerbindungenGrid = new System.Windows.Forms.DataGridView();
      this.StartstationsText = new System.Windows.Forms.ComboBox();
      this.EndstationText = new System.Windows.Forms.ComboBox();
      this.TimePicker = new System.Windows.Forms.DateTimePicker();
      this.RedPanel = new System.Windows.Forms.Panel();
      this.Stationenindernaehe = new System.Windows.Forms.Button();
      this.HomeButtonAbfahrtsplan = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.KartePicture = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.InfoButton = new System.Windows.Forms.PictureBox();
      this.pictureBox4 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Pfeil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Sendmail = new System.Windows.Forms.DataGridViewButtonColumn();
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).BeginInit();
      this.RedPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.KartePicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.InfoButton)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // AbfahrtAnkunftBox
      // 
      this.AbfahrtAnkunftBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.AbfahrtAnkunftBox.FormattingEnabled = true;
      this.AbfahrtAnkunftBox.Items.AddRange(new object[] {
            "Ankunftszeit",
            "Abfahrtszeit"});
      this.AbfahrtAnkunftBox.Location = new System.Drawing.Point(876, 180);
      this.AbfahrtAnkunftBox.Name = "AbfahrtAnkunftBox";
      this.AbfahrtAnkunftBox.Size = new System.Drawing.Size(121, 24);
      this.AbfahrtAnkunftBox.TabIndex = 3;
      // 
      // DatePicker
      // 
      this.DatePicker.Location = new System.Drawing.Point(519, 180);
      this.DatePicker.Name = "DatePicker";
      this.DatePicker.Size = new System.Drawing.Size(222, 22);
      this.DatePicker.TabIndex = 5;
      // 
      // VerbindungSuchenButton
      // 
      this.VerbindungSuchenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.VerbindungSuchenButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.VerbindungSuchenButton.ForeColor = System.Drawing.Color.White;
      this.VerbindungSuchenButton.Location = new System.Drawing.Point(522, 463);
      this.VerbindungSuchenButton.Name = "VerbindungSuchenButton";
      this.VerbindungSuchenButton.Size = new System.Drawing.Size(544, 52);
      this.VerbindungSuchenButton.TabIndex = 6;
      this.VerbindungSuchenButton.Text = "Verbindungen Suchen";
      this.VerbindungSuchenButton.UseVisualStyleBackColor = false;
      this.VerbindungSuchenButton.Click += new System.EventHandler(this.VerbindungSuchenButton_Click);
      // 
      // Startstationlabel
      // 
      this.Startstationlabel.AutoSize = true;
      this.Startstationlabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Startstationlabel.ForeColor = System.Drawing.Color.Red;
      this.Startstationlabel.Location = new System.Drawing.Point(518, 23);
      this.Startstationlabel.Name = "Startstationlabel";
      this.Startstationlabel.Size = new System.Drawing.Size(86, 18);
      this.Startstationlabel.TabIndex = 8;
      this.Startstationlabel.Text = "Startstation";
      // 
      // EndstationLabel
      // 
      this.EndstationLabel.AutoSize = true;
      this.EndstationLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EndstationLabel.ForeColor = System.Drawing.Color.Red;
      this.EndstationLabel.Location = new System.Drawing.Point(519, 98);
      this.EndstationLabel.Name = "EndstationLabel";
      this.EndstationLabel.Size = new System.Drawing.Size(82, 18);
      this.EndstationLabel.TabIndex = 9;
      this.EndstationLabel.Text = "Endstation";
      // 
      // ZeitLabel
      // 
      this.ZeitLabel.AutoSize = true;
      this.ZeitLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ZeitLabel.ForeColor = System.Drawing.Color.Red;
      this.ZeitLabel.Location = new System.Drawing.Point(750, 157);
      this.ZeitLabel.Name = "ZeitLabel";
      this.ZeitLabel.Size = new System.Drawing.Size(38, 18);
      this.ZeitLabel.TabIndex = 10;
      this.ZeitLabel.Text = "Zeit:";
      // 
      // DatumLabel
      // 
      this.DatumLabel.AutoSize = true;
      this.DatumLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.DatumLabel.ForeColor = System.Drawing.Color.Red;
      this.DatumLabel.Location = new System.Drawing.Point(516, 160);
      this.DatumLabel.Name = "DatumLabel";
      this.DatumLabel.Size = new System.Drawing.Size(60, 18);
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
            this.Sendmail});
      this.VerbindungenGrid.Location = new System.Drawing.Point(519, 228);
      this.VerbindungenGrid.Name = "VerbindungenGrid";
      this.VerbindungenGrid.RowHeadersWidth = 51;
      this.VerbindungenGrid.RowTemplate.Height = 24;
      this.VerbindungenGrid.Size = new System.Drawing.Size(668, 219);
      this.VerbindungenGrid.TabIndex = 12;
      this.VerbindungenGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerbindungenGrid_CellContentClick);
      // 
      // StartstationsText
      // 
      this.StartstationsText.FormattingEnabled = true;
      this.StartstationsText.Location = new System.Drawing.Point(519, 52);
      this.StartstationsText.Name = "StartstationsText";
      this.StartstationsText.Size = new System.Drawing.Size(460, 24);
      this.StartstationsText.TabIndex = 1;
      this.StartstationsText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartstationsText_KeyUp);
      // 
      // EndstationText
      // 
      this.EndstationText.FormattingEnabled = true;
      this.EndstationText.Location = new System.Drawing.Point(519, 118);
      this.EndstationText.Name = "EndstationText";
      this.EndstationText.Size = new System.Drawing.Size(460, 24);
      this.EndstationText.TabIndex = 2;
      this.EndstationText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EndstationText_KeyUp);
      // 
      // TimePicker
      // 
      this.TimePicker.CustomFormat = "HH:mm";
      this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.TimePicker.Location = new System.Drawing.Point(753, 180);
      this.TimePicker.Name = "TimePicker";
      this.TimePicker.ShowUpDown = true;
      this.TimePicker.Size = new System.Drawing.Size(94, 22);
      this.TimePicker.TabIndex = 4;
      // 
      // RedPanel
      // 
      this.RedPanel.BackColor = System.Drawing.Color.Red;
      this.RedPanel.Controls.Add(this.InfoButton);
      this.RedPanel.Controls.Add(this.pictureBox4);
      this.RedPanel.Controls.Add(this.pictureBox3);
      this.RedPanel.Controls.Add(this.Stationenindernaehe);
      this.RedPanel.Controls.Add(this.HomeButtonAbfahrtsplan);
      this.RedPanel.Controls.Add(this.pictureBox1);
      this.RedPanel.Controls.Add(this.label1);
      this.RedPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.RedPanel.Location = new System.Drawing.Point(0, 0);
      this.RedPanel.Name = "RedPanel";
      this.RedPanel.Size = new System.Drawing.Size(495, 527);
      this.RedPanel.TabIndex = 13;
      // 
      // Stationenindernaehe
      // 
      this.Stationenindernaehe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Stationenindernaehe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Stationenindernaehe.ForeColor = System.Drawing.Color.White;
      this.Stationenindernaehe.Location = new System.Drawing.Point(144, 317);
      this.Stationenindernaehe.Name = "Stationenindernaehe";
      this.Stationenindernaehe.Size = new System.Drawing.Size(308, 49);
      this.Stationenindernaehe.TabIndex = 4;
      this.Stationenindernaehe.Text = "Stationen in der Nähe";
      this.Stationenindernaehe.UseVisualStyleBackColor = false;
      this.Stationenindernaehe.Click += new System.EventHandler(this.Stationenindernaehe_Click);
      // 
      // HomeButtonAbfahrtsplan
      // 
      this.HomeButtonAbfahrtsplan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.HomeButtonAbfahrtsplan.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HomeButtonAbfahrtsplan.ForeColor = System.Drawing.Color.White;
      this.HomeButtonAbfahrtsplan.Location = new System.Drawing.Point(144, 228);
      this.HomeButtonAbfahrtsplan.Name = "HomeButtonAbfahrtsplan";
      this.HomeButtonAbfahrtsplan.Size = new System.Drawing.Size(308, 49);
      this.HomeButtonAbfahrtsplan.TabIndex = 3;
      this.HomeButtonAbfahrtsplan.Text = "Abfahrtsplan";
      this.HomeButtonAbfahrtsplan.UseVisualStyleBackColor = false;
      this.HomeButtonAbfahrtsplan.Click += new System.EventHandler(this.HomeButtonAbfahrtsplan_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(203, 47);
      this.label1.TabIndex = 0;
      this.label1.Text = "TransportIO";
      // 
      // KartePicture
      // 
      this.KartePicture.Image = global::MyTransportApp.Properties.Resources.Karte;
      this.KartePicture.Location = new System.Drawing.Point(985, 35);
      this.KartePicture.Name = "KartePicture";
      this.KartePicture.Size = new System.Drawing.Size(67, 41);
      this.KartePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.KartePicture.TabIndex = 15;
      this.KartePicture.TabStop = false;
      this.KartePicture.Click += new System.EventHandler(this.PictureBox5_Click);
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::MyTransportApp.Properties.Resources.schliessen;
      this.pictureBox2.Location = new System.Drawing.Point(1156, 12);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(31, 30);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 14;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
      // 
      // InfoButton
      // 
      this.InfoButton.Image = global::MyTransportApp.Properties.Resources._1200px_Infobox_info_icon_svg;
      this.InfoButton.Location = new System.Drawing.Point(21, 464);
      this.InfoButton.Name = "InfoButton";
      this.InfoButton.Size = new System.Drawing.Size(51, 50);
      this.InfoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.InfoButton.TabIndex = 7;
      this.InfoButton.TabStop = false;
      this.InfoButton.Click += new System.EventHandler(this.PictureBox6_Click);
      // 
      // pictureBox4
      // 
      this.pictureBox4.Image = global::MyTransportApp.Properties.Resources.Abfahrtsplan;
      this.pictureBox4.Location = new System.Drawing.Point(73, 228);
      this.pictureBox4.Name = "pictureBox4";
      this.pictureBox4.Size = new System.Drawing.Size(65, 50);
      this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox4.TabIndex = 6;
      this.pictureBox4.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox3.Image = global::MyTransportApp.Properties.Resources.nähe;
      this.pictureBox3.Location = new System.Drawing.Point(73, 317);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(65, 50);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 5;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::MyTransportApp.Properties.Resources.SBBLOGO;
      this.pictureBox1.Location = new System.Drawing.Point(254, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(220, 48);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
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
      // Sendmail
      // 
      this.Sendmail.HeaderText = "Per Mail versenden";
      this.Sendmail.MinimumWidth = 6;
      this.Sendmail.Name = "Sendmail";
      this.Sendmail.Text = "Mail versenden";
      this.Sendmail.Width = 125;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1199, 527);
      this.Controls.Add(this.KartePicture);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.RedPanel);
      this.Controls.Add(this.TimePicker);
      this.Controls.Add(this.EndstationText);
      this.Controls.Add(this.StartstationsText);
      this.Controls.Add(this.VerbindungenGrid);
      this.Controls.Add(this.DatumLabel);
      this.Controls.Add(this.ZeitLabel);
      this.Controls.Add(this.EndstationLabel);
      this.Controls.Add(this.Startstationlabel);
      this.Controls.Add(this.VerbindungSuchenButton);
      this.Controls.Add(this.DatePicker);
      this.Controls.Add(this.AbfahrtAnkunftBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Main";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.VerbindungenGrid)).EndInit();
      this.RedPanel.ResumeLayout(false);
      this.RedPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.KartePicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.InfoButton)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ComboBox AbfahrtAnkunftBox;
    private System.Windows.Forms.DateTimePicker DatePicker;
    private System.Windows.Forms.Button VerbindungSuchenButton;
    private System.Windows.Forms.Label Startstationlabel;
    private System.Windows.Forms.Label EndstationLabel;
    private System.Windows.Forms.Label ZeitLabel;
    private System.Windows.Forms.Label DatumLabel;
    private System.Windows.Forms.DataGridView VerbindungenGrid;
    private System.Windows.Forms.ComboBox StartstationsText;
    private System.Windows.Forms.ComboBox EndstationText;
    private System.Windows.Forms.DateTimePicker TimePicker;
    private System.Windows.Forms.Panel RedPanel;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button Stationenindernaehe;
    private System.Windows.Forms.Button HomeButtonAbfahrtsplan;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox KartePicture;
    private System.Windows.Forms.PictureBox InfoButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn Pfeil;
    private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
    private System.Windows.Forms.DataGridViewButtonColumn Sendmail;
  }
}

