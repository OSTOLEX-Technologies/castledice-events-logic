namespace casltedice_events_logic.ClientToServer;

public class InitializeClientDTO : ClientToServerDTO
{
    public InitializeClientDTO(string verificationKey) : base(verificationKey)
    {
    }
}