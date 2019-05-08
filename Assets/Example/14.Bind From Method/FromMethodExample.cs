using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Custom.Log;

public class FromMethodExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var container = new DiContainer();
        container.Bind<int>().FromMethod(() => 996);
        container.Bind<string>().FromMethod(() => Random.Range(0, 10).ToString());
        this.Log($"{container.Resolve<int>()}");
        this.Log($"{container.Resolve<string>()}");
        this.Log($"{container.Resolve<string>()}");
        this.Log($"{container.Resolve<string>()}");
    }


}
