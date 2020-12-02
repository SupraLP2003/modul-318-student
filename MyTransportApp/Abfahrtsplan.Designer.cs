namespace MyTransportApp
{
  partial class Abfahrtsplan
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.AbfahrtsstarionText = new System.Windows.Forms.ComboBox();
      this.Abfahrtsplansuchen = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Red;
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.ForeColor = System.Drawing.Color.Red;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(124, 450);
      this.panel1.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(155, 166);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(497, 21);
      this.label2.TabIndex = 2;
      this.label2.Text = "von welcher Station möchten Sie den Abfahrtsplan sehen?";
      // 
      // AbfahrtsstarionText
      // 
      this.AbfahrtsstarionText.FormattingEnabled = true;
      this.AbfahrtsstarionText.Location = new System.Drawing.Point(159, 229);
      this.AbfahrtsstarionText.Name = "AbfahrtsstarionText";
      this.AbfahrtsstarionText.Size = new System.Drawing.Size(493, 24);
      this.AbfahrtsstarionText.TabIndex = 3;
      this.AbfahrtsstarionText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AbfahrtsstarionText_KeyUp);
      // 
      // Abfahrtsplansuchen
      // 
      this.Abfahrtsplansuchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Abfahrtsplansuchen.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Abfahrtsplansuchen.ForeColor = System.Drawing.Color.White;
      this.Abfahrtsplansuchen.Location = new System.Drawing.Point(159, 331);
      this.Abfahrtsplansuchen.Name = "Abfahrtsplansuchen";
      this.Abfahrtsplansuchen.Size = new System.Drawing.Size(493, 36);
      this.Abfahrtsplansuchen.TabIndex = 4;
      this.Abfahrtsplansuchen.Text = "Abfahrtsplan zeigen";
      this.Abfahrtsplansuchen.UseVisualStyleBackColor = false;
      this.Abfahrtsplansuchen.Click += new System.EventHandler(this.Button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(159, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(186, 34);
      this.label1.TabIndex = 5;
      this.label1.Text = "Abfahrtsplan";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::MyTransportApp.Properties.Resources.schliessen;
      this.pictureBox1.Location = new System.Drawing.Point(739, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(49, 35);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
      // 
      // Abfahrtsplan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Abfahrtsplansuchen);
      this.Controls.Add(this.AbfahrtsstarionText);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Abfahrtsplan";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox AbfahrtsstarionText;
    private System.Windows.Forms.Button Abfahrtsplansuchen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}