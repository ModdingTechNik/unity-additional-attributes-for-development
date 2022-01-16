using UnityEditor;
using UnityEngine;

namespace UnityAdditionalAttributes.Editor
{
    [CustomPropertyDrawer(typeof(ReadOnlyInInspectorAttribute), true)]
    public class ReadOnlyInInspectorAttributePropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            EditorGUI.BeginDisabledGroup(true);
            EditorGUI.PropertyField(position, property, label, true);
            EditorGUI.EndDisabledGroup();
            EditorGUI.EndProperty();
        }
    }
}