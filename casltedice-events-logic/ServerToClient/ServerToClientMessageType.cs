namespace casltedice_events_logic.ServerToClient;

public enum ServerToClientMessageType : ushort
{
    MatchFound = 100,
    CreateGame = 101,
    ApproveMove = 102,
    GiveActionPoints = 103,
    MakeMove = 104,
    CancelGame = 105
}