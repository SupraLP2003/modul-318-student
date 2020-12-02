using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
  public partial class Abfahrtsplan : Form
  {
    private ITransport _transport = new Transport();
    protected override void WndProc(ref Message m)
    {
      switch (m.Msg)
      {
        case 0x84:
          base.WndProc(ref m);
          if ((int)m.Result == 0x1)
            m.Result = (IntPtr)0x2;
          return;
      }

      base.WndProc(ref m);
    }


    public Abfahrtsplan()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      Stations Abfahrtsplan = _transport.GetStations(query: AbfahrtsstarionText.Text);
      Abfahrtsplanform abfahrtsplanform = new Abfahrtsplanform(Abfahrtsplan, _transport);
      if (Abfahrtsplan.StationList.Count != 0)
      {
        abfahrtsplanform.ShowDialog();
      }
    }

    private void AbfahrtsstarionText_KeyUp(object sender, KeyEventArgs e)
    {
      var stationen = _transport.GetStations(AbfahrtsstarionText.Text);
      if (stationen.StationList.Count != 0)
      {
        AbfahrtsstarionText.Items.Clear();

        foreach (Station station in stationen.StationList)
        {
          AbfahrtsstarionText.Focus();
          AbfahrtsstarionText.SelectionStart = AbfahrtsstarionText.Text.Length;
          if (station.Name != null)
          {
            AbfahrtsstarionText.Items.Add(station.Name);
          }

        }

      }
    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}