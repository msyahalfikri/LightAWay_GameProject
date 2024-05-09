using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace LightAWay.Module.Player
{
    public class PlayerMovementView : ObjectView<IPlayerMovementModel>
    {
        public void MovePlayer(Vector3 movement)
        {
            transform.Translate(movement * _model.Speed * Time.deltaTime);
        }

        protected override void InitRenderModel(IPlayerMovementModel model)
        {

        }

        protected override void UpdateRenderModel(IPlayerMovementModel model)
        {

        }
    }
}