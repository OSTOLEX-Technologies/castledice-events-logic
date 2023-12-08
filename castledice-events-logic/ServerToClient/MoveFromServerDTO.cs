using castledice_game_data_logic.Moves;

namespace castledice_events_logic.ServerToClient;

[Serializable]
public sealed class MoveFromServerDTO
{
    public MoveData MoveData { get; }

    public MoveFromServerDTO(MoveData moveData)
    {
        MoveData = moveData;
    }

    private bool Equals(MoveFromServerDTO other)
    {
        return MoveData.Equals(other.MoveData);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is MoveFromServerDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return MoveData.GetHashCode();
    }
}