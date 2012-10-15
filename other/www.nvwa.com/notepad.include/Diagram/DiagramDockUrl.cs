using window.include;
using platform.include;

namespace notepad.include
{
    public abstract class DiagramDockUrl : ContentDockUrl
    {
        public override void _runInit()
        {
            ICanvasDockWidget canvasDockWidget_ = this._getCanvasDockWidget();
            canvasDockWidget_._runInit();
            base._runInit();
        }

        public override void _initControl()
        {
            ICanvasDockWidget canvasDockWidget_ = this._getCanvasDockWidget();
            canvasDockWidget_._initControl();
            base._initControl();
        }

        public abstract ICanvasDockWidget _getCanvasDockWidget();

        public DiagramDockUrl()
        {
        }
    }
}
