using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.Countdown
{
    public interface ICountdownModel : IBaseModel
    {
        public float CountdownTime { get; }
        public float CurrentTime { get; }
        public float CurrentTimeInSeconds { get; }
        public bool CountdownHasFinished { get; }
    }
}
