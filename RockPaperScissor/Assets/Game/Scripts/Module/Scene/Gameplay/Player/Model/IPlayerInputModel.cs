using Agate.MVC.Base;

namespace RPS.Module.Player
{
    public interface IPlayerInputModel : IBaseModel
    {
        public int PlayerHandChoiceIndex { get; }
        public bool PlayerHasDecided { get; }
        public string SetStringBasedOnHandIndex();

    }
}

