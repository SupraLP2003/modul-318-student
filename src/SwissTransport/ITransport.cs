namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion, string date, string time, int isArrivalTime);
        Stations GetCloseStations(string x, string y);
    object GetConnections(string v1, string v2, string v3, string v4);
  }
}