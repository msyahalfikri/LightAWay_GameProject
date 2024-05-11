using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using RPS.Boot;
using RPS.Utility;
using RPS.Module.MainMenu;


namespace RPS.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName { get { return GameSceneUtil.MainMenu; } }

        private MainMenuController _mainMenu;
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
          {
                new MainMenuController()
          };
        }

        protected override IEnumerator InitSceneObject()
        {
            _mainMenu.SetView(_view.MenuView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
