namespace RPS.Module.Countdown
{
    public struct UpdateCountdownMessage
    {
        public float CurrentTime { get; private set; }
        public UpdateCountdownMessage(float currentTime)
        {
            CurrentTime = currentTime;
        }
    }
}
