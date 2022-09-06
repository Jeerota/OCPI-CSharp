namespace OCPI.Locations
{
    public interface ILocationSender
    {
        //GET Request
        public IEnumerable<Location> GetLocations(DateTime? dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
        //The below three methods should all be called by the GetLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //GET Request
        public Location GetLocation(string locationId);
        //GET Request
        public EVSE GetEVSE(string locationId, string evseUid);
        //GET Request
        public Connector GetConnector(string locationId, string evseUid, string connectorId);
    }
}
