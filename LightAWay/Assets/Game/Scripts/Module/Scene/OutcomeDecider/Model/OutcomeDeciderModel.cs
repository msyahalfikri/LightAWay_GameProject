using Agate.MVC.Base;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace LightAWay.Module.OutcomeDecider
{
    public class OutcomeDeciderModel : BaseModel, IOutcomeDeciderModel
    {
        public int PlayerHandChoiceIndex { get; private set; }
        public int OpponentHandChoiceIndex { get; private set; }
        public string Outcome { get; private set; } = "Make your choice!";
        public bool WinnerHasBeenDecided { get; private set; } = false;

        public void DecideOutcome()
        {
            if (PlayerHandChoiceIndex == OpponentHandChoiceIndex)
            {
                Outcome = "Draw!";
            }
            else if (PlayerHandChoiceIndex == 1 && OpponentHandChoiceIndex == 0 || PlayerHandChoiceIndex == 2 && OpponentHandChoiceIndex == 1 || PlayerHandChoiceIndex == 0 && OpponentHandChoiceIndex == 2)
            {
                Outcome = "Opponent Win!";
            }
            else
            {
                Outcome = "Player Win!";
            }
            WinnerHasBeenDecided = true;
            Debug.Log(Outcome);
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