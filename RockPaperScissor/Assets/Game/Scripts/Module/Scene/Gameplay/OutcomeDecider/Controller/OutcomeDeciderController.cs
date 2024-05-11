using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
using RPS.Boot;


namespace RPS.Module.OutcomeDecider
{
    public class OutcomeDeciderController : ObjectController<OutcomeDeciderController, OutcomeDeciderModel, IOutcomeDeciderModel, OutcomeDeciderView>
    {
        public void OnPlayerInputInvoked(int PlayerHandChoiceIndex)
        {
            _model.GetOpponentHandChoiceIndex(PlayerHandChoiceIndex);
        }
        public void OnOpponentInputInvoked(int OpponentHandChoiceIndex)
        {
            _model.GetPlayerHandChoiceIndex(OpponentHandChoiceIndex);
            _model.DecideOutcome();
            _model.ActivateDeactivatePlayAgainButton();
            Publish<UpdateOutcomeIndexMessage>(new UpdateOutcomeIndexMessage(_model.OutcomeIndex));
        }

        public void OnWinnerHaveBeenDecidedInvoked()
        {
            Publish<UpdateOutcomeDeciderMessage>(new UpdateOutcomeDeciderMessage(_model.WinnerHasBeenDecided));
        }

        public void OnResetDecision()
        {
            _model.ResetDecision();
        }

        public void OnMainMenuButtonClicked()
        {
            SceneLoader.Instance.LoadScene("MainMenu");
        }

        public override void SetView(OutcomeDeciderView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnWinnerHaveBeenDecidedInvoked, OnMainMenuButtonClicked, OnResetDecision);
        }
    }
}
