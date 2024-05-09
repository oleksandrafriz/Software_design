using System;
using System.Collections.Generic;
using System.Text;
using task5;

namespace task6
{
    public class LightElementNode1 : LightNode
    {
        public string TagName { get; }
        public List<LightNode> Children { get; }

        public LightElementNode1(string tagName)
        {
            TagName = tagName;
            Children = new List<LightNode>();
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string ToHtml()
        {
            var content = new StringBuilder();
            foreach (var child in Children)
            {
                content.Append(child.ToHtml());
            }
            return $"<{TagName}>{content}</{TagName}>";
        }
    }
}
