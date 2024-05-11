using Agate.MVC.Base;
using UnityEngine;

namespace RPS.Module.Countdown
{
    public class CountdownController : ObjectController<CountdownController, CountdownModel, ICountdownModel, CountdownView>
    {
        public void OnCountdownStartInvoked()
        {
            _view.SetCallbacks(OnStartCountdown);
        }
        public void OnPlayerHasDecided(bool playerHasDecided)
        {
            _model.SetPlayerHasDecided(playerHasDecided);
        }
        public void OnCountdownFinishedInvoked()
        {
            if (_model.CountdownHasFinished)
            {
                Publish<UpdateCountdownMessage>(new UpdateCountdownMessage(_model.CurrentTime));
            }
        }
        public void OnWinnerHaveBeenDecidedInvoked()
        {
            _model.ResetCountdown();
        }

        public override void SetView(CountdownView view)
        {
            base.SetView(view);
            _model.CountdownFinished += OnCountdownFinishedInvoked;
        }
        private void OnStartCountdown()
        {
            _model.StartCountingDown();
        }

    }
}