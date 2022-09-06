namespace OCPI.CDRs
{
    public interface ICDRsReciever
    {
        //GET Request. No structure defined by OCPI for parameters
        CDR GetCDR(string countryCode, string partyId, string id);
        //POST Request. CDR passed in body.
        string CreateCDR();
    }
}
