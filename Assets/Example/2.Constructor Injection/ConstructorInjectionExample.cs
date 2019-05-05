using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class ConstructorInjectionExample : MonoBehaviour
    {
        private ConstructorInjectionInstaller.DataSaver mDataSaver;
        [Inject]
        private void TestConstructor(ConstructorInjectionInstaller.DataSaver dataSaver)
        {
            mDataSaver = dataSaver;
        }
        void Start()
        {
            mDataSaver.Save();
        }
    }
}
