using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;

public class FromPrimitiveTypeExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var container = new DiContainer();
        container.Bind<int>().FromInstance(996);
        container.BindInstance("Hello World");
        this.Log(container.Resolve<int>().ToString());
        this.Log(container.Resolve<string>().ToString());
    }


}
