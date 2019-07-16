using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class TextCareTaker
    {
        List<TextMemento> mementos;
        int index;
        public TextCareTaker()
        {
            mementos = new List<TextMemento>();
            index = 0;
        }


        public bool HasUndo { get => index > 0; }
        public bool HasRedo { get => index < mementos.Count - 1; }

        public void Save(TextMemento memento)
        {
            if (index < mementos.Count - 1)
                mementos.RemoveRange(index, mementos.Count - index);
            mementos.Add(memento);
            index = mementos.Count - 1;
        }

        public TextMemento Undo()
        {
            return mementos[--index];
        }

        public TextMemento Redo()
        {
            return mementos[++index];
        }
    }
}
