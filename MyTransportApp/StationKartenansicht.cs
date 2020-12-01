using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MyTransportApp
{
  public partial class StationKartenansicht : Form
  {
    public double YCoordinate;
    public double XCoordinate;
    public StationKartenansicht(double yCoordinate, double xCoordinate)
    {
      InitializeComponent();
      YCoordinate = yCoordinate;
      XCoordinate = xCoordinate;
    }
    
    private void GMap_Load(object sender, EventArgs e)
    {
      gMap.DragButton = MouseButtons.Left;
      gMap.CanDragMap = true;
      gMap.MapProvider = GMapProviders.GoogleMap;
      gMap.Position = new PointLatLng(XCoordinate, YCoordinate);
      gMap.MinZoom = 0;
      gMap.MaxZoom = 24;
      gMap.Zoom = 9;
      gMap.AutoScroll = true;
      GMapOverlay markersOverlay = new GMapOverlay("markers");
      GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(XCoordinate, YCoordinate),
        GMarkerGoogleType.green);
      markersOverlay.Markers.Add(marker);
      gMap.Overlays.Add(markersOverlay);
    }
  }
}
