using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.OutcomeDecider
{
    public interface IOutcomeDeciderModel : IBaseModel
    {
        public int PlayerHandChoiceIndex { get; }
        public int OpponentHandChoiceIndex { get; }
        public string Outcome { get; }
        public bool WinnerHasBeenDecided { get; }

    }
}