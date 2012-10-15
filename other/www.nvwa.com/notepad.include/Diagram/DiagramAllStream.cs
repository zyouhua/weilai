using platform.include;

namespace notepad.include
{
    public abstract class DiagramAllStream : DiagramAll, IStream
    {
        public abstract void _serialize(ISerialize nSerialize);

        public void _runStreamDirty()
        {
            mIsStreamDirty = true;
        }

        public event _GetBoolSlot m_tIsStreamDirty;

        public virtual bool _isStreamDirty()
        {
            if (mIsStreamDirty)
            {
                return true;
            }
            if (null == m_tIsStreamDirty)
            {
                return false;
            }
            return this.m_tIsStreamDirty();
        }

        public event _RunSlot m_tRunStreamSave;

        public virtual void _runStreamSave()
        {
            if (null != m_tRunStreamSave)
            {
                this.m_tRunStreamSave();
            }
            mIsStreamDirty = false;
        }

        public DiagramAllStream()
        {
            m_tIsStreamDirty = null;
            m_tRunStreamSave = null;
            mIsStreamDirty = false;
        }

        bool mIsStreamDirty;
    }
}
