﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace until.gameobject
{
    [Serializable]
    public class PrefabNamedWrapper : PrefabWrapper
    {
        public string Name
        {
            get => _Name;
        }

        [SerializeField]
        private string _Name = "";

        #region コンストラクタ
        public PrefabNamedWrapper()
        {
        }

        public PrefabNamedWrapper(UnityEngine.Object prefab) : base(prefab)
        {
        }
        #endregion
    }
}

