using SwissTransport;
using System.Device.Location;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyTransportApp
{
  public partial class Main : Form
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
    GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

    void watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
    {


    }

    public Main()
    {
      InitializeComponent();
      watcher.Start();
      watcher.TryStart(false, TimeSpan.FromMilliseconds(100000));
      watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);
    }

    private void VerbindungSuchenButton_Click(object sender, EventArgs e)
    {
      
     VerbindungenGrid.Rows.Clear();
     var Zeitumwandler = CultureInfo.InvariantCulture;
     var datepicker = DateTime.Parse(DatePicker.Value.ToString());
      int isArrivalTime = 0;
      if (AbfahrtAnkunftBox.Text == "Ankunftszeit")
      {
        isArrivalTime = 1;
      }
     var connections = _transport.GetConnections(StartstationsText.Text, EndstationText.Text, datepicker.ToString("yyyy-MM-dd", Zeitumwandler), TimePicker.Value.ToString(), isArrivalTime);
     var Stundevergleich = DateTime.Parse("01:00");
     foreach (var item in connections.ConnectionList)
     {
        var departuretime = DateTime.Parse(item.From.Departure);
        var arrivaltime = DateTime.Parse(item.To.Arrival);
        var fahrtdauer = arrivaltime - departuretime;
        var fahrtdauervergleich = DateTime.Parse(fahrtdauer.ToString());
        string fahrtzeit = "";
        string einheit = "";
        if (fahrtdauervergleich > Stundevergleich) { fahrtzeit = "HH:mm"; einheit = " h"; } else { fahrtzeit = "mm"; einheit = " min"; }
        VerbindungenGrid.Rows.Add(item.From.Station.Name + " " + departuretime.ToString("HH:mm", Zeitumwandler),fahrtdauervergleich.ToString(fahrtzeit, Zeitumwandler) + einheit, arrivaltime.ToString("HH:mm", Zeitumwandler) + " " + item.To.Station.Name);

     }
      
    }

    private void FahrplanButton_Click(object sender, EventArgs e)
    {
      Stations Abfahrtsplan = _transport.GetStations(query: StartstationsText.Text);
      Abfahrtsplanform abfahrtsplanform = new Abfahrtsplanform(Abfahrtsplan, _transport);
      if (Abfahrtsplan.StationList.Count != 0)
      {
        abfahrtsplanform.ShowDialog();
      }
    }

    private void KarteButton_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Diese Funktion wird demnächst erscheinen");
    }

    private void StartstationsText_KeyUp(object sender, KeyEventArgs e)
    {
      var stationen = _transport.GetStations(StartstationsText.Text);
      if (stationen.StationList.Count != 0)
      {
        StartstationsText.Items.Clear();

        foreach (Station station in stationen.StationList)
        {
          StartstationsText.Focus();
          StartstationsText.SelectionStart = StartstationsText.Text.Length;
          if (station.Name != null)
          {
            StartstationsText.Items.Add(station.Name);
          }
          
        }
      }

    }

    private void EndstationText_KeyUp(object sender, KeyEventArgs e)
    {
      var stationen = _transport.GetStations(EndstationText.Text);
      if (stationen.StationList.Count != 0)
      {
        EndstationText.Items.Clear();

        foreach (Station station in stationen.StationList)
        {
          EndstationText.Focus();
          EndstationText.SelectionStart = EndstationText.Text.Length;
          EndstationText.Items.Add(station.Name);
        }
      }
    }

    private void StationaufKarte_Click(object sender, EventArgs e)
    {
      var station = _transport.GetStations(StartstationsText.Text);
      var xCoordinate = station.StationList[0].Coordinate.XCoordinate ;
      var yCoordinate = station.StationList[0].Coordinate.YCoordinate;
      StationKartenansicht stationKartenansicht = new StationKartenansicht(yCoordinate, xCoordinate);
      stationKartenansicht.ShowDialog();
    }

    private void PictureBox2_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void HomeButtonAbfahrtsplan_Click(object sender, EventArgs e)
    {
      Abfahrtsplan abfahrtsplan = new Abfahrtsplan();
      abfahrtsplan.ShowDialog();
    }

    private void PictureBox5_Click(object sender, EventArgs e)
    {
      if (StartstationsText.Text != "")
      {
        var station = _transport.GetStations(StartstationsText.Text);
        var xCoordinate = station.StationList[0].Coordinate.XCoordinate;
        var yCoordinate = station.StationList[0].Coordinate.YCoordinate;
        StationKartenansicht stationKartenansicht = new StationKartenansicht(yCoordinate, xCoordinate);
        stationKartenansicht.ShowDialog();

      }

    }

    private void PictureBox6_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"FAQ:{Environment.NewLine}{Environment.NewLine}F: Wie Sehe ich die Station auf der Karte?{Environment.NewLine}A: Sie können auf das Kartensymbol neben der Startstations eingabe klicken.");
    }

    private void Stationenindernaehe_Click(object sender, EventArgs e)
    {
      GeoCoordinate coord = watcher.Position.Location;

      if (coord.IsUnknown != true)
      {
        Stationenindernaehe stationnaehe = new Stationenindernaehe(coord, _transport);
        stationnaehe.ShowDialog();
      }
      else
      {
        MessageBox.Show("Ihre Koordinaten konnten nicht gelesen werden. Stellen sicher, dass Sie GPS an haben und Empfang haben");
      }

      watcher.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(watcher_StatusChanged);
    }

    private void VerbindungenGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var senderGrid = (DataGridView)sender;

      if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
          e.RowIndex >= 0)
      {
        string duration = VerbindungenGrid.Rows[e.RowIndex].Cells["Pfeil"].FormattedValue.ToString();
        string abfahrt = VerbindungenGrid.Rows[e.RowIndex].Cells["Abfahrt"].FormattedValue.ToString();
        string Ankunft = VerbindungenGrid.Rows[e.RowIndex].Cells["Ankunft"].FormattedValue.ToString();
        var body = abfahrt +" "+ duration +" "+ Ankunft ;
        Process.Start(
                    "mailto:" + "" +
                    "?subject=" + "Verbindung Teilen" +
                    "&body=" + body
                    );
      }
    }
  }
}
