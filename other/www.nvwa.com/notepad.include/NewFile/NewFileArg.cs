namespace notepad.include
{
    public class NewFileArg
    {
        public object _getParent()
        {
            return mParent;
        }

        public string _getFileName()
        {
            return mFileName;
        }

        public NewFileArg(object nParent, string nFileName)
        {
            mParent = nParent;
            mFileName = nFileName;
        }

        object mParent;
        string mFileName;
    }
}
