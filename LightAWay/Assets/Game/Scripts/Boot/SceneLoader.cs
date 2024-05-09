using Agate.MVC.Base;
using LightAWay.Utility;

namespace LightAWay.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene => GameSceneUtil.SplashScreen;
    }
}
