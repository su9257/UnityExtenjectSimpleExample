using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;

namespace Zenject.Example
{
    public class HelloWorld : MonoBehaviour
    {
        [Inject]
        private QuickStartInstaller.A a = null;

        void Awake()
        {
            this.Log("Awake");
            a.HelloWorld();
        }
        void Start()
        {
            this.Log("Start");
            a.HelloWorld();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
