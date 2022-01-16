using System;
using UnityEngine;

namespace UnityAdditionalAttributes
{
    public class GameObjectImplementAttribute : PropertyAttribute
    {
        public readonly Type ImplementType;
        public readonly bool AllowSceneObjects;

        public GameObjectImplementAttribute(Type implementType, bool allowSceneObjects = true)
        {
            ImplementType = implementType;
            AllowSceneObjects = allowSceneObjects;
        }
    }
}