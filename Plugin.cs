using Subble.Core;
using Subble.Core.Logger;
using Subble.Core.Plugin;

using System.Collections.Generic;

namespace BasicLogger
{
    public class Plugin : ISubblePlugin
    {
        public IPluginInfo Info
            => new PluginInfo();

        public SemVersion Version
            => new SemVersion(0, 0, 1);

        public long LoadPriority => 5;

        public IEnumerable<Dependency> Dependencies
            => new List<Dependency>();

        public bool Initialize(ISubbleHost host)
        {
            if (host is null)
                return false;

            var logger = new Logger(host);
            return host.ServiceContainer.RegisterService<ILogger>(logger, Version);
        }
    }
}
