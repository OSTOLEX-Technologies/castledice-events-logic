namespace castledice_events_logic.ClientToServer;

[Serializable]
public sealed class CancelGameDTO : ClientToServerDTO
{
    public CancelGameDTO(string verificationKey) : base(verificationKey)
    {
    }
}