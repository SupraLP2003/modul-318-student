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
      ((System.ComponentModel.ISupportInitialize)(this.AbfahrtsplanGrid)).BeginInit();
      this.SuspendLayout();
      // 
      // AbfahrtsplanGrid
      // 
      this.AbfahrtsplanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AbfahrtsplanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.TransportNR,
            this.Richtung});
      this.AbfahrtsplanGrid.Location = new System.Drawing.Point(12, 12);
      this.AbfahrtsplanGrid.Name = "AbfahrtsplanGrid";
      this.AbfahrtsplanGrid.RowHeadersWidth = 51;
      this.AbfahrtsplanGrid.RowTemplate.Height = 24;
      this.AbfahrtsplanGrid.Size = new System.Drawing.Size(560, 392);
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
      // Abfahrtsplanform
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(630, 450);
      this.Controls.Add(this.AbfahrtsplanGrid);
      this.Name = "Abfahrtsplanform";
      this.Text = "Form2";
      ((System.ComponentModel.ISupportInitialize)(this.AbfahrtsplanGrid)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView AbfahrtsplanGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
    private System.Windows.Forms.DataGridViewTextBoxColumn TransportNR;
    private System.Windows.Forms.DataGridViewTextBoxColumn Richtung;
  }
}