using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using until.singleton;


namespace until.modules.entity
{
    public class EntityManager : Singleton<EntityManager>
    {
        /// <summary>�G���e�B�e�B�̃��X�g</summary>
        private Dictionary<EntityIdentifier, EntityHolder> _EntityCollection = new Dictionary<EntityIdentifier, EntityHolder>();

        #region Singleton
        public override void onSingletonAwake()
        {
        }

        public override void onSingletonStart()
        {
        }

        public override void onSingletonDestroy()
        {
        }
        #endregion

        #region �o�^�֌W
        public void regist(int entity_id, int type_id, GameObject game_object)
        {
            var eid = new EntityIdentifier(entity_id);
            var tid = new EntityTypeInfo(type_id);
            var holder = new EntityHolder(eid, tid, game_object);
            _EntityCollection.Add(eid, holder);
        }

        public void unregist(int entity_id)
        {
            var eid = new EntityIdentifier(entity_id);
            _EntityCollection.Remove(eid);
        }
        #endregion
    }
}

