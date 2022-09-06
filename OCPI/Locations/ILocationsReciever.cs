namespace OCPI.Locations
{
    public interface ILocationsReciever
    {
        //The below three methods should all be called by the GetLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //GET Request
        public Location GetLocation(string countryCode, string partyId, string locationId);
        //GET Request
        public EVSE GetEVSE(string countryCode, string partyId, string locationId, string evseUid);
        //GET Request
        public Connector GetConnector(string countryCode, string partyId, string locationId, string evseUid, string connectorId);
        //The below three methods should all be called by the SaveLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //PUT Request
        public void SaveLocation(string countryCode, string partyId, string locationId);
        //PUT Request, EVSE in body
        public void SaveEVSE(string countryCode, string partyId, string locationId, string evseUid);
        //PUT Request, Connector in body.
        public void SaveConnector(string countryCode, string partyId, string locationId, string evseUid, string connectorId);
        //The below three methods should all be called by the SaveLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //PATCH Request
        public void PatchLocation(string countryCode, string partyId, string locationId);
        //PATCH Request, EVSE in body
        public void PatchEVSE(string countryCode, string partyId, string locationId, string evseUid);
        //PATCH Request, Connector in body.
        public void PatchConnector(string countryCode, string partyId, string locationId, string evseUid, string connectorId);
    }
}
