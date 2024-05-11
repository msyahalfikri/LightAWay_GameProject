using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.Player
{
    public interface IPlayerInputModel : IBaseModel
    {
        public int PlayerHandChoiceIndex { get; }
        public bool PlayerHasDecided { get; }
        public string SetStringBasedOnHandIndex();

    }
}

