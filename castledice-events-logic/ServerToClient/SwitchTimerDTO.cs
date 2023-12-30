namespace castledice_events_logic.ServerToClient;

[Serializable]
public sealed class SwitchTimerDTO
{
   public TimeSpan TimeLeft { get; }
   public int PlayerId { get; }
   /// <summary>
   /// If true, the timer should be started. If false, the timer should be stopped.
   /// </summary>
   public bool Switch { get; }

   public SwitchTimerDTO(TimeSpan timeLeft, int playerId, bool @switch)
   {
      TimeLeft = timeLeft;
      PlayerId = playerId;
      Switch = @switch;
   }

   private bool Equals(SwitchTimerDTO other)
   {
      return TimeLeft.Equals(other.TimeLeft) && PlayerId == other.PlayerId && Switch == other.Switch;
   }

   public override bool Equals(object? obj)
   {
      return ReferenceEquals(this, obj) || obj is SwitchTimerDTO other && Equals(other);
   }

   public override int GetHashCode()
   {
      return HashCode.Combine(TimeLeft, PlayerId, Switch);
   }
}