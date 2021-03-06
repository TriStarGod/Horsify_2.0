﻿using Horsesoft.Horsify.Statistics.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace Horsesoft.Horsify.Statistics
{
    public class StatisticsModule : IModule
    {
        private IRegionManager _regionManager;
        private IUnityContainer _container;

        public StatisticsModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;            
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<GlobalStatsView>();
        }
    }
}