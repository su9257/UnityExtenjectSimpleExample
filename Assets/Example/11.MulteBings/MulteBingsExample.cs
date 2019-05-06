using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;

public class MulteBingsExample : MonoBehaviour
{

    void Start()
    {
        var container = new DiContainer();
        container.Bind(typeof(IInterfaceA), typeof(AbsClass), typeof(ClassA)).To<ClassA>().AsTransient();

        // 只可以通过 IInterface 解析实例
        container.BindInterfacesTo<ClassB>().AsTransient();

        // 可以通过 IInterface 或 Class A 解析实例
        container.BindInterfacesAndSelfTo<ClassC>().AsTransient();

        var obj_A1  =  container.Resolve<IInterfaceA>();
        var obj_A2 = container.Resolve<AbsClass>();
        var obj_A3 = container.Resolve<ClassA>();
        obj_A1.Do();
        obj_A2.Do();
        obj_A3.Do();


        var obj_B = container.Resolve<IInterfaceB>();
        obj_B.Do();

        var obj_C1 = container.Resolve<IInterfaceC>();
        var obj_C2 = container.Resolve<ClassC>();
        obj_C1.Do();
        obj_C2.Do();
    }



    public interface IInterfaceA { void Do(); }
    public abstract class AbsClass : IInterfaceA
    {
        public abstract void Do();
    }
    public class ClassA : AbsClass
    {
        public override void Do()
        {
            this.Log("Do ClassA");
        }
    }

    public interface IInterfaceB { void Do(); }
    public class ClassB : IInterfaceB
    {
        public  void Do()
        {
            this.Log("Do ClassB");
        }
    }

    public interface IInterfaceC { void Do(); }
    public class ClassC : IInterfaceC
    {
        public void Do()
        {
            this.Log("Do ClassC");
        }
    }
}
