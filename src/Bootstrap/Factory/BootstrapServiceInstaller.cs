// Copyright (C) 2019, The Tuckfirtle Developers
// 
// Please see the included LICENSE file for more information.

using Microsoft.Extensions.DependencyInjection;
using TheDialgaTeam.Core.DependencyInjection;
using Tuckfirtle.Miner.Bootstrap.Service;

namespace Tuckfirtle.Miner.Bootstrap.Factory
{
    internal sealed class BootstrapServiceInstaller : IServiceInstaller
    {
        public void InstallService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddInterfacesAndSelfAsSingleton<BootstrapService>();
        }
    }
}