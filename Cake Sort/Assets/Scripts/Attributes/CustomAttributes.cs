using UnityEditor;
using UnityEngine;

namespace Scripts.Attributes
{
    public class FoldoutGroupAttribute : PropertyAttribute
    {
        public string GroupName { get; private set; }

        public FoldoutGroupAttribute(string groupName)
        {
            GroupName = groupName;
        }
    }

    [CustomPropertyDrawer(typeof(FoldoutGroupAttribute))]
    public class FoldoutGroupDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            FoldoutGroupAttribute foldoutGroupAttribute = (FoldoutGroupAttribute)attribute;

            property.isExpanded = EditorGUI.Foldout(
                new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight),
                property.isExpanded, foldoutGroupAttribute.GroupName, true);

            EditorGUI.indentLevel++;

            if (property.isExpanded)
            {
                EditorGUI.PropertyField(new Rect(position.x, position.y + EditorGUIUtility.singleLineHeight,
                    position.width, EditorGUI.GetPropertyHeight(property)), property, true);
            }

            EditorGUI.indentLevel--;

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return property.isExpanded
                ? EditorGUI.GetPropertyHeight(property) + EditorGUIUtility.singleLineHeight
                : EditorGUIUtility.singleLineHeight;
        }
    }
}