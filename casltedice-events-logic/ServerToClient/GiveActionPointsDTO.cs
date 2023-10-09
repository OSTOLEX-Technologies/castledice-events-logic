namespace casltedice_events_logic.ServerToClient;

[Serializable]
public sealed class GiveActionPointsDTO
{
    public int PlayerId { get; }
    public int Amount { get; }

    public GiveActionPointsDTO(int playerId, int amount)
    {
        PlayerId = playerId;
        Amount = amount;
    }

    private bool Equals(GiveActionPointsDTO other)
    {
        return PlayerId == other.PlayerId && Amount == other.Amount;
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is GiveActionPointsDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(PlayerId, Amount);
    }
}