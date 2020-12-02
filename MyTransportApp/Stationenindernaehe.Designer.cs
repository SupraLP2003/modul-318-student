namespace MyTransportApp
{
  partial class Stationenindernaehe
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
      this.CloseStationGrid = new System.Windows.Forms.DataGridView();
      this.Stationen = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Entfernung = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.CloseStationGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // CloseStationGrid
      // 
      this.CloseStationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.CloseStationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stationen,
            this.Entfernung});
      this.CloseStationGrid.Location = new System.Drawing.Point(229, 121);
      this.CloseStationGrid.Name = "CloseStationGrid";
      this.CloseStationGrid.RowHeadersWidth = 51;
      this.CloseStationGrid.RowTemplate.Height = 24;
      this.CloseStationGrid.Size = new System.Drawing.Size(504, 150);
      this.CloseStationGrid.TabIndex = 0;
      // 
      // Stationen
      // 
      this.Stationen.HeaderText = "Stationen";
      this.Stationen.MinimumWidth = 6;
      this.Stationen.Name = "Stationen";
      this.Stationen.Width = 125;
      // 
      // Entfernung
      // 
      this.Entfernung.HeaderText = "Entfernung";
      this.Entfernung.MinimumWidth = 6;
      this.Entfernung.Name = "Entfernung";
      this.Entfernung.Width = 125;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Red;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 450);
      this.panel1.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(229, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(308, 34);
      this.label1.TabIndex = 2;
      this.label1.Text = "Stationen in der Nähe";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::MyTransportApp.Properties.Resources.schliessen;
      this.pictureBox1.Location = new System.Drawing.Point(745, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(43, 36);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
      // 
      // Stationenindernaehe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.CloseStationGrid);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Stationenindernaehe";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.CloseStationGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView CloseStationGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn Stationen;
    private System.Windows.Forms.DataGridViewTextBoxColumn Entfernung;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}