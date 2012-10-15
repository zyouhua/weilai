namespace notepad.include
{
    public class NewProjectArg
    {
        public string _getProjectName()
        {
            return mProjectName;
        }

        public string _getProjectUrl()
        {
            return mProjectUrl;
        }

        public NewProjectArg(string nProjectUrl, string nProjectName)
        {
            mProjectName = nProjectName;
            mProjectUrl = nProjectUrl;
        }

        string mProjectName;
        string mProjectUrl;
    }
}
