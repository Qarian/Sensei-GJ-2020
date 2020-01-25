using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SenseiGameJam.DependencyInjection
{
    public static class DI
    {
        static Dictionary<System.Type, IDependency> singletons;
        static readonly EmptyDependency emptyDependency = new EmptyDependency();

        public static IDependency GetSingleton(System.Type type)
        {
            singletons.TryGetValue(type, out IDependency result);
            if(result != null)
            {
                return result;
            }
            else
            {
                return emptyDependency;
            }
        }
    }
}