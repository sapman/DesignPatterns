using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.Save(new TextMemento(richTex.Text));
        }

        public void Undo(RichTextBox richText)
        {
            if (careTake.HasUndo)
                richText.Text = careTake.Undo().savedText;
        }

        public void Redo(RichTextBox richText)
        {
            if (careTake.HasRedo)
                richText.Text = careTake.Redo().savedText;
        }
    }
}
