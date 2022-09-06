namespace OCPI.Commands
{
    public interface ICommandsReciever
    {
        //POST Request. CommandType.CANCEL_RESERVATION
        CommandResponse CancelReservation(CancelReservation commandObject);
        //POST Request. CommandType.RESERVE_NOW
        CommandResponse ReserveNow(ReserveNow commandObject);
        //POST Request. CommandType.START_SESSION
        CommandResponse StartSession(StartSession commandObject);
        //POST Request. CommandType.STOP_SESSION
        CommandResponse StopSesssion(StopSession commandObject);
        //POST Request. CommandType.UNLOCK_CONNECTOR
        CommandResponse UnlockConnector(UnlockConnector commandObject);
    }
}
