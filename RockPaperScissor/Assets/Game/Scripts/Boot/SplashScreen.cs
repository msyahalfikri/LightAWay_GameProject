using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace RPS.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        [SerializeField]
        private Transform _splashText;
        [SerializeField]
        private Transform _loadingText;

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }
    }
}