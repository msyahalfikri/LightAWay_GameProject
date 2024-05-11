using Agate.MVC.Base;
namespace RPS.Module.Opponent
{
    public interface IOpponentModel : IBaseModel
    {
        public int OpponentHandIndex { get; }
        public string SetStringBasedOnHandIndex();
        public bool OpponentHasDecided { get; }
        public int Outcome { get; }
    }
}
