using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


namespace RPS.Module.Player
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
        [SerializeField]
        private SpriteRenderer _PlayerHandSprite;
        [SerializeField]
        private Sprite[] _HandSprites;

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
            _PlayerHandSprite.sprite = _HandSprites[_model.PlayerHandChoiceIndex];
        }

        protected override void UpdateRenderModel(IPlayerInputModel model)
        {
            _Text.text = model.SetStringBasedOnHandIndex();
            _PlayerHandSprite.sprite = _HandSprites[_model.PlayerHandChoiceIndex];
        }
    }
}

