using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Opponent
{
    public class OpponentController : ObjectController<OpponentController, OpponentModel, IOpponentModel, OpponentView>
    {
        // private void OnOpponentMakeChoice()
        // {
        //     _model.DecideOpponentHand();
        // }
        public void OnGameReset()
        {
            Debug.Log("Opponent Reset");
            _model.ResetChoice();
        }
        public override void SetView(OpponentView view)
        {
            base.SetView(view);
            // view.SetCallbacks(OnOpponentMakeChoice);
        }

        public void OnCountdownFinishedInvoked()
        {
            _model.DecideOpponentHand();
            Publish<UpdateOpponentMessage>(new UpdateOpponentMessage(_model.OpponentHandIndex));
        }
    }
}
