using window.include;
using platform.include;

namespace notepad.include
{
    public interface IContent : IInit, IHeadstream
    {
        void _openUrl(string nUrl);

        void _openUrl(string nUrl, string nName);

        void _createUrl(string nUrl);

        void _createUrl(string nUrl, string nName);

        string _getUrl();

        IDockUrl _getDockUrl();

        ITreeNode _getTreeNode();

        void _initControl();
    }
}
