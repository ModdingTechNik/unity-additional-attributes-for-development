using System;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityAdditionalAttributes.Editor
{
    [CustomPropertyDrawer(typeof(GameObjectImplementAttribute), false)]
    public class GameObjectImplementAttributePropertyDrawer : PropertyDrawer
    {
        private const string TargetError = "The GameObjectImplementAttribute can only be used on a GameObject";
        private const string AttributeNull = "The GameObjectImplementAttribute is NULL";
        
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            DrawGUI(position, property, label);
            EditorGUI.EndProperty();
        }

        private void DrawGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!TargetPropertyIsGameObject())
            {
                EditorGUI.HelpBox(position,TargetError, MessageType.Error);
                return;
            }

            GameObjectImplementAttribute gameObjectImplement = attribute as GameObjectImplementAttribute;
            if (gameObjectImplement == null)
            {
                EditorGUI.HelpBox(position,AttributeNull, MessageType.Error);
                return;
            }

            if (!DragAndDropIsValid(position, gameObjectImplement.ImplementType))
                DragAndDrop.visualMode = DragAndDropVisualMode.Rejected;

            Object referenceValue = property.objectReferenceValue;

            property.objectReferenceValue = EditorGUI.ObjectField(position, label, property.objectReferenceValue,
                typeof(GameObject), gameObjectImplement.AllowSceneObjects);

            if (!IsValidReference(property, gameObjectImplement.ImplementType))
                property.objectReferenceValue = referenceValue;
        }

        private bool IsValidReference(SerializedProperty property, Type requiredType)
        {
            if (property != null)
                if (ObjectIsValid(property.objectReferenceValue, requiredType)) return true;
            return false;
        }

        private bool DragAndDropIsValid(Rect position, Type requiredType)
        {
            if (position.Contains(Event.current.mousePosition))
                foreach (var reference in DragAndDrop.objectReferences)
                    if (!ObjectIsValid(reference, requiredType))
                        return false;
            return true;
        }

        private bool ObjectIsValid(Object objectReference, Type requiredType)
        {
            if (objectReference is GameObject gameObject)
                return gameObject.GetComponent(requiredType) != null;
            return false;
        }

        private bool TargetPropertyIsGameObject()
        {
            Type fieldType = fieldInfo.FieldType;
            return fieldType == typeof(GameObject);
        }
    }
}