using castledice_game_data_logic.Moves;

namespace casltedice_events_logic.ServerToClient;

[Serializable]
public class MoveFromServerDTO
{
    public MoveData MoveData { get; set; }
}