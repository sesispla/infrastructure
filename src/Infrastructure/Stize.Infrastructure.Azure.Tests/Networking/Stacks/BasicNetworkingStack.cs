﻿using System;
using Pulumi;
using Stize.Infrastructure.Azure.Networking;

namespace Stize.Infrastructure.Tests.Azure.Networking.Stacks
{
    public class NetworkingBasicStack : Stack
    {
        public NetworkingBasicStack()
        {
            var builder = new VNetBuilder("vnet1");
            builder
                .Location("westeurope")
                .ResourceGroup("my-resource-group")
                .AddressSpace("172.16.0.0/24");

            builder.Build();
        }
    }
}