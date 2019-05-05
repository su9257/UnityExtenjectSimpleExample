using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class PropertyInjectionExample : MonoBehaviour
    {
        [Inject]
        protected ResLoader ResLoader { get; private set; }          // Start is called before the first frame update       
        void Start()
        {
            ResLoader.Load<GameObject>("prefabA");
        }
    }
}
