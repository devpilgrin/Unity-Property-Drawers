using Assets.Editor.Attributes;
using UnityEngine;
using UnityEditor;

namespace Assets.Editor.Drawers
{
    [CustomPropertyDrawer(typeof (HelpAttribute))]
    public class HelpDrawer : PropertyDrawer
    {

        private int helpHeight = 50, textHeight = 16, HeaderY = 2;

        private HelpAttribute helpAttribute
        {
            get { return (HelpAttribute) attribute; }
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (!string.IsNullOrEmpty(helpAttribute.HelpMessageText))
            {
                position.height = textHeight;

                EditorGUI.PropertyField(position, property, label);

                position.y += textHeight + HeaderY;
                position.height = helpHeight;

                EditorGUI.HelpBox(position, helpAttribute.HelpMessageText, MessageType.Info);
            }
            else
            {
                EditorGUI.PropertyField(position, property, label);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label) + helpHeight +
                   (string.IsNullOrEmpty(helpAttribute.HelpMessageText) ? 0 : textHeight);
        }
    }
}