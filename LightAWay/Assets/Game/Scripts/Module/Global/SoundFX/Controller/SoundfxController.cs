using Agate.MVC.Base;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdatePlayerInput()
        {
            Debug.Log("Play Sound fx");
        }
    }
}

