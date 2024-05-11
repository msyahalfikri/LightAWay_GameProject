using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Countdown
{
    public struct UpdateCountdownMessage
    {
        public float CurrentTime { get; private set; }
        public UpdateCountdownMessage(float currentTime)
        {
            CurrentTime = currentTime;
        }
    }
}
