using castledice_game_data_logic.Moves;

namespace casltedice_events_logic.ClientToServer;

[Serializable]
public class MoveFromClientDTO : ClientToServerDTO
{
    public MoveData MoveData { get; set; }
    
    public MoveFromClientDTO(MoveData moveData, string verificationKey) : base(verificationKey)
    {
        MoveData = moveData;
    }
}