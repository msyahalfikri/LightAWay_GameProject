using Agate.MVC.Base;
using Agate.MVC.Core;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LightAWay.Module.Countdown
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
            // _view.SetCountdownFinishedCallbacks(OnCountdownFinished);
            if (_model.CountdownHasFinished)
            {
                Publish<UpdateCountdownMessage>(new UpdateCountdownMessage(_model.CurrentTime));
            }
        }
        public void OnWinnerHaveBeenDecidedInvoked()
        {
            _model.ResetCountdown();
            Debug.Log("Countdown Has been Reset");
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