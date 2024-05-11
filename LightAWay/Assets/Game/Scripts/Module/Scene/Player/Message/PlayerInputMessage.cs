using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Player
{
    public struct UpdatePlayerInputMessage
    {
        public int HandIndex { get; private set; }
        public bool PlayerHasDecided { get; private set; }
        public UpdatePlayerInputMessage(int handIndex, bool playerHasDecided)
        {
            HandIndex = handIndex;
            PlayerHasDecided = playerHasDecided;
        }
    }
}

