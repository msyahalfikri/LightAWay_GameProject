using Agate.MVC.Base;

namespace RPS.Module.Countdown
{
    public interface ICountdownModel : IBaseModel
    {
        public float CountdownTime { get; }
        public float CurrentTime { get; }
        public float CurrentTimeInSeconds { get; }
        public bool CountdownHasFinished { get; }
        public bool PlayerHasDecided { get; }
    }
}
