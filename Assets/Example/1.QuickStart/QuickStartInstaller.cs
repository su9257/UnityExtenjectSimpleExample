using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;

namespace Zenject.Example
{
    public class QuickStartInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<A>().AsTransient();
        }

        public class A
        {
            public void HelloWorld()
            {
                this.Log("Hello World");
            }
        }
    }
}
