using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class BindToExample : MonoBehaviour
    {
        void Start()
        {
            var container = new DiContainer();
            container.Bind<IBluetoothSerivce>().To<BluetoothService>().AsTransient();
            var bluetoothService = container.Resolve<IBluetoothSerivce>();
            bluetoothService.Connect();
        }
        public interface IBluetoothSerivce
        {
            void Connect();
        }
        public class BluetoothService : IBluetoothSerivce
        {
            public void Connect()
            {
                this.Log("蓝牙连接成功！");
            }
        }
    }
}
