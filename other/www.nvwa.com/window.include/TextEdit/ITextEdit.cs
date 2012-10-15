namespace window.include
{
    public interface ITextEdit : IWidget
    {
        void _setDockStyle(string nDockStyle);

        void _runCreate(string nPath);

        void _runLoad(string nPath);

        void _runSave(string nPath);

        bool _isDirty();
    }
}
