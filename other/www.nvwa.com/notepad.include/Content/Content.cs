using System.Collections.Generic;

using window.include;
using platform.include;

namespace notepad.include
{
    public abstract class Content : Headstream, IContent
    {
        public void _openUrl(string nUrl)
        {
            IUrl url_ = this._getIUrl();
            url_._runLoad(nUrl);
        }

        public void _openUrl(string nUrl, string nName)
        {
            IUrl url_ = this._getIUrl();
            url_._runLoad(nUrl, nName);
        }

        public void _createUrl(string nUrl)
        {
            IUrl url_ = this._getIUrl();
            url_._runCreate(nUrl);
        }

        public virtual void _createUrl(string nUrl, string nName)
        {
            IUrl url_ = this._getIUrl();
            url_._runCreate(nUrl, nName);
        }

        public string _getUrl()
        {
            IUrl url_ = this._getIUrl();
            return url_._getUrl();
        }

        public abstract IUrl _getIUrl();

        public override void _runSave()
        {
            IUrl url_ = this._getIUrl();
            base._runSave();
        }

        public virtual IDockUrl _getDockUrl()
        {
            return null;
        }

        public virtual ITreeNode _getTreeNode()
        {
            return null;
        }

        public virtual void _firstInit()
        {
        }

        public virtual void _runInit()
        {
        }

        public virtual void _initControl()
        {

        }

        public Content()
        {
        }
    }
}
