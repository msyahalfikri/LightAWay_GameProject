using Agate.MVC.Base;
using LightAWay.Boot;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ExampleGame.Module.ClickGame{
		public class ClickGameController : ObjectController<ClickGameController, ClickGameModel, IClickGameModel, ClickGameView>
		{
		    private void OnClickEarnCoin()
            {
                _model.AddCoin();
            }

            private void OnClickSpendCoin()
            {
                _model.SubstractCoin();
            }

            private void OnClickBack()
            {
                SceneLoader.Instance.LoadScene("MainMenu");
                
            }

            public override void SetView(ClickGameView view)
            {
                base.SetView(view);
                view.SetCallbacks(OnClickEarnCoin, OnClickSpendCoin, OnClickBack);
            }
		}
}