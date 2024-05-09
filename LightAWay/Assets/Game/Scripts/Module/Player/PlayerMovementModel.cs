using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Player
{
    public class PlayerMovementModel : BaseModel, IPlayerMovementModel
    {
        public float Speed { get; set; } = 5f;
        public float SpeedX { get; set; }
        public float SpeedY { get; set; }
        public Rigidbody2D Rb { get; set; }
    }
}

