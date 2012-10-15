namespace platform.include
{
    public class Ufl : Url, IUfl
    {
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

        public override void _runCreate(string nUrl)
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._newUfl<Ufl>(this, nUrl);
            base._runCreate(nUrl);
        }

        public override void _runLoad(string nUrl)
        {
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._loadUfl<Ufl>(this, nUrl);
            base._runLoad(nUrl);
        }

        public override void _runSave()
        {
            string url_ = this._getUrl();
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._saveUfl<Ufl>(this, url_);
            base._runSave();
        }

        public override string _getUrl(string nUrl, string nName)
        {
            string result_ = nUrl.TrimEnd(new char[] { '/', '\\' });
            result_ += "*";
            result_ += nName;
            return result_;
        }

        public override void _runDel()
        {
            string uflUrl_ = this._getUrl();
            if (null == uflUrl_)
            {
                return;
            }
            base._runDel();
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            platformSingleton_._deleteUfl(uflUrl_);
            base._endDel();
        }
    }
}
