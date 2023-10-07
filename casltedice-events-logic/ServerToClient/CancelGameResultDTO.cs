namespace casltedice_events_logic.ServerToClient;

public class CancelGameResultDTO
{
    public bool IsCanceled { get; set; }

    public CancelGameResultDTO(bool isCanceled)
    {
        IsCanceled = isCanceled;
    }
}