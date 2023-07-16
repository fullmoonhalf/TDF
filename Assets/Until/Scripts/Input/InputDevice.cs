using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace until.input
{
    public interface InputDevice
    {
        #region Definitions.
        InputButton getButton();
        InputStick getRStick();
        InputStick getLStick();
        #endregion
    }
}

