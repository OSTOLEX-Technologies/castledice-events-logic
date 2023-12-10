using castledice_game_data_logic.Errors;

namespace casltedice_events_logic.ServerToClient;

[Serializable]
public sealed class ServerErrorDTO
{
    public ErrorData ErrorData { get; }

    public ServerErrorDTO(ErrorData errorData)
    {
        ErrorData = errorData;
    }

    private bool Equals(ServerErrorDTO other)
    {
        return ErrorData.Equals(other.ErrorData);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is ServerErrorDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return ErrorData.GetHashCode();
    }
}