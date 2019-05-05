using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class DiContainerExample : MonoBehaviour
    {
        private void Start()
        {
            var container = new DiContainer();
            container.Bind<BluetoothService>().AsTransient();
            var bluetoothService = container.Resolve<BluetoothService>();
            bluetoothService.Connect();
        }
        public class BluetoothService
        {
            public void Connect()
            {
                this.Log("蓝牙连接成功");
            }
        }
    }
}
