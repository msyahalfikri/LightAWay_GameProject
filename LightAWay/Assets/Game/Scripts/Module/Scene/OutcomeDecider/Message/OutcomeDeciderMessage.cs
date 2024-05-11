using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.OutcomeDecider
{
    public struct UpdateOutcomeDeciderMessage
    {
        public bool WinnerHasBeenDecided { get; private set; }
        public UpdateOutcomeDeciderMessage(bool winnerHasBeenDecided)
        {
            WinnerHasBeenDecided = winnerHasBeenDecided;
        }
    }
}
