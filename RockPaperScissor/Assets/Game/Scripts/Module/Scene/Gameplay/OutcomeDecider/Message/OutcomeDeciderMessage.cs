namespace RPS.Module.OutcomeDecider
{
    public struct UpdateOutcomeDeciderMessage
    {
        public bool WinnerHasBeenDecided { get; private set; }
        public UpdateOutcomeDeciderMessage(bool winnerHasBeenDecided)
        {
            WinnerHasBeenDecided = winnerHasBeenDecided;
        }
    }

    public struct UpdateOutcomeIndexMessage
    {
        public int OutcomeIndex { get; private set; }
        public UpdateOutcomeIndexMessage(int outcomeIndex)
        {
            OutcomeIndex = outcomeIndex;
        }
    }
}
