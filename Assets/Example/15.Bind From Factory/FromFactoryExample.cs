using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;

public class FromFactoryExample : MonoBehaviour
{
    private void Start()
    {
        var container = new DiContainer();
        container.Bind<string>().FromFactory<StringFactory>();
        this.Log(container.Resolve<string>());
    }
    class StringFactory : IFactory<string>
    {
        public string Create()
        {
            return "Hello World";
        }
    }
}
