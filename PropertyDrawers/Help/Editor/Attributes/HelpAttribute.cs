using UnityEngine;

namespace Assets.Editor.Attributes
{
    public class HelpAttribute : PropertyAttribute
    {
        public string HelpMessageText;
        public HelpAttribute(string text)
        {
            HelpMessageText = text;
        }
    }
}
