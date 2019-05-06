using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;
public class AsTransientExample : MonoBehaviour
{
   
    void Start()
    {
        var container = new DiContainer();
        container.Bind<ClassA>().AsTransient();
        var obj1 = container.Resolve<ClassA>();
        var obj2 = container.Resolve<ClassA>();
        this.Log(obj1.GetHashCode().ToString());
        this.Log(obj2.GetHashCode().ToString());
    }

    class ClassA { }

}
