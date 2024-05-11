using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using LightAWay.Boot;
using LightAWay.Utility;
using LightAWay.Module.ClickGame;
using LightAWay.Module.Opponent;
using LightAWay.Module.Player;
using LightAWay.Module.Soundfx;
using LightAWay.Module.Countdown;
using LightAWay.Module.OutcomeDecider;
using LightAWay.Module.Connector;

namespace LightAWay.Scene.GameScene
{

	public class GameSceneLauncher : SceneLauncher<GameSceneLauncher, GameSceneView>
	{
		private OpponentController _opponent;
		private PlayerInputController _player;
		private CountdownController _countdown;
		private OutcomeDeciderController _outcomeDecider;
		public override string SceneName { get { return GameSceneUtil.GameScene; } }
		protected override IConnector[] GetSceneConnectors()
		{
			return new IConnector[]{
				new SoundfxConnector(),
				new GameplayConnector(),
			};
		}

		protected override IController[] GetSceneDependencies()
		{
			return new IController[]{
				new OpponentController(),
				new PlayerInputController(),
				new SoundfxController(),
				new CountdownController(),
				new OutcomeDeciderController()
			};
		}

		protected override IEnumerator InitSceneObject()
		{
			_opponent.SetView(_view.OpponentView);
			_player.SetView(_view.PlayerInputView);
			_countdown.SetView(_view.CountdownView);
			_outcomeDecider.SetView(_view.OutcomeDeciderView);
			yield return null;
		}

		protected override IEnumerator LaunchScene()
		{
			yield return null;
		}
	}
}
