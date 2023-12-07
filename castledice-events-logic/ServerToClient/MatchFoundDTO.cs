namespace castledice_events_logic.ServerToClient;

public sealed class MatchFoundDTO
{
    public List<int> PlayerIds { get; }

    public MatchFoundDTO(List<int> playerIds)
    {
        PlayerIds = playerIds;
    }

    private bool Equals(MatchFoundDTO other)
    {
        return PlayerIds.SequenceEqual(other.PlayerIds);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is MatchFoundDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return PlayerIds.GetHashCode();
    }
}