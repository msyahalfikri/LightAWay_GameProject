using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Module.ClickGame
{
	public interface IClickGameModel : IBaseModel
	{
		public int Coin { get; }
	}
}