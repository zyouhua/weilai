using window.include;

namespace notepad.include
{
    public interface ITextDockWidget : IDockWidget
    {
        ITextEdit _getTextEdit();

        void _runCreate(string nPath);

        void _runLoad(string nPath);

        void _runSave(string nPath);

        bool _isDirty();
    }
}
