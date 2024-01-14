using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using until.utils;


namespace until.modules.entity
{
    /// <summary>
    /// ŒÂ‘Ì¯•Êq
    /// </summary>
    public class EntityIdentifier : Identifier<EntityIdentifier>
    {
        /// <summary>¯•Ê”Ô†</summary>
        public int ID { get; private set; }

        #region Methods.
        public EntityIdentifier(int id)
        {
            ID = id;
        }

        #region Identifier
        public override int Hashcode => ID;

        public override int compare(EntityIdentifier other)
        {
            return Math.Sign(ID - other.ID);
        }

        public override bool equal(EntityIdentifier other)
        {
            return ID == other.ID;
        }
        #endregion
        #endregion
    }

    /// <summary>
    /// í•Ê¯•Êq
    /// </summary>
    public class EntityTypeInfo : Identifier<EntityTypeInfo>
    {
        /// <summary>¯•Ê”Ô†</summary>
        public int ID { get; private set; }

        #region Methods.
        public EntityTypeInfo(int id)
        {
            ID = id;
        }

        #region Identifier
        public override int Hashcode => ID;

        public override int compare(EntityTypeInfo other)
        {
            return Math.Sign(ID - other.ID);
        }

        public override bool equal(EntityTypeInfo other)
        {
            return ID == other.ID;
        }
        #endregion
        #endregion
    }


    public class EntityHolder
    {
        public EntityIdentifier Identifier { get; private set; }
        public EntityTypeInfo TypeInfo { get; private set; }
        public GameObject GameObject { get; private set; }


        public EntityHolder(EntityIdentifier identifier, EntityTypeInfo typeinfo, GameObject gameobject)
        {
            Identifier = identifier;
            TypeInfo = typeinfo;
            GameObject = gameobject;
        }
    }
}

