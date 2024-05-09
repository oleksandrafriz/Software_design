using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TextEditor
    {
        private TextDocument document;
        private Stack<DocumentMemento> history = new Stack<DocumentMemento>();

        public TextEditor(TextDocument doc)
        {
            document = doc;
        }

        public void Save()
        {
            history.Push(document.CreateMemento());
        }

        public void Undo()
        {
            if (history.Count > 0)
            {
                document.Restore(history.Pop());
            }
        }

        public string GetText()
        {
            return document.Content;
        }

        public void Edit(string newText)
        {
            Save(); 
            document = new TextDocument(newText);
        }
    }
}
