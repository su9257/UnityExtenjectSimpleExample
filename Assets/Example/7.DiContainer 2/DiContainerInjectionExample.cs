using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class DiContainerInjectionExample : MonoBehaviour
    {
        private void Start()
        {
            var container = new DiContainer();
            container.Bind<BluetoothService>().AsSingle();
            container.Inject(this);
            mBluetoothService.Connect();
        }

        [Inject]
        public BluetoothService mBluetoothService;
        public class BluetoothService
        {
            public void Connect()
            {
                this.Log("蓝牙连接成功");
            }
        }
    }
}
