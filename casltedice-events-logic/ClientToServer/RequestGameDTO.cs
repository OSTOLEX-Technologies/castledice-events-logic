namespace casltedice_events_logic.ClientToServer;

[Serializable]
public sealed class RequestGameDTO : ClientToServerDTO
{
    public RequestGameDTO(string verificationKey) : base(verificationKey)
    {

    }
}