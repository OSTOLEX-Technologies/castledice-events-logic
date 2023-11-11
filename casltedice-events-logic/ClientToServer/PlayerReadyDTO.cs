namespace casltedice_events_logic.ClientToServer;

public class PlayerReadyDTO : ClientToServerDTO
{
    public PlayerReadyDTO(string verificationKey) : base(verificationKey)
    {
    }
}