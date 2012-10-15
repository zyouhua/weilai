namespace window.include
{
    public interface IDockWidget
    {
        void _runInit();

        void _initControl();

        IWidget _getControl();

        string _dockName();
    }
}
