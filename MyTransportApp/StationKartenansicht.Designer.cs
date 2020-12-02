namespace MyTransportApp
{
  partial class StationKartenansicht
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
      this.gMap = new GMap.NET.WindowsForms.GMapControl();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // gMap
      // 
      this.gMap.Bearing = 0F;
      this.gMap.CanDragMap = true;
      this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
      this.gMap.GrayScaleMode = false;
      this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
      this.gMap.LevelsKeepInMemmory = 5;
      this.gMap.Location = new System.Drawing.Point(206, 48);
      this.gMap.MarkersEnabled = true;
      this.gMap.MaxZoom = 2;
      this.gMap.MinZoom = 2;
      this.gMap.MouseWheelZoomEnabled = true;
      this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
      this.gMap.Name = "gMap";
      this.gMap.NegativeMode = false;
      this.gMap.PolygonsEnabled = true;
      this.gMap.RetryLoadTile = 0;
      this.gMap.RoutesEnabled = true;
      this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
      this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
      this.gMap.ShowTileGridLines = false;
      this.gMap.Size = new System.Drawing.Size(534, 390);
      this.gMap.TabIndex = 0;
      this.gMap.Zoom = 0D;
      this.gMap.Load += new System.EventHandler(this.GMap_Load);
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
      // pictureBox1
      // 
      this.pictureBox1.Image = global::MyTransportApp.Properties.Resources.schliessen;
      this.pictureBox1.Location = new System.Drawing.Point(754, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(34, 32);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
      // 
      // StationKartenansicht
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.gMap);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "StationKartenansicht";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private GMap.NET.WindowsForms.GMapControl gMap;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}