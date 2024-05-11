using Agate.MVC.Base;

namespace RPS.Module.OutcomeDecider
{
    public interface IOutcomeDeciderModel : IBaseModel
    {
        public int PlayerHandChoiceIndex { get; }
        public int OpponentHandChoiceIndex { get; }
        public string Outcome { get; }
        public int OutcomeIndex { get; }
        public bool WinnerHasBeenDecided { get; }
        public bool PlayAgainButtonIsActive { get; }

    }
}