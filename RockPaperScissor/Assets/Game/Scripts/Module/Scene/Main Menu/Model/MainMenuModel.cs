using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;


namespace RPS.Module.MainMenu
{
    public class MainMenuModel : BaseModel, IMainMenuModel
    {
        public bool CreditPanelIsActive { get; private set; } = false;

        public void ActiveOrDeactiveCreditPanel()
        {
            CreditPanelIsActive = !CreditPanelIsActive;
            SetDataAsDirty();
        }

    }
}