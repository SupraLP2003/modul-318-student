namespace MyTransportApp
{
  partial class Abfahrtsplanform
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.AbfahrtsplanGrid = new System.Windows.Forms.DataGridView();
      this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TransportNR = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Richtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.AbfahrtsplanGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // AbfahrtsplanGrid
      // 
      this.AbfahrtsplanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AbfahrtsplanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.TransportNR,
            this.Richtung});
      this.AbfahrtsplanGrid.Location = new System.Drawing.Point(206, 78);
      this.AbfahrtsplanGrid.Name = "AbfahrtsplanGrid";
      this.AbfahrtsplanGrid.RowHeadersWidth = 51;
      this.AbfahrtsplanGrid.RowTemplate.Height = 24;
      this.AbfahrtsplanGrid.Size = new System.Drawing.Size(564, 377);
      this.AbfahrtsplanGrid.TabIndex = 0;
      // 
      // Abfahrt
      // 
      this.Abfahrt.HeaderText = "Abfahrt";
      this.Abfahrt.MinimumWidth = 6;
      this.Abfahrt.Name = "Abfahrt";
      this.Abfahrt.Width = 125;
      // 
      // TransportNR
      // 
      this.TransportNR.HeaderText = "Zug/Bus Nummer";
      this.TransportNR.MinimumWidth = 6;
      this.TransportNR.Name = "TransportNR";
      this.TransportNR.Width = 125;
      // 
      // Richtung
      // 
      this.Richtung.HeaderText = "Richtung";
      this.Richtung.MinimumWidth = 6;
      this.Richtung.Name = "Richtung";
      this.Richtung.Width = 125;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Red;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 513);
      this.panel1.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::MyTransportApp.Properties.Resources.schliessen;
      this.pictureBox1.Location = new System.Drawing.Point(714, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(56, 39);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
      // 
      // Abfahrtsplanform
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(785, 513);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.AbfahrtsplanGrid);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Abfahrtsplanform";
      this.Text = "Form2";
      ((System.ComponentModel.ISupportInitialize)(this.AbfahrtsplanGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView AbfahrtsplanGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn TransportNR;
    private System.Windows.Forms.DataGridViewTextBoxColumn Richtung;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}