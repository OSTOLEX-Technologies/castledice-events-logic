namespace casltedice_events_logic.ServerToClient;

[Serializable]
public sealed class ApproveMoveDTO
{
    public bool IsMoveValid { get; }

    public ApproveMoveDTO(bool isMoveValid)
    {
        IsMoveValid = isMoveValid;
    }

    private bool Equals(ApproveMoveDTO other)
    {
        return IsMoveValid == other.IsMoveValid;
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is ApproveMoveDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return IsMoveValid.GetHashCode();
    }
}