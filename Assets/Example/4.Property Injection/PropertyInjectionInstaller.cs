using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class PropertyInjectionInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ResLoader>().AsTransient();
        }
    }

    public class ResLoader
    {
        public void Load<T>(string resName) where T : UnityEngine.Object
        {
            this.Log($"{typeof(T)}{resName}");
        }
    }
}
