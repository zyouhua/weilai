using window.include;
using platform.include;

namespace notepad.include
{
    public abstract class TextContentDockUrl : ContentDockUrl
    {
        public override void _runInit()
        {
            mTextDockWidget._runInit();
            base._runInit();
        }

        public override void _initControl()
        {
            mTextDockWidget._initControl();
            base._initControl();
        }

        protected ITextDockWidget _getTextDockWidget()
        {
            return mTextDockWidget;
        }

        public TextContentDockUrl()
        {
            mTextDockWidget = new TextDockWidget();
            base._regDockWidget(mTextDockWidget);
        }

        ITextDockWidget mTextDockWidget;
    }
}
