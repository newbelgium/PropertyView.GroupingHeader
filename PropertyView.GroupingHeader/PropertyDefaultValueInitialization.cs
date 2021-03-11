﻿using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace PropertyView.GroupingHeader
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Cms.Shell.InitializableModule))]
    public class PropertyDefaultValueInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            context.InitComplete += (sender, args) =>
            {
                var _editorRegistry = ServiceLocator.Current.GetInstance<MetadataHandlerRegistry>();
                var _localizationService = ServiceLocator.Current.GetInstance<LocalizationService>();

                _editorRegistry.RegisterMetadataHandler(typeof(ContentData),
                    new GroupingHeaderMetadataExtender(_localizationService), null,
                    EditorDescriptorBehavior.PlaceLast);
            };
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}
