using Exiled.API.Features;
using System;

namespace ScpList
{
    public class ScpList : Plugin<Config>
    {
        public static ScpList Instance { get; private set; }

        public override string Name => "ScpList";
        public override string Author => "thecroshel";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 11);

        public override void OnEnabled()
        {
            Instance = this;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;

            base.OnDisabled();
        }
    }
}
