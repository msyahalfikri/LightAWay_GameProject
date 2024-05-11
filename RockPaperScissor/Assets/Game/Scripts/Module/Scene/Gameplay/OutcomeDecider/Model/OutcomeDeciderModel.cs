using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace RPS.Module.OutcomeDecider
{
    public class OutcomeDeciderModel : BaseModel, IOutcomeDeciderModel
    {
        public int PlayerHandChoiceIndex { get; private set; }
        public int OpponentHandChoiceIndex { get; private set; }
        public string Outcome { get; private set; } = "Make your choice!";
        public int OutcomeIndex { get; private set; }
        public bool WinnerHasBeenDecided { get; private set; } = false;
        public bool PlayAgainButtonIsActive { get; private set; } = false;
        public void DecideOutcome()
        {

            if (PlayerHandChoiceIndex == OpponentHandChoiceIndex)
            {
                Outcome = "Draw!";
                OutcomeIndex = 0;
            }
            else if (PlayerHandChoiceIndex == 1 && OpponentHandChoiceIndex == 0 || PlayerHandChoiceIndex == 2 && OpponentHandChoiceIndex == 1 || PlayerHandChoiceIndex == 0 && OpponentHandChoiceIndex == 2)
            {
                Outcome = "Josh Win!";
                OutcomeIndex = 1;
            }
            else
            {
                Outcome = "Player Win!";
                OutcomeIndex = 2;
            }
            WinnerHasBeenDecided = true;
            SetDataAsDirty();
        }
        public void ResetDecision()
        {
            Outcome = "Make your choice!";
            OutcomeIndex = 3;
            ActivateDeactivatePlayAgainButton();
            SetDataAsDirty();
        }
        public void ActivateDeactivatePlayAgainButton()
        {
            PlayAgainButtonIsActive = !PlayAgainButtonIsActive;
            SetDataAsDirty();
        }

        public void GetPlayerHandChoiceIndex(int playerHandChoiceIndex)
        {
            PlayerHandChoiceIndex = playerHandChoiceIndex;
            SetDataAsDirty();
        }
        public void GetOpponentHandChoiceIndex(int opponentHandChoiceIndex)
        {
            OpponentHandChoiceIndex = opponentHandChoiceIndex;
            SetDataAsDirty();
        }

    }
}