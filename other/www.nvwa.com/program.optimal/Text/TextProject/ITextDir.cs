namespace program.optimal
{
    public interface ITextDir
    {
        void _addTextClass(TextClass nTextClass);

        void _newTextDir();

        string _getDirUrl();

        string _getDirName();
    }
}
