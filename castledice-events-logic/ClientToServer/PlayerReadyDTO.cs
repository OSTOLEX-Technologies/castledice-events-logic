namespace castledice_events_logic.ClientToServer;

public sealed class PlayerReadyDTO : ClientToServerDTO
{
    public PlayerReadyDTO(string verificationKey) : base(verificationKey)
    {
    }
}