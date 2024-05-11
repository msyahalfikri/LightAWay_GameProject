using Agate.MVC.Base;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.Player
{
    public class PlayerInputModel : BaseModel, IPlayerInputModel
    {
        public int PlayerHandChoiceIndex { get; private set; } = 3;
        public bool PlayerHasDecided { get; private set; } = false;

        // public void ResetHand(int playerHandChoiceIndex)
        // {
        //     PlayerHandChoiceIndex = playerHandChoiceIndex;
        //     SetDataAsDirty();
        // }

        public void ChooseRock()
        {
            if (PlayerHasDecided == false)
            {
                PlayerHandChoiceIndex = 0;
                PlayerHasDecided = true;
                SetDataAsDirty();
            }

        }
        public void ChoosePaper()
        {
            if (PlayerHasDecided == false)
            {
                PlayerHandChoiceIndex = 1;
                PlayerHasDecided = true;
                SetDataAsDirty();
            }
        }
        public void ChooseScissor()
        {
            if (PlayerHasDecided == false)
            {
                PlayerHandChoiceIndex = 2;
                PlayerHasDecided = true;
                SetDataAsDirty();
            }
        }

        public void ResetChoice()
        {
            PlayerHandChoiceIndex = 3;
            PlayerHasDecided = false;
            SetDataAsDirty();
        }

        public string SetStringBasedOnHandIndex()
        {
            string PlayerHandChoiceString;
            switch (PlayerHandChoiceIndex)
            {
                case 0:
                    PlayerHandChoiceString = "Rock";
                    break;
                case 1:
                    PlayerHandChoiceString = "Paper";
                    break;
                case 2:
                    PlayerHandChoiceString = "Scissor";
                    break;
                default:
                    PlayerHandChoiceString = "Choose!";
                    break;
            }
            return PlayerHandChoiceString;
        }
    }
}