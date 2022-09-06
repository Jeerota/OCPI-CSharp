namespace OCPI.CDRs
{
    public interface ICDRsSender
    {
        //GET Request
        IEnumerable<CDR> GetCDRs(DateTime? dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
    }
}
