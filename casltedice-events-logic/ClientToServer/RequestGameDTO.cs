namespace casltedice_events_logic.ClientToServer;

[Serializable]
public class RequestGameDTO : ClientToServerDTO
{
    public int PlayerId { get; set; }

    public RequestGameDTO(string verificationKey, int playerId) : base(verificationKey)
    {
        PlayerId = playerId;
    }
}