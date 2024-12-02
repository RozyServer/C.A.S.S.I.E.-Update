using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Server;

using Respawning;

namespace CASSIEUpdate.Handlers;

public class EventHandlers
{
    public void OnRespawningTeam(RespawningTeamEventArgs ev)
    {
        if (ev.NextKnownTeam == SpawnableTeamType.ChaosInsurgency)
        {
            Cassie.Clear();
            Cassie.Message(Plugin.Instance.Config.CassieCI);
        }
    }

    public void OnAnnouncingScpTermination(AnnouncingScpTerminationEventArgs ev)
    {
        ev.IsAllowed = false;
        Cassie.Clear();
        string msg = Plugin.Instance.Config.CassieScp.Replace("%Scp%", ev.Role.Type.ToString())
            .Replace("%TerminationCause%", ev.TerminationCause).Replace("%Damage%", ev.DamageHandler.ToString());
            Cassie.Message(msg, false, false, true);
    }

    public void OnAnnouncingNtfEntrance(AnnouncingNtfEntranceEventArgs ev)
    {
        ev.IsAllowed = false;
        string msg = Plugin.Instance.Config.CassieNTF.Replace("%NTF%", ev.UnitName)
            .Replace("%Number%", ev.UnitNumber.ToString()).Replace("%ScpCount%", ev.ScpsLeft.ToString());
        Cassie.Clear();
        Cassie.Message(msg, false, false, true);
    }
}