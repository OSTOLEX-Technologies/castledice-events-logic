namespace castledice_events_logic.ClientToServer;

public class InitializePlayerDTO : ClientToServerDTO
{
    public InitializePlayerDTO(string verificationKey) : base(verificationKey)
    {
    }
}