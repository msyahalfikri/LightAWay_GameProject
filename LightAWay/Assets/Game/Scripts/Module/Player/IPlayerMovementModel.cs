using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Player
{
    public interface IPlayerMovementModel : IBaseModel
    {
        public float Speed { get; }
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }
    }
}
