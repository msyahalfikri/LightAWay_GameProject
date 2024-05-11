using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using LightAWay.Module.Player;


namespace LightAWay.Module.Player
{
    public class PlayerInputView : ObjectView<IPlayerInputModel>
    {
        [SerializeField]
        private Button _RockButton;
        [SerializeField]
        private Button _PaperButton;
        [SerializeField]
        private Button _ScissorButton;
        [SerializeField]
        private TextMeshProUGUI _Text;

        public void SetCallbacks(UnityAction OnPlayerChooseRock, UnityAction OnPlayerChoosePaper, UnityAction OnPlayerChooseScissor)
        {
            _RockButton.onClick.RemoveAllListeners();
            _PaperButton.onClick.RemoveAllListeners();
            _ScissorButton.onClick.RemoveAllListeners();
            _RockButton.onClick.AddListener(OnPlayerChooseRock);
            _PaperButton.onClick.AddListener(OnPlayerChoosePaper);
            _ScissorButton.onClick.AddListener(OnPlayerChooseScissor);

        }

        protected override void InitRenderModel(IPlayerInputModel model)
        {
            _Text.text = model.SetStringBasedOnHandIndex();
        }

        protected override void UpdateRenderModel(IPlayerInputModel model)
        {
            _Text.text = model.SetStringBasedOnHandIndex();
        }
    }
}

