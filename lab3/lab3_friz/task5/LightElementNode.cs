using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }  // "block" or "line"
        public bool IsSelfClosing { get; }
        public List<string> Classes { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, string displayType, bool isSelfClosing)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            Classes = new List<string>();
            Children = new List<LightNode>();
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public void AddClass(string className)
        {
            Classes.Add(className);
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
