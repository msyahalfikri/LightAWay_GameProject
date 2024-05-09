using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using LightAWay.Boot;
using LightAWay.Utility;


namespace LightAWay.Scene.MainMenu
{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName { get { return GameSceneUtil.MainMenu; } }
        
        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
