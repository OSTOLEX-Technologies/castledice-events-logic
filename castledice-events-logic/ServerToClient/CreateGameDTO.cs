using castledice_game_data_logic;

namespace castledice_events_logic.ServerToClient;

[Serializable]
public sealed class CreateGameDTO
{
    public GameStartData GameStartData { get; }

    public CreateGameDTO(GameStartData gameStartData)
    {
        GameStartData = gameStartData;
    }

    private bool Equals(CreateGameDTO other)
    {
        return GameStartData.Equals(other.GameStartData);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is CreateGameDTO other && Equals(other);
    }

    public override int GetHashCode()
    {
        return GameStartData.GetHashCode();
    }
}