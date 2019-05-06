using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;
public class BindInstanceAndNewExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var container = new DiContainer();

        //本质上行传递的是引用，一个实例化的引用
        container.Bind<A>().FromInstance(new A());
        container.BindInstance(new B());
        container.BindInstances(new C(), new D());

        //显式实例化
        container.Bind<E>().FromNew().AsTransient();

        this.Log($"类型为：{container.Resolve<A>().GetType()}");
        this.Log(container.Resolve<A>().GetHashCode().ToString());
        this.Log(container.Resolve<A>().GetHashCode().ToString());

        this.Log(new string('*', 20));
        this.Log($"类型为：{container.Resolve<B>().GetType()}");
        this.Log(container.Resolve<B>().GetHashCode().ToString());
        this.Log(container.Resolve<B>().GetHashCode().ToString());

        this.Log(new string('*', 20));
        this.Log(container.Resolve<C>().GetType().ToString());
        this.Log(container.Resolve<C>().GetHashCode().ToString());
        this.Log(container.Resolve<C>().GetHashCode().ToString());

        this.Log(new string('*', 20));
        this.Log(container.Resolve<D>().GetType().ToString());
        this.Log(container.Resolve<D>().GetHashCode().ToString());
        this.Log(container.Resolve<D>().GetHashCode().ToString());

        this.Log(new string('*', 20));
        this.Log(container.Resolve<E>().GetHashCode().ToString());
        this.Log(container.Resolve<E>().GetHashCode().ToString());
    }

    class A { }
    class B { }
    class C { }
    class D { }
    class E { }
}
