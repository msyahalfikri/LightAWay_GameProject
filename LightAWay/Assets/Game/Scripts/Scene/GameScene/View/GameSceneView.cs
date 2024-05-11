using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using LightAWay.Boot;
using LightAWay.Utility;
using UnityEngine;
using LightAWay.Module.Opponent;
using LightAWay.Module.Player;
using LightAWay.Module.Soundfx;
using LightAWay.Module.Countdown;
using LightAWay.Module.OutcomeDecider;

namespace LightAWay.Scene.GameScene
{
	public class GameSceneView : BaseSceneView
	{
		[SerializeField]
		public OpponentView OpponentView;
		[SerializeField]
		public PlayerInputView PlayerInputView;
		[SerializeField]
		public CountdownView CountdownView;
		[SerializeField]
		public OutcomeDeciderView OutcomeDeciderView;
	}
}
