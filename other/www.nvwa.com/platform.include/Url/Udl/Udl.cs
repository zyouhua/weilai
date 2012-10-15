namespace platform.include
{
    public class Udl : Url, IUdl
    {
        public override void _runCreate(string nUrl)
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._newUdl<Udl>(this, nUrl);
            base._runCreate(nUrl);
        }

        public override void _runCreate(string nUrl, string nName)
        {
            mUdlHeadstream._setFileName(nName);
            base._runCreate(nUrl, nName);
        }

        public override string _getUrl(string nUrl, string nName)
        {
            string result_ = nUrl.TrimEnd(new char[] { '/', '\\' });
            result_ += "\\";
            result_ += nName;
            return result_;
        }

        public override void _runLoad(string nUrl)
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._loadUdl<Udl>(this, nUrl);
            base._runLoad(nUrl);
        }

        public override void _runSave()
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            string udlUrl_ = this._getUrl();
            platformSingleton_._saveUdl<Udl>(this, udlUrl_);
            base._runSave();
        }

        public override void _runDel()
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            string udlUrl_ = this._getUrl();
            platformSingleton_._deleteUdl<Udl>(this, udlUrl_);
            base._runDel();
            base._endDel();
        }

        public event _SetStringSlot m_tUflCreate;

        public void _runUflCreate(string nUrl)
        {
            if (null != m_tUflCreate)
            {
                this.m_tUflCreate(nUrl);
            }
        }

        public event _SetStringSlot m_tUflLoad;

        public void _runUflLoad(string nUrl)
        {
            if (null != m_tUflLoad)
            {
                this.m_tUflLoad(nUrl);
            }
        }

        public event _SetStringSlot m_tUflSave;

        public void _runUflSave(string nUrl)
        {
            if (null != m_tUflSave)
            {
                this.m_tUflSave(nUrl);
            }
        }

        public UdlHeadstream _getUdlHeadstream()
        {
            return mUdlHeadstream;
        }

        public string _getString(string nName)
        {
            return mStringTable._getString(nName);
        }

        public StringTable _getStringTable()
        {
            return mStringTable;
        }

        public Udl()
        {
            mUdlHeadstream = new UdlHeadstream();
            mStringTable = new StringTable();
            m_tUflCreate = null;
            m_tUflLoad = null;
        }

        UdlHeadstream mUdlHeadstream;
        StringTable mStringTable;
    }
}
