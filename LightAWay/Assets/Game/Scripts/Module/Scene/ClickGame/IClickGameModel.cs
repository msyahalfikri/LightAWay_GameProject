using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace LightAWay.Module.ClickGame
{
	public interface IClickGameModel : IBaseModel
	{
		public int Coin { get; }
	}
}