namespace casltedice_events_logic.ClientToServer;

[Serializable]
public class InitializePlayerDTO : ClientToServerDTO
{
    public InitializePlayerDTO(string verificationKey) : base(verificationKey)
    {
    }
}