using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class FieldInjectionInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<LoginService>().AsSingle();
        }
        public class LoginService
        {
            public void Login()
            {
                this.Log("登录成功");
            }
            public void Logout()
            {
                this.Log("注销成功");
            }
        }
    }
}
