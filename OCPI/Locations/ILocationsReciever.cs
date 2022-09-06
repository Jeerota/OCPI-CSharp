namespace OCPI.Locations
{
    public interface ILocationsReciever
    {
        //The below three methods should all be called by the GetLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //GET Request
        Location GetLocation(string countryCode, string partyId, string locationId);
        //GET Request
        EVSE GetEVSE(string countryCode, string partyId, string locationId, string evseUid);
        //GET Request
        Connector GetConnector(string countryCode, string partyId, string locationId, string evseUid, string connectorId);
        //The below three methods should all be called by the SaveLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //PUT Request
        void SaveLocation(string countryCode, string partyId, string locationId);
        //PUT Request, EVSE in body
        void SaveEVSE(string countryCode, string partyId, string locationId, string evseUid);
        //PUT Request, Connector in body.
        void SaveConnector(string countryCode, string partyId, string locationId, string evseUid, string connectorId);
        //The below three methods should all be called by the SaveLocationEVSEConenctor API method and return one of
        //the three values depending on parameters.
        //PATCH Request
        void PatchLocation(string countryCode, string partyId, string locationId);
        //PATCH Request, EVSE in body
        void PatchEVSE(string countryCode, string partyId, string locationId, string evseUid);
        //PATCH Request, Connector in body.
        void PatchConnector(string countryCode, string partyId, string locationId, string evseUid, string connectorId);
    }
}
