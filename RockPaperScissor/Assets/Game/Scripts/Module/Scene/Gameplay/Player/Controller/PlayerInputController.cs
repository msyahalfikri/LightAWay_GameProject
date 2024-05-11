using Agate.MVC.Base;
using UnityEngine;

namespace RPS.Module.Player
{
    public class PlayerInputController : ObjectController<PlayerInputController, PlayerInputModel, IPlayerInputModel, PlayerInputView>
    {
        private void OnPlayerChooseRock()
        {
            _model.ChooseRock();
            Publish<UpdatePlayerInputMessage>(new UpdatePlayerInputMessage(_model.PlayerHandChoiceIndex, _model.PlayerHasDecided));
        }
        private void OnPlayerChoosePaper()
        {
            _model.ChoosePaper();
            Publish<UpdatePlayerInputMessage>(new UpdatePlayerInputMessage(_model.PlayerHandChoiceIndex, _model.PlayerHasDecided));
        }
        private void OnPlayerChooseScissor()
        {
            _model.ChooseScissor();
            Publish<UpdatePlayerInputMessage>(new UpdatePlayerInputMessage(_model.PlayerHandChoiceIndex, _model.PlayerHasDecided));
        }
        public void OnGameReset()
        {
            Debug.Log("Player Reset");
            _model.ResetChoice();
        }
        public override void SetView(PlayerInputView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnPlayerChooseRock, OnPlayerChoosePaper, OnPlayerChooseScissor);
        }
    }
}
