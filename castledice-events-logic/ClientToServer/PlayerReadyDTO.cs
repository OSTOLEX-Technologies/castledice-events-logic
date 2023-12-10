namespace castledice_events_logic.ClientToServer;

[Serializable]
public sealed class PlayerReadyDTO : ClientToServerDTO
{
    public PlayerReadyDTO(string verificationKey) : base(verificationKey)
    {
    }
}