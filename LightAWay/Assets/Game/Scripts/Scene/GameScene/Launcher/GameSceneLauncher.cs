using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using LightAWay.Boot;
using LightAWay.Module.Player;
using LightAWay.Utility;

namespace LightAWay.Scene.GameScene
{

	public class GameSceneLauncher : SceneLauncher<GameSceneLauncher, GameSceneView>
	{
		private PlayerMovementController _playerMovement;
		public override string SceneName { get { return GameSceneUtil.GameScene; } }
		protected override IConnector[] GetSceneConnectors()
		{
			return null;
		}

		protected override IController[] GetSceneDependencies()
		{
			return new IController[]{
				new PlayerMovementController()
			};
		}

		protected override IEnumerator InitSceneObject()
		{
			_playerMovement.SetView(_view.PlayerMovementView);
			yield return null;
		}

		protected override IEnumerator LaunchScene()
		{
			yield return null;
		}
	}
}
