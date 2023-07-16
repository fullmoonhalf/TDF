using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace until
{
    [DefaultExecutionOrder(until.defines.UntilBehaviorOrder.System_SystemBehavior)]
    [DisallowMultipleComponent]
    public class SystemBehavior : utils.Behavior
    {
        void Update()
        {
            Singleton.SceneLoader.onUpdate();
            Singleton.PrefabInstantiateMediator.onUpdate();
            Singleton.GameObjectControlMediator.onUpdate();
        }
    }
}

