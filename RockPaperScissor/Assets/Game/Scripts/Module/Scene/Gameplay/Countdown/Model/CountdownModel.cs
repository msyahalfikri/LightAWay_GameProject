using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;

namespace RPS.Module.Countdown
{
    public class CountdownModel : BaseModel, ICountdownModel
    {
        public float CountdownTime { get; private set; }
        public float CurrentTime { get; private set; } = 5f;
        public float CurrentTimeInSeconds { get; private set; }
        public bool CountdownHasFinished { get; private set; } = false;
        public bool PlayerHasDecided { get; private set; } = false;
        public UnityAction CountdownFinished;
        public void StartCountingDown()
        {
            if (CountdownHasFinished == false && PlayerHasDecided == true)
            {
                CurrentTime -= Time.deltaTime;
                CurrentTimeInSeconds = Mathf.FloorToInt(CurrentTime % 60);

                if (CurrentTime <= 0)
                {
                    CurrentTime = 0;
                    CurrentTimeInSeconds = 0;
                    SetCountdownAsFinished();
                }
            }
            SetDataAsDirty();
        }

        public void SetCountdownAsFinished()
        {
            CountdownHasFinished = true;
            CountdownFinished?.Invoke();
            SetDataAsDirty();
        }

        public void SetPlayerHasDecided(bool playerHasDecided)
        {
            PlayerHasDecided = playerHasDecided;
        }
        public void ResetCountdown()
        {
            PlayerHasDecided = false;
            CountdownHasFinished = false;
            CurrentTime = 5f;
            SetDataAsDirty();
        }
    }
}
