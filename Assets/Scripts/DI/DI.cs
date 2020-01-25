using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SenseiGameJam.DependencyInjection
{
    public static class DI
    {
        static Dictionary<System.Type, IDependency> singletons;
        static readonly EmptyDependency emptyDependency = new EmptyDependency();

        public static bool GetSingleton(System.Type type, out IDependency dependency)
        {
            return singletons.TryGetValue(type, out dependency);
        }

        public static void RegisterSingleton(System.Type type, IDependency dependency)
        {
            singletons.Add(type, dependency);
        }

        public static bool UnregisterSingleton(System.Type type)
        {
            return singletons.Remove(type);
        }
    }
}