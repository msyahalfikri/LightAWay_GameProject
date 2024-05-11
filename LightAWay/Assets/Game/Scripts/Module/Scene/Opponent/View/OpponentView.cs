using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;


namespace LightAWay.Module.Opponent
{
    public class OpponentView : ObjectView<IOpponentModel>
    {
        [SerializeField]
        private TextMeshProUGUI _handText;
        // private UnityAction _onOpponentChose;

        // public void SetCallbacks(UnityAction OnOpponentChose)
        // {
        //     _onOpponentChose = OnOpponentChose;
        // }

        protected override void InitRenderModel(IOpponentModel model)
        {
            _handText.text = model.SetStringBasedOnHandIndex();
        }

        protected override void UpdateRenderModel(IOpponentModel model)
        {
            _handText.text = model.SetStringBasedOnHandIndex();
        }
    }
}

