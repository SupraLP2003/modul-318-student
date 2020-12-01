using SwissTransport;
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

namespace MyTransportApp
{
  public partial class Main : Form
  {
   private ITransport _transport = new Transport();
 
    public Main()
    {
      InitializeComponent();

      
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
          StartstationsText.Items.Add(station.Name);
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
  }
}
