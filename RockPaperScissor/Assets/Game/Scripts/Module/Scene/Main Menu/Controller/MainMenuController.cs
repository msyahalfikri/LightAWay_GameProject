using Agate.MVC.Base;
using RPS.Boot;
using UnityEngine;

namespace RPS.Module.MainMenu
{
    public class MainMenuController : ObjectController<MainMenuController, MainMenuModel, IMainMenuModel, MenuView>
    {
        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.Callbacks(OnPlay, OnExit, OnShowCreditPanel);
        }

        public void OnPlay()
        {
            SceneLoader.Instance.LoadScene("GameScene");
        }
        public void OnShowCreditPanel()
        {
            _model.ActiveOrDeactiveCreditPanel();
        }

        public void OnExit()
        {
            Application.Quit();
        }
    }
}


