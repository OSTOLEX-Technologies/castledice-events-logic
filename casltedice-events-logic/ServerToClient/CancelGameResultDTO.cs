namespace casltedice_events_logic.ServerToClient;

[Serializable]
public sealed class CancelGameResultDTO
{
    public bool IsCanceled { get; }
    public int PlayerId { get; }

    public CancelGameResultDTO(bool isCanceled, int playerId)
    {
        IsCanceled = isCanceled;
        PlayerId = playerId;
    }

    private bool Equals(CancelGameResultDTO other)
    {
        return IsCanceled == other.IsCanceled && PlayerId == other.PlayerId;
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is CancelGameResultDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(IsCanceled, PlayerId);
    }
}