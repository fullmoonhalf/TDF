using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace until.test
{
    public class GameMasteringTaskEntity : GameMasteringTask
    {
        /// <summary>��Փx</summary>
        public uint Difficulty { get; private set; } = 0U;
        /// <summary>�i���l</summary>
        public uint Progress { get; private set; } = 0U;
    }
}


