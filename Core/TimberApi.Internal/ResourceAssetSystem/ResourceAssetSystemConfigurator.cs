﻿using Bindito.Core;

namespace TimberApi.Internal.ResourceAssetSystem
{
    public class ResourceAssetSystemConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<AssetSystemConfiguratorPatcher>().AsSingleton();
        }
    }
}