using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace until.test
{
    public class GameMasteringTaskEntity : GameMasteringTask
    {
        /// <summary>ìÔà’ìx</summary>
        public uint Difficulty { get; private set; } = 0U;
        /// <summary>êiíªíl</summary>
        public uint Progress { get; private set; } = 0U;
    }
}


