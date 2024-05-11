using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using RPS.Boot;
using RPS.Utility;
using UnityEngine;
using RPS.Module.Opponent;
using RPS.Module.Player;
using RPS.Module.Countdown;
using RPS.Module.OutcomeDecider;

namespace RPS.Scene.GameScene
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
