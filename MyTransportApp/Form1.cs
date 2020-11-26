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
  public partial class Form1 : Form
  {
   private ITransport _transport = new Transport();
 
    public Form1()
    {
      InitializeComponent();

      
    }

    private void VerbindungSuchenButton_Click(object sender, EventArgs e)
    {
      
     VerbindungenGrid.Rows.Clear();
     var Zeitumwandler = CultureInfo.InvariantCulture;
     var result = _transport.GetStations(query: StartstationsText.Text);
     var connections = _transport.GetConnections(StartstationsText.Text, EndstationText.Text);
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
      //MessageBox.Show(connections.ConnectionList[0].To.Station.Name);
    }
  }
}
