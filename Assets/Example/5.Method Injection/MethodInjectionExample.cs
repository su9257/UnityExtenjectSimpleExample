using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class MethodInjectionExample : MonoBehaviour
    {
        private TestObjectA mObjectA;
        private TestObjectB mObjectB;
        [Inject]
        void Injected(TestObjectA objectA, TestObjectB objectB)
        {
            mObjectA = objectA; mObjectB = objectB;
        }
        private void Start()
        {
            mObjectA.Say();
            mObjectB.Say();
        }
    }
}
