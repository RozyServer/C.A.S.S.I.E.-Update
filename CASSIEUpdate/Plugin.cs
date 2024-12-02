using System;

using CASSIEUpdate.Handlers;

using Exiled.API.Features;

using P = Exiled.Events.Handlers.Player;
using S = Exiled.Events.Handlers.Server;
using Map = Exiled.Events.Handlers.Map;

namespace CASSIEUpdate
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "C.A.S.S.I.E. Update";
        public override string Prefix => "CASSIEUpdate";
        public override string Author => "Rozy";
        public override Version Version => new Version(1, 0, 3);
        public static Plugin Instance;
        private EventHandlers _eventHandlers;

        public override void OnEnabled()
        {
            _eventHandlers = new EventHandlers();
            S.RespawningTeam += _eventHandlers.OnRespawningTeam;
            Map.AnnouncingScpTermination += _eventHandlers.OnAnnouncingScpTermination;
            Map.AnnouncingNtfEntrance += _eventHandlers.OnAnnouncingNtfEntrance;
            Log.Info($"{Name} v.{Version} enabled");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            _eventHandlers = null;
            S.RespawningTeam -= _eventHandlers.OnRespawningTeam;
            Map.AnnouncingScpTermination -= _eventHandlers.OnAnnouncingScpTermination;
            Map.AnnouncingNtfEntrance -= _eventHandlers.OnAnnouncingNtfEntrance;
            Log.Info($"{Name} v.{Version} disabled");
            base.OnDisabled();
        }

    }
}