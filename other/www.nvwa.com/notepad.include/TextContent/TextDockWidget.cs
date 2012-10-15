using window.include;
using platform.include;

namespace notepad.include
{
    public class TextDockWidget : ITextDockWidget
    {
        public void _runInit()
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            string textEditUrl_ = @"uid://notepad.include.window:window.optimal.TextEdit";
            mTextEdit = platformSingleton_._findInterface<ITextEdit>(textEditUrl_);
            mTextEdit._setDockStyle("Fill");
        }

        public void _initControl()
        {
        }

        public void _runCreate(string nPath)
        {
            if (null != mTextEdit)
            {
                mTextEdit._runCreate(nPath);
            }
        }

        public void _runLoad(string nPath)
        {
            if (null != mTextEdit)
            {
                mTextEdit._runLoad(nPath);
            }
        }

        public void _runSave(string nPath)
        {
            if (null != mTextEdit)
            {
                mTextEdit._runSave(nPath);
            }
        }

        public bool _isDirty()
        {
            if (null != mTextEdit)
            {
                return mTextEdit._isDirty();
            }
            return false;
        }

        public ITextEdit _getTextEdit()
        {
            return mTextEdit;
        }

        public IWidget _getControl()
        {
            return mTextEdit;
        }

        public string _dockName()
        {
            return @"textEdit";
        }

        public TextDockWidget()
        {
            mTextEdit = null;
        }

        ITextEdit mTextEdit;
    }
}
