using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;

public class AsSingleExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var container = new DiContainer();

        container.Bind<ClassA>().AsSingle();

        var obj1 = container.Resolve<ClassA>();
        var obj2 = container.Resolve<ClassA>();

        this.Log(obj1.GetHashCode().ToString());
        this.Log(obj2.GetHashCode().ToString());

    }
    private class ClassA
    {

    }

}
