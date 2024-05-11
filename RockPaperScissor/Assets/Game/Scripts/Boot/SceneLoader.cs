using Agate.MVC.Base;
using RPS.Utility;

namespace RPS.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene => GameSceneUtil.SplashScreen;
    }
}
