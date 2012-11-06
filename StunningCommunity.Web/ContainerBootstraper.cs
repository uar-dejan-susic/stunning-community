using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using Unity.WebApi;

namespace StunningCommunity.Web
{
    public class ContainerBootstraper
    {
        public static void Initalize()
        {
            var container = BuildContainer();

            DependencyResolver.SetResolver( new UnityDependencyResolver( container ) );
        }

        public static IUnityContainer BuildContainer()
        {
            var container = new UnityContainer();

            ServiceLocator.SetLocatorProvider( () => new UnityServiceLocator( container ) );

            return container;
        }
    }
}