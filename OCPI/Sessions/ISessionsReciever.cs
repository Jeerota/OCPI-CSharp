namespace OCPI.Sessions
{
    public interface ISessionsReciever
    {
        //GET Request
        Session GetSession(string countryCode, string partyId, string sessionId);
        //PUT Request, Session passed in body.
        void SaveSession(string countryCode, string partyId, string sessionId);
        //PATCH Request, NULL values in session body are considered unchanged.
        void PatchSession(string countryCode, string partyId, string sessionId);
    }
}
