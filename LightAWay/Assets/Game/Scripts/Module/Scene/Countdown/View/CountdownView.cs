using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


namespace LightAWay.Module.Countdown
{
    public class CountdownView : ObjectView<ICountdownModel>
    {
        [SerializeField]
        private TextMeshProUGUI _CountdownText;
        [SerializeField]
        private UnityAction _onPlayerChose;
        // private UnityAction _onCountdownFinished;

        public void SetCallbacks(UnityAction OnCountdownStart)
        {
            _onPlayerChose = OnCountdownStart;
        }
        // public void SetCountdownFinishedCallbacks(UnityAction OnCountdownFinished)
        // {
        //     _onCountdownFinished = OnCountdownFinished;
        // }

        protected override void InitRenderModel(ICountdownModel model)
        {
            _CountdownText.text = model.CurrentTimeInSeconds.ToString();
        }

        protected override void UpdateRenderModel(ICountdownModel model)
        {
            _CountdownText.text = model.CurrentTimeInSeconds.ToString();
        }
        private void Update()
        {
            _onPlayerChose?.Invoke();
        }
    }
}

