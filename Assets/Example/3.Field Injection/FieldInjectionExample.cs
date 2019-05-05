using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class FieldInjectionExample : MonoBehaviour
    {
        [Inject]
        public FieldInjectionInstaller.LoginService mLoginService;
        private void Start()
        {
            mLoginService.Login();
            mLoginService.Logout();
        }
    }
}
