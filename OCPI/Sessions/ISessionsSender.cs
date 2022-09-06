namespace OCPI.Sessions
{
    public interface ISessionsSender
    {
        //GET Request
        public IEnumerable<Session> GetSessions(DateTime dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
        //PUT Request, ChargingPreferncesObject passed in body.
        public ChargingPreferencesResponse SetCharginPreferences(string sessionId);
    }
}
