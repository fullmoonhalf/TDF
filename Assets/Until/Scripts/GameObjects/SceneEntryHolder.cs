using System;
using UnityEngine;


namespace until.gameobject
{
    [Serializable]
    public class SceneEntry
    {
        public string Path = "";
    }

    [CreateAssetMenu(menuName = "Until/SceneEntryHolder", fileName = nameof(SceneEntryHolder))]
    public class SceneEntryHolder : ScriptableObject
    {
        public SceneEntry[] Entries
        {
            get => _Entries;
        }
        public string Category
        {
            get => _Category;
        }

        [SerializeField]
        private string _Category = "";
        [SerializeField]
        private SceneEntry[] _Entries = null;
    }
}

