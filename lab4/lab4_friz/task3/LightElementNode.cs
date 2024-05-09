using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; } 
        public bool IsSelfClosing { get; }
        public List<string> Classes { get; }
        public List<LightNode> Children { get; }
        private Dictionary<string, Action> eventHandlers; 

        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            Classes = new List<string>();
            Children = new List<LightNode>();
            eventHandlers = new Dictionary<string, Action>();
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void AddClass(string className)
        {
            Classes.Add(className);
        }

        public void AddEventListener(string eventType, Action handler)
        {
            eventHandlers[eventType] = handler; 
        }

        public void RemoveEventListener(string eventType)
        {
            eventHandlers.Remove(eventType); 
        }

        public void TriggerEvent(string eventType)
        {
            if (eventHandlers.ContainsKey(eventType))
            {
                eventHandlers[eventType].Invoke();  
            }
        }

        public string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.ToHtml());
            }
            return sb.ToString();
        }

        public override string ToHtml()
        {
            var classes = Classes.Count > 0 ? $" class='{string.Join(" ", Classes)}'" : "";
            if (IsSelfClosing)
            {
                return $"<{TagName}{classes} />";
            }
            else
            {
                return $"<{TagName}{classes}>{InnerHTML()}</{TagName}>";
            }
        }
    }
}
