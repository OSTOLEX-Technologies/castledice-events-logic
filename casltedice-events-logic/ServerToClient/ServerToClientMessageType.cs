namespace casltedice_events_logic.ServerToClient;

public enum ServerToClientMessageType
{
    MatchFound,
    CreateGame,
    ApproveMove,
    GiveActionPoints,
    MakeMove,
    CancelGame
}