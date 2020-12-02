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
