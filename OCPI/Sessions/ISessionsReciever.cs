namespace OCPI.Sessions
{
    public interface ISessionsReciever
    {
        //GET Request
        public Session GetSession(string countryCode, string partyId, string sessionId);
        //PUT Request, Session passed in body.
        public void SaveSession(string countryCode, string partyId, string sessionId);
        //PATCH Request, NULL values in session body are considered unchanged.
        public void PatchSession(string countryCode, string partyId, string sessionId);
    }
}
