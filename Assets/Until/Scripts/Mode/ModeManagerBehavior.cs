using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace until.mode
{
    [DefaultExecutionOrder(until.defines.UntilBehaviorOrder.System_ModeManagerBehavior)]
    [DisallowMultipleComponent]
    public class ModeManagerBehavior : utils.Behavior
    {
        // Update is called once per frame
        void Update()
        {
            Singleton.ModeManager.onUpdate();
        }
    }
}

