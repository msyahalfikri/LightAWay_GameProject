using System.Collections;
using System.Collections.Generic;
using LightAWay.Module.Player;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace LightAWay.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {

        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]{

            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[] {
                new PlayerMovementController(),
            };
        }

        protected override IEnumerator StartInit()
        {
            Application.targetFrameRate = 60;

            yield return null;
        }
    }

}