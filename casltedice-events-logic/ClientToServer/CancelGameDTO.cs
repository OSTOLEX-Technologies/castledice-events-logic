namespace casltedice_events_logic.ClientToServer;

public class CancelGameDTO : ClientToServerDTO
{
    public CancelGameDTO(string verificationKey) : base(verificationKey)
    {
    }
}