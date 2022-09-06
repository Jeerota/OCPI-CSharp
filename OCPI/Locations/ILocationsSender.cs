namespace OCPI.Locations
{
    public interface ILocationSender
    {
        //GET Request
        IEnumerable<Location> GetLocations(DateTime? dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
        //The below three methods should all be called by the GetLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //GET Request
        Location GetLocation(string locationId);
        //GET Request
        EVSE GetEVSE(string locationId, string evseUid);
        //GET Request
        Connector GetConnector(string locationId, string evseUid, string connectorId);
    }
}
