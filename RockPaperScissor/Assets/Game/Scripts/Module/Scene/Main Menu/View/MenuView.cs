using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace RPS.Module.MainMenu
{
    public class MenuView : ObjectView<IMainMenuModel>
    {
        [SerializeField]
        private Button _playButton;

        [SerializeField]
        private Button _exitButton;
        [SerializeField]
        private Button _creditButton;
        [SerializeField]
        private Button _backButton;
        [SerializeField]
        private GameObject _creditPanel;

        public void Callbacks(UnityAction onPlay, UnityAction onExit, UnityAction onShowCreditPanel)
        {
            _playButton.onClick.RemoveAllListeners();
            _exitButton.onClick.RemoveAllListeners();
            _creditButton.onClick.RemoveAllListeners();
            _backButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onPlay);
            _exitButton.onClick.AddListener(onExit);
            _creditButton.onClick.AddListener(onShowCreditPanel);
            _backButton.onClick.AddListener(onShowCreditPanel);

        }
        protected override void InitRenderModel(IMainMenuModel model)
        {
            _creditPanel.SetActive(_model.CreditPanelIsActive);
        }

        protected override void UpdateRenderModel(IMainMenuModel model)
        {
            _creditPanel.SetActive(_model.CreditPanelIsActive);
        }
    }
}