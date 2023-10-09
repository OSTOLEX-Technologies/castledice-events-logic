namespace casltedice_events_logic.ServerToClient;

public class MatchFoundDTO
{
    public List<int> PlayerIds { get; set; }
    public string GameUUID { get; set; }

    public MatchFoundDTO(List<int> playerIds, string gameUuid)
    {
        PlayerIds = playerIds;
        GameUUID = gameUuid;
    }
}