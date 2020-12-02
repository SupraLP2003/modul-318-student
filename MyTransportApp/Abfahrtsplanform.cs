using System;
using SwissTransport;
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
  public partial class Abfahrtsplanform : Form
  {
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

    public Abfahrtsplanform(SwissTransport.Stations Abfahrtsplan, ITransport _transport)
    {
      InitializeComponent();
      if (Abfahrtsplan.StationList.Count != 0)
      {

        StationBoardRoot stationBoardRoot = _transport.GetStationBoard(Abfahrtsplan.StationList[0].Name, Abfahrtsplan.StationList[0].Id);
        foreach (StationBoard Item in stationBoardRoot.Entries)
        {
          AbfahrtsplanGrid.Rows.Add(Item.Stop.Departure,Item.Name, Item.To);
        }
      }
      else
      {
        MessageBox.Show("Bitte Wählen Sie eine Gültige Station aus");
      }

    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
