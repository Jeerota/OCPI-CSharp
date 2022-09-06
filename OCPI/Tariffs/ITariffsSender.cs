namespace OCPI.Tariffs
{
    public interface ITariffsSender
    {
        //GET Request
        IEnumerable<Tariff> GetTariffs(DateTime? dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
    }
}
