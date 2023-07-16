using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace until.boot
{
    [DefaultExecutionOrder(until.defines.UntilBehaviorOrder.System_BootSystemBehavior)]
    [DisallowMultipleComponent]
    public class BootSystemBehavior : utils.Behavior
    {
        // Update is called once per frame
        void Update()
        {
            Singleton.BootSystem.onUpdate();
        }
    }
}

