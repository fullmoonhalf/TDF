using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace until.input
{
    [DefaultExecutionOrder(until.defines.UntilBehaviorOrder.System_InputManagerBehavior)]
    [DisallowMultipleComponent]
    public class InputManagerBehavior : utils.Behavior
    {
        // Update is called once per frame
        void Update()
        {
            Singleton.InputManager.onUpdate();
        }
    }
}

