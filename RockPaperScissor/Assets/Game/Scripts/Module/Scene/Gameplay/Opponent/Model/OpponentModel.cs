using Agate.MVC.Base;
using UnityEngine;

namespace RPS.Module.Opponent
{
    public class OpponentModel : BaseModel, IOpponentModel
    {
        public int OpponentHandIndex { get; private set; } = 3;
        public bool OpponentHasDecided { get; private set; } = false;
        public int Outcome { get; private set; }

        public void SetHand(int handIndex)
        {
            OpponentHandIndex = handIndex;
            SetDataAsDirty();
        }
        public void OutcomeDecided(int outcome)
        {
            Outcome = outcome;
            SetDataAsDirty();
        }

        public void DecideOpponentHand()
        {
            if (OpponentHasDecided == false)
            {
                System.Random rnd = new System.Random();
                OpponentHandIndex = rnd.Next(0, 3);
                OpponentHasDecided = true;
                SetDataAsDirty();
            }
        }
        public void ResetChoice()
        {
            OpponentHandIndex = 3;
            Outcome = 3;
            OpponentHasDecided = false;
            SetDataAsDirty();
        }
        public string SetStringBasedOnHandIndex()
        {
            string OpponentHandString;
            switch (OpponentHandIndex)
            {
                case 0:
                    OpponentHandString = "Rock";
                    break;
                case 1:
                    OpponentHandString = "Paper";
                    break;
                case 2:
                    OpponentHandString = "Scissor";
                    break;
                default:
                    OpponentHandString = "Please Wait!";
                    break;
            }
            return OpponentHandString;
        }
    }
}
