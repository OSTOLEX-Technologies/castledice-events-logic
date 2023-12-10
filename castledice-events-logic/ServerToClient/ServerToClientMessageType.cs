namespace castledice_events_logic.ServerToClient;

//Values start from 100 to avoid collision with ClientToServerMessageType
public enum ServerToClientMessageType : ushort
{
    MatchFound = 100,
    CreateGame = 101,
    ApproveMove = 102,
    GiveActionPoints = 103,
    MakeMove = 104,
    CancelGame = 105,
    Error = 106,
}