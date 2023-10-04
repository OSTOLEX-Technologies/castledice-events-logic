namespace casltedice_events_logic.ServerToClient;

[Serializable]
public class GiveActionPointsDTO
{
    public int PlayerId { get; set; }
    public int Amount { get; set; }
}