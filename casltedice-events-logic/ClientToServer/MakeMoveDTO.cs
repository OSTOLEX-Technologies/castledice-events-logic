using castledice_game_data_logic.MovesData;

namespace casltedice_events_logic.ClientToServer;

[Serializable]
public class MakeMoveDTO : ClientToServerDTO
{
    public MoveData MoveData { get; set; }
    
    public MakeMoveDTO(MoveData moveData, string verificationKey) : base(verificationKey)
    {
        MoveData = moveData;
    }
}