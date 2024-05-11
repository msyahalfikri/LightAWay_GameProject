using Agate.MVC.Base;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace RPS.Module.Opponent
{
    public class OpponentView : ObjectView<IOpponentModel>
    {
        [SerializeField]
        private TextMeshProUGUI _handText;
        [SerializeField]
        private Sprite[] _opponentExpressions;
        [SerializeField]
        private SpriteRenderer _opponentSpriteUI;
        [SerializeField]
        private Sprite[] _handSprites;
        [SerializeField]
        private SpriteRenderer _opponentHandSprite;
        protected override void InitRenderModel(IOpponentModel model)
        {
            _handText.text = model.SetStringBasedOnHandIndex();
            _opponentSpriteUI.sprite = _opponentExpressions[model.Outcome];
            _opponentHandSprite.sprite = _handSprites[_model.OpponentHandIndex];
        }

        protected override void UpdateRenderModel(IOpponentModel model)
        {
            _handText.text = model.SetStringBasedOnHandIndex();
            _opponentSpriteUI.sprite = _opponentExpressions[model.Outcome];
            _opponentHandSprite.sprite = _handSprites[_model.OpponentHandIndex];
        }
    }
}

