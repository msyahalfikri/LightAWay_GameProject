using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using LightAWay.Module.Player;


namespace LightAWay.Module.OutcomeDecider
{
    public class OutcomeDeciderView : ObjectView<IOutcomeDeciderModel>
    {
        [SerializeField]
        private TextMeshProUGUI _Text;

        [SerializeField]
        private Button _ResetButton;

        public void SetCallbacks(UnityAction OnWinnerHaveBeenDecided)
        {
            _ResetButton.onClick.RemoveAllListeners();
            _ResetButton.onClick.AddListener(OnWinnerHaveBeenDecided);
        }

        protected override void InitRenderModel(IOutcomeDeciderModel model)
        {
            _Text.text = model.Outcome;
        }

        protected override void UpdateRenderModel(IOutcomeDeciderModel model)
        {
            _Text.text = model.Outcome;
        }
    }
}

