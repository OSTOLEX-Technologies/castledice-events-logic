namespace casltedice_events_logic.ServerToClient;

public enum ServerToClientMessageType : ushort
{
    MatchFound,
    CreateGame,
    ApproveMove,
    GiveActionPoints,
    MakeMove,
    CancelGame
}