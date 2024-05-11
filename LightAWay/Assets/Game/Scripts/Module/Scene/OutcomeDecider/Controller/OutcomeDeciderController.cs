using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.OutcomeDecider
{
    public class OutcomeDeciderController : ObjectController<OutcomeDeciderController, OutcomeDeciderModel, IOutcomeDeciderModel, OutcomeDeciderView>
    {
        public void OnPlayerInputInvoked(int PlayerHandChoiceIndex)
        {
            _model.GetOpponentHandChoiceIndex(PlayerHandChoiceIndex);
            Debug.Log("Player Hand: " + _model.PlayerHandChoiceIndex);
        }
        public void OnOpponentInputInvoked(int OpponentHandChoiceIndex)
        {
            _model.GetPlayerHandChoiceIndex(OpponentHandChoiceIndex);
            Debug.Log("Opponent Hand: " + _model.OpponentHandChoiceIndex);
            _model.DecideOutcome();
        }

        public void OnWinnerHaveBeenDecidedInvoked()
        {
            Publish<UpdateOutcomeDeciderMessage>(new UpdateOutcomeDeciderMessage(_model.WinnerHasBeenDecided));
        }

        public override void SetView(OutcomeDeciderView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnWinnerHaveBeenDecidedInvoked);
        }
    }
}
