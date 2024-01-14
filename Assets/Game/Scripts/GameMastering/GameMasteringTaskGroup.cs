using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace until.test
{
    public class GameMasteringTaskGroup : GameMasteringTask
    {
        private GameMasteringTask[] TaskList = null;

        public GameMasteringTaskGroup(uint count)
        {
            TaskList = new GameMasteringTask[count];
        }
    }
}


