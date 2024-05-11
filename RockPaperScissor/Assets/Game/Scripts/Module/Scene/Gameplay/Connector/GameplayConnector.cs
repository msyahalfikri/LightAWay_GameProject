using Agate.MVC.Base;
using RPS.Module.Countdown;
using RPS.Module.Opponent;
using RPS.Module.Player;
using RPS.Module.OutcomeDecider;

namespace RPS.Module.Connector
{
    public class GameplayConnector : BaseConnector
    {
        private CountdownController _countdown;
        private OpponentController _opponent;
        private OutcomeDeciderController _outcomeDecider;
        private PlayerInputController _playerInput;

        protected override void Connect()
        {
            Subscribe<UpdatePlayerInputMessage>(OnUpdatePlayerInput);
            Subscribe<UpdateOpponentMessage>(OnUpdateOpponentInput);
            Subscribe<UpdateCountdownMessage>(OnCountdownFinished);
            Subscribe<UpdateOutcomeDeciderMessage>(OnWinnerHaveBeenDecided);
            Subscribe<UpdateOutcomeIndexMessage>(OnWinnerIndexHaveBeenDecided);
        }

        protected override void Disconnect()
        {

            Unsubscribe<UpdatePlayerInputMessage>(OnUpdatePlayerInput);
            Unsubscribe<UpdateOpponentMessage>(OnUpdateOpponentInput);
            Unsubscribe<UpdateCountdownMessage>(OnCountdownFinished);
            Unsubscribe<UpdateOutcomeDeciderMessage>(OnWinnerHaveBeenDecided);
            Unsubscribe<UpdateOutcomeIndexMessage>(OnWinnerIndexHaveBeenDecided);
        }
        public void OnUpdatePlayerInput(UpdatePlayerInputMessage message)
        {
            _countdown.OnPlayerHasDecided(message.PlayerHasDecided);
            _countdown.OnCountdownStartInvoked();
            _outcomeDecider.OnPlayerInputInvoked(message.HandIndex);
        }

        public void OnUpdateOpponentInput(UpdateOpponentMessage message)
        {
            _outcomeDecider.OnOpponentInputInvoked(message.HandIndex);
        }

        public void OnCountdownFinished(UpdateCountdownMessage message)
        {
            _opponent.OnCountdownFinishedInvoked();
        }
        public void OnWinnerHaveBeenDecided(UpdateOutcomeDeciderMessage message)
        {
            _countdown.OnWinnerHaveBeenDecidedInvoked();
            _opponent.OnGameReset();
            _playerInput.OnGameReset();
        }
        public void OnWinnerIndexHaveBeenDecided(UpdateOutcomeIndexMessage message)
        {
            _opponent.OnOutcomeDecided(message.OutcomeIndex);
        }
    }
}