namespace OCPI.Tariffs
{
    public interface ITariffsReciever
    {
        //GET Request.
        Tariff GetTariff(string countryCode, string partyId, string tariffId);
        //PUT request. Tariff passed in body.
        void SaveTariff(string countryCode, string partyId, string tariffId);
        //DELETE request, although defined is deprecated and should not be used. Therefore is excluded from this interface.
    }
}
