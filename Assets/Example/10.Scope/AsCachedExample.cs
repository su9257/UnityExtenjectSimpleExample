using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;

public class AsCachedExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var container = new DiContainer();
        container.Bind<IInterface>().To<ClassA>().AsCached();
        container.Bind<ClassA>().AsCached();
        var obj1 = container.Resolve<IInterface>();
        var obj2 = container.Resolve<IInterface>();

        this.Log(obj1.GetHashCode().ToString());
        this.Log(obj2.GetHashCode().ToString());

        var obj3 = container.Resolve<ClassA>();
        var obj4 = container.Resolve<ClassA>();

        this.Log(obj3.GetHashCode().ToString());
        this.Log(obj4.GetHashCode().ToString());
    }

    interface IInterface { }
    class ClassA : IInterface { }
}
