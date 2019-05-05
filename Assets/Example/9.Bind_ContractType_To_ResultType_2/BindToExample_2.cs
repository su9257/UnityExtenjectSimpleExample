using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Custom.Log;


namespace Zenject.Example
{
    public class BindToExample_2 : MonoBehaviour
    {
        void Start()
        {
            var container = new DiContainer();
            container.Bind<IInterface>().To<ClassA>().AsTransient();
            container.Bind<AbsClass>().To<ClassA>().AsTransient();
            container.Bind<ClassA>().AsTransient();

            container.Resolve<IInterface>().Do();
            container.Resolve<AbsClass>().Do();
            container.Resolve<ClassA>().Do();
        }
    }


    public interface IInterface
    {
        void Do();
    }
    public abstract class AbsClass : IInterface
    {
        public abstract void Do();
    }
    public class ClassA : AbsClass
    {
        public override void Do()
        {
            this.Log("Do Sth");
        }
    }
}
