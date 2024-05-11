using Agate.MVC.Base;
using LightAWay.Module.Player;

namespace LightAWay.Module.Soundfx
{
    public class SoundfxConnector : BaseConnector
    {
        private SoundfxController _soundfx;

        protected override void Connect()
        {
            Subscribe<UpdatePlayerInputMessage>(OnUpdatePlayerInput);
        }

        protected override void Disconnect()
        {

            Unsubscribe<UpdatePlayerInputMessage>(OnUpdatePlayerInput);
        }
        public void OnUpdatePlayerInput(UpdatePlayerInputMessage message)
        {
            _soundfx.OnUpdatePlayerInput();
        }
    }
}