using Agate.MVC.Base;

namespace RPS.Module.MainMenu
{
    public interface IMainMenuModel : IBaseModel
    {

        public bool CreditPanelIsActive { get; }
    }
}