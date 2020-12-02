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
  public partial class Stationenindernaehe : Form
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

    public Stationenindernaehe(System.Device.Location.GeoCoordinate coord, SwissTransport.ITransport _transport)
    {
      InitializeComponent();

      Stations stations = _transport.GetCloseStations(coord.Latitude.ToString(), coord.Longitude.ToString());
      foreach (Station station in stations.StationList)
      {
        CloseStationGrid.Rows.Add(station.Name, station.Distance + " m");
      }

    }

    private void PictureBox1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
