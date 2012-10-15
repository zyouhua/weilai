using System.Collections.Generic;

using window.include;
using platform.include;

namespace window.include
{
    public abstract class TreeNodeStream : TreeNode, IStream
    {
        public abstract void _serialize(ISerialize nSerialize);

        public void _runStreamDirty()
        {
            mStreamDirty = true;
        }

        public event _GetBoolSlot m_tIsStreamDirty;

        public virtual bool _isStreamDirty()
        {
            if (mStreamDirty)
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
            if (null == m_tRunStreamSave)
            {
                this.m_tRunStreamSave();
            }
            mStreamDirty = false;
        }

        public TreeNodeStream()
        {
            mStreamDirty = false;
        }

        bool mStreamDirty;
    }
}
