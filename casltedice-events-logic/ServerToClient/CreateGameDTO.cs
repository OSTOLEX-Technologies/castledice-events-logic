using castledice_game_data_logic;

namespace casltedice_events_logic.ServerToClient;

[Serializable]
public class CreateGameDTO
{
    public GameConfigData GameConfigData { get; set; }
}