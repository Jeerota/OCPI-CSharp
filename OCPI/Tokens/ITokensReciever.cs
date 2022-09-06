namespace OCPI.Tokens
{
    public interface ITokensReciever
    {
        //GET Request.
        Token GetToken(string countryCode, string partyId, string tokenUid, TokenType? type = TokenType.RFID);
        //PUT request. Token passed in body.
        void SaveToken(string countryCode, string partyId, string tokenUid, TokenType? type = TokenType.RFID);
        //PATCH request, Token passed in body, null values are considered unchanged.
        void PatchToken(string countryCode, string partyId, string tokenUid, TokenType? type);
    }
}
