﻿using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TangramCypher.ApplicationLayer.Vault;
using TangramCypher.Helpers.ServiceLocator;

namespace TangramCypher.ApplicationLayer.Commands.Vault
{
    public class VaultUnsealCommand : Command
    {
        private readonly IVaultService vaultService;
 
        public VaultUnsealCommand()
        {
            var serviceProvider = Locator.Instance.GetService<IServiceProvider>();
            vaultService = serviceProvider.GetService<IVaultService>();
        }

        public override async Task Execute()
        {
            var vaultShard = Prompt.GetPassword("Vault Shard:", ConsoleColor.Yellow);
            await vaultService.Unseal(vaultShard);
        }
    }
}
