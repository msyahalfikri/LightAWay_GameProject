using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using LightAWay.Boot;
using LightAWay.Module.Player;
using LightAWay.Utility;
using UnityEngine;

namespace LightAWay.Scene.GameScene
{
	public class GameSceneView : BaseSceneView
	{
		[SerializeField]
		public PlayerMovementView PlayerMovementView;
	}
}
