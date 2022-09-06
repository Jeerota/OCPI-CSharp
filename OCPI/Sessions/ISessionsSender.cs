namespace OCPI.Sessions
{
    public interface ISessionsSender
    {
        //GET Request
        IEnumerable<Session> GetSessions(DateTime dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
        //PUT Request, ChargingPreferncesObject passed in body.
        ChargingPreferencesResponse SetChargingPreferences(string sessionId);
    }
}
