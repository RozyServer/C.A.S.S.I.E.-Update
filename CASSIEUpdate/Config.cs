using Exiled.API.Interfaces;

namespace CASSIEUpdate
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public string CassieCI { get; set; } = "Chaos Insurgency arrived!";
        public string CassieNTF { get; set; } = "%NTF% обозначеная как %Number% прибыла, %ScpCount% осталось!";
        public string CassieScp { get; set; } = "%Scp% умер %TerminationCause% (%Damage%)!";
    }
}