namespace OCPI.Tokens
{
    public interface ITokensSender
    {
        //GET Request
        IEnumerable<Token> GetTokens(DateTime? dateFrom, DateTime? dateTo, int? limit, int? offset = 0);
        //POST Request. LocationReferences passed in body.
        AuthorizationInfo AuthorizeTokenForLocation(string tokenUid, TokenType? type = TokenType.RFID);
    }
}
