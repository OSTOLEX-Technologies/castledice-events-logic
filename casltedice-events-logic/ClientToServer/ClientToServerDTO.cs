namespace casltedice_events_logic.ClientToServer;

[Serializable]
public abstract class ClientToServerDTO
{
    public string VerificationKey { get; set; }
    
    protected ClientToServerDTO(string verificationKey)
    {
        VerificationKey = verificationKey;
    }
}