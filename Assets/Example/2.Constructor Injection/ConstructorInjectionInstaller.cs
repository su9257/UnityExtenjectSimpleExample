using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class ConstructorInjectionInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<DataSaver>().AsTransient();
        }

        public class DataSaver
        {
            public void Save()
            {
                this.Log("数据保存成功！");
            }
        }
    }
}
