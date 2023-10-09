namespace casltedice_events_logic.ClientToServer;

[Serializable]
public abstract class ClientToServerDTO
{
    public string VerificationKey { get; }
    
    protected ClientToServerDTO(string verificationKey)
    {
        VerificationKey = verificationKey;
    }

    protected bool Equals(ClientToServerDTO other)
    {
        return VerificationKey == other.VerificationKey;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ClientToServerDTO)obj);
    }

    public override int GetHashCode()
    {
        return VerificationKey.GetHashCode();
    }
}