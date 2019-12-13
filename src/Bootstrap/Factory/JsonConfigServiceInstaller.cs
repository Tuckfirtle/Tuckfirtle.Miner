// Copyright (C) 2019, The Tuckfirtle Developers
// 
// Please see the included LICENSE file for more information.

using Microsoft.Extensions.DependencyInjection;
using TheDialgaTeam.Core.DependencyInjection;
using Tuckfirtle.Miner.Bootstrap.Service;
using Tuckfirtle.Miner.Config;

namespace Tuckfirtle.Miner.Bootstrap.Factory
{
    internal sealed class JsonConfigServiceInstaller : IServiceInstaller
    {
        private string ConfigFilePath { get; }

        public JsonConfigServiceInstaller(string configFilePath)
        {
            ConfigFilePath = configFilePath;
        }

        public void InstallService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddInterfacesAndSelfAsSingleton(new JsonConfig(ConfigFilePath));
            serviceCollection.AddInterfacesAndSelfAsSingleton<JsonConfigService>();
        }
    }
}