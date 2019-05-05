using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class MethodInjectionInstaller : MonoInstaller
    {

        public override void InstallBindings()
        {
            Container.Bind<TestObjectA>().AsTransient();
            Container.Bind<TestObjectB>().AsTransient();
        }
    }
    public class TestObjectA
    {
        public void Say()
        {
            this.Log("Object A Say");
        }
    }
    public class TestObjectB
    {
        public void Say()
        {
            this.Log("Object B Say");
        }
    }

}
