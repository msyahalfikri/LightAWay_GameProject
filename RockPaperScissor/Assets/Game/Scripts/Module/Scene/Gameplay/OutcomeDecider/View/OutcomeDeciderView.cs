using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace RPS.Module.OutcomeDecider
{
    public class OutcomeDeciderView : ObjectView<IOutcomeDeciderModel>
    {
        [SerializeField]
        private TextMeshProUGUI _Text;

        [SerializeField]
        private Button _PlayAgainButton;

        [SerializeField]
        private Button _MainMenuButton;

        public void SetCallbacks(UnityAction OnWinnerHaveBeenDecided, UnityAction OnMainMenuButtonClicked, UnityAction OnResetDecision)
        {
            _PlayAgainButton.onClick.RemoveAllListeners();
            _PlayAgainButton.onClick.AddListener(OnWinnerHaveBeenDecided);
            _PlayAgainButton.onClick.AddListener(OnResetDecision);
            _MainMenuButton.onClick.RemoveAllListeners();
            _MainMenuButton.onClick.AddListener(OnMainMenuButtonClicked);
        }

        protected override void InitRenderModel(IOutcomeDeciderModel model)
        {
            _Text.text = model.Outcome;
            _PlayAgainButton.gameObject.SetActive(_model.PlayAgainButtonIsActive);
        }

        protected override void UpdateRenderModel(IOutcomeDeciderModel model)
        {
            _Text.text = model.Outcome;
            _PlayAgainButton.gameObject.SetActive(_model.PlayAgainButtonIsActive);
        }
    }
}

