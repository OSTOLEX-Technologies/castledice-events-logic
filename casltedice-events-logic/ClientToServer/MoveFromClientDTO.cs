using castledice_game_data_logic.Moves;

namespace casltedice_events_logic.ClientToServer;

[Serializable]
public sealed class MoveFromClientDTO : ClientToServerDTO
{
    public MoveData MoveData { get; }
    
    public MoveFromClientDTO(MoveData moveData, string verificationKey) : base(verificationKey)
    {
        MoveData = moveData;
    }

    private bool Equals(MoveFromClientDTO other)
    {
        return base.Equals(other) && MoveData.Equals(other.MoveData);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is MoveFromClientDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(base.GetHashCode(), MoveData);
    }
}