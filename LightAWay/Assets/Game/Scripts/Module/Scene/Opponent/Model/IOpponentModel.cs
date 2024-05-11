using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.Opponent
{
    public interface IOpponentModel : IBaseModel
    {
        public int OpponentHandIndex { get; }
        public string SetStringBasedOnHandIndex();

        public bool OpponentHasDecided { get; }
    }
}
