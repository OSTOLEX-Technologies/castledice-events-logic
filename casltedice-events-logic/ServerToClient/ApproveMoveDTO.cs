namespace casltedice_events_logic.ServerToClient;

[Serializable]
public class ApproveMoveDTO
{
    public bool IsMoveValid { get; set; }

    public ApproveMoveDTO(bool isMoveValid)
    {
        IsMoveValid = isMoveValid;
    }
}