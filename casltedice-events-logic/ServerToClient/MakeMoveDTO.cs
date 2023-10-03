using castledice_game_data_logic.Moves;

namespace casltedice_events_logic.ServerToClient;

[Serializable]
public class MakeMoveDTO
{
    public MoveData MoveData { get; set; }
}