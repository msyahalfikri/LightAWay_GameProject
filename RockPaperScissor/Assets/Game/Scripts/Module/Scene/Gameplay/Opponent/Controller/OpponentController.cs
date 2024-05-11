using Agate.MVC.Base;
using UnityEngine;

namespace RPS.Module.Opponent
{
    public class OpponentController : ObjectController<OpponentController, OpponentModel, IOpponentModel, OpponentView>
    {
        public void OnGameReset()
        {
            _model.ResetChoice();
        }
        public void OnOutcomeDecided(int outcomeIndex)
        {
            _model.OutcomeDecided(outcomeIndex);
        }
        public override void SetView(OpponentView view)
        {
            base.SetView(view);
        }

        public void OnCountdownFinishedInvoked()
        {
            _model.DecideOpponentHand();
            Publish<UpdateOpponentMessage>(new UpdateOpponentMessage(_model.OpponentHandIndex));
        }
    }
}
