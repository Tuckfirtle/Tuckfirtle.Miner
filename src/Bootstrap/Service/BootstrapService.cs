// Copyright (C) 2019, The Tuckfirtle Developers
// 
// Please see the included LICENSE file for more information.

using System;
using System.Reflection;
using System.Runtime.Versioning;
using TheDialgaTeam.Core.DependencyInjection;

namespace Tuckfirtle.Miner.Bootstrap.Service
{
    internal sealed class BootstrapService : IServiceExecutor
    {
        public void ExecuteService(ITaskAwaiter taskAwaiter)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var frameworkVersion = Assembly.GetExecutingAssembly().GetCustomAttribute<TargetFrameworkAttribute>().FrameworkName;
            Console.Title = $"Tuckfirtle Miner v{version} ({frameworkVersion})";
        }
    }
}