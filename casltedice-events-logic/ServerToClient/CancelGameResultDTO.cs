namespace casltedice_events_logic.ServerToClient;

[Serializable]
public sealed class CancelGameResultDTO
{
    public bool IsCanceled { get; }

    public CancelGameResultDTO(bool isCanceled)
    {
        IsCanceled = isCanceled;
    }

    private bool Equals(CancelGameResultDTO other)
    {
        return IsCanceled == other.IsCanceled;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((CancelGameResultDTO)obj);
    }

    public override int GetHashCode()
    {
        return IsCanceled.GetHashCode();
    }
}