using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Opponent
{
    public struct UpdateOpponentMessage
    {
        public int HandIndex { get; private set; }
        public UpdateOpponentMessage(int handIndex)
        {
            HandIndex = handIndex;
        }
    }
}

