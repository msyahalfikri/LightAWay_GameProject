using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Player
{
    public class PlayerMovementController : ObjectController<PlayerMovementController, PlayerMovementModel, IPlayerMovementModel, PlayerMovementView>
    {
        void Update()
        {
            // Get input from the arrow keys or WASD keys
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Calculate the movement direction
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);

            // Pass the movement to the view
            _view.MovePlayer(movement);
        }

        private void OnClickBack()
        {
            SceneLoader.Instance.LoadScene("MainMenu");
        }
        public override void SetView(PlayerMovementView view)
        {
            base.SetView(view);
        }
    }
}
