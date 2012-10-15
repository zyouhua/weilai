using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Forms.Integration;

namespace window.optimal
{
    public class TextEditEx : ElementHost
    {
        public void _runLoad(string nPath)
        {
            mTextEditor.Load(nPath);
        }

        public void _runSave(string nPath)
        {
            mTextEditor.Save(nPath);
        }

        public bool _isDirty()
        {
            return mDirty;
        }

        void _documentChanged(object sender, EventArgs e)
        {
            mDirty = true;
        }

        public TextEditEx()
        {
            mTextEditor = new ICSharpCode.AvalonEdit.TextEditor();
            TextOptions.SetTextFormattingMode(mTextEditor, TextFormattingMode.Display);
            mTextEditor.FontSize = 13;
            mTextEditor.FontFamily = new FontFamily("新宋体");
            mTextEditor.DocumentChanged += _documentChanged;
            this.Child = mTextEditor;
        }

        ICSharpCode.AvalonEdit.TextEditor mTextEditor;
        bool mDirty = false;
    }
}
