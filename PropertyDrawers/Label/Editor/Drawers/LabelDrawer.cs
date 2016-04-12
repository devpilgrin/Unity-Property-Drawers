using Assets.Editor.Attributes;
using UnityEditor;
using UnityEngine;

namespace Assets.Editor.Drawers
{
    [CustomPropertyDrawer(typeof(LabelAttribute))]
    public class LabelDrawer : PropertyDrawer
    {
        LabelAttribute MuLabelAttribute
        {
            get
            {
                return (LabelAttribute)attribute;
            }
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {

            if (string.IsNullOrEmpty(MuLabelAttribute.Text))
            {
                EditorGUI.PropertyField(position, property, new GUIContent(MuLabelAttribute.Text));
            }
            else
            {
                EditorGUI.PropertyField(position, property, label);
            }
        }
    }
}