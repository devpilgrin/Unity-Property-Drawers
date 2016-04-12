using UnityEngine;

namespace Assets.Editor.Attributes
{
    /// <summary>
    /// Label attribute - Атрибут позволяет заменить стандартный Label на собственную строку.
    /// </summary>
    public class LabelAttribute : PropertyAttribute
    {
        public string Text;
        public LabelAttribute(string text)
        {
            Text = text;
        }
    }
}
 