namespace platform.include
{
    public abstract class Url : IUrl
    {
        public virtual void _runCreate(string nUrl)
        {
            mIsDirty = false;
            mUrl = nUrl;
        }

        public virtual void _runCreate(string nUrl, string nName)
        {
            string url_ = this._getUrl(nUrl, nName);
            this._runCreate(url_);
        }

        public virtual void _runLoad(string nUrl)
        {
            this._loadInit();
            mIsDirty = false;
            mUrl = nUrl;
        }

        public virtual void _runLoad(string nUrl, string nName)
        {
            string url_ = this._getUrl(nUrl, nName);
            this._runLoad(url_);
        }

        public event _RunSlot m_tLoadInit;

        public virtual void _loadInit()
        {
            if (null != m_tLoadInit)
            {
                this.m_tLoadInit();
            }
        }

        public void _runSave(string nUrl)
        {
            this._runDel();
            this._runCreate(nUrl);
        }

        public void _runDirty()
        {
            mIsDirty = true;
        }

        public event _GetBoolSlot m_tIsDirty;

        public virtual bool _isDirty()
        {
            if (mIsDirty)
            {
                return true;
            }
            if (null == m_tIsDirty)
            {
                return false;
            }
            return this.m_tIsDirty();
        }

        public event _RunSlot m_tRunSave;

        public virtual void _runSave()
        {
            if (null != m_tRunSave)
            {
                this.m_tRunSave();
            }
            mIsDirty = false;
        }

        public event _RunSlot m_tRunDel;

        public virtual void _runDel()
        {
            if (null != m_tRunDel)
            {
                this.m_tRunDel();
            }
        }

        protected void _endDel()
        {
            mIsDirty = false;
            mUrl = null;
        }

        public string _getUrl()
        {
            return mUrl;
        }

        public abstract string _getUrl(string nUrl, string nName);

        public Url()
        {
            m_tLoadInit = null;
            m_tIsDirty = null;
            m_tRunSave = null;
            m_tRunDel = null;
            mIsDirty = false;
            mUrl = null;
        }

        bool mIsDirty;
        string mUrl;
    }
}
