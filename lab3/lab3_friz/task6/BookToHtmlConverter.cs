using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task5;

namespace task6
{
    public static class BookToHtmlConverter
    {
        public static LightElementNode ConvertTextToHtml(string[] lines)
        {
            var root = new LightElementNode("div", "block", false);
            bool isFirstLine = true;

            foreach (var line in lines)
            {
                string trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine))
                    continue;

                LightElementNode node;
                if (isFirstLine)
                {
                    node = new LightElementNode("h1", "block", false);
                    isFirstLine = false;
                }
                else if (line.StartsWith(" "))
                {
                    node = new LightElementNode("blockquote", "block", false);
                }
                else if (trimmedLine.Length < 20)
                {
                    node = new LightElementNode("h2", "block", false);
                }
                else
                {
                    node = new LightElementNode("p", "block", false);
                }

                node.AddChild(new LightTextNode(trimmedLine));
                root.AddChild(node);
            }

            return root;
        }

    }
}
