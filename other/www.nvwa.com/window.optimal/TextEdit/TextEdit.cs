using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

using window.include;
using platform.include;

namespace window.optimal
{
    public class TextEdit : Widget, ITextEdit
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mDockStyle, @"dockStyle");
            base._serialize(nSerialize);
        }

        public override string _virstream()
        {
            return @"textEdit";
        }

        public override void _initControl()
        {
            if (null == mTextEditorControl || mTextEditorControl.IsDisposed)
            {
                mTextEditorControl = new TextEditEx();
                if (string.Compare(mDockStyle, @"Top") == 0)
                {
                    mTextEditorControl.Dock = DockStyle.Top;
                }
                else if (string.Compare(mDockStyle, @"Bottom") == 0)
                {
                    mTextEditorControl.Dock = DockStyle.Bottom;
                }
                else if (string.Compare(mDockStyle, @"Fill") == 0)
                {
                    mTextEditorControl.Dock = DockStyle.Fill;
                }
                else if (string.Compare(mDockStyle, @"Left") == 0)
                {
                    mTextEditorControl.Dock = DockStyle.Left;
                }
                else if (string.Compare(mDockStyle, @"Right") == 0)
                {
                    mTextEditorControl.Dock = DockStyle.Right;
                }
                else
                {
                    mTextEditorControl.Dock = DockStyle.None;
                }
                if (null != mPath)
                {
                    mTextEditorControl._runLoad(mPath);
                }
            }
        }

        public override IWidget _createControl()
        {
            return new TextEdit();
        }

        public override object _getControl()
        {
            return mTextEditorControl;
        }

        public void _runCreate(string nPath)
        {
            FileStream fileStream_ = File.Create(nPath);
            fileStream_.Close();
            mPath = nPath;
        }

        public void _runLoad(string nPath)
        {
            mPath = nPath;
            if (null == mTextEditorControl || mTextEditorControl.IsDisposed)
            {
                return;
            }
            mTextEditorControl._runLoad(nPath);
        }

        public void _runSave(string nPath)
        {
            mPath = nPath;
            if (null == mTextEditorControl || mTextEditorControl.IsDisposed)
            {
                return;
            }
            mTextEditorControl._runSave(nPath);
        }

        public bool _isDirty()
        {
            if (null== mTextEditorControl || mTextEditorControl.IsDisposed)
            {
                return false;
            }
            return mTextEditorControl._isDirty();
        }

        public void _setDockStyle(string nDockStyle)
        {
            mDockStyle = nDockStyle;
        }

        public TextEdit()
        {
            mTextEditorControl = null;
            mDockStyle = @"None";
            mPath = null;
        }

        TextEditEx mTextEditorControl;
        string mDockStyle;
        string mPath;
    }
}
