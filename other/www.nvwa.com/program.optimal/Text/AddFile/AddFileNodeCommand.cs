using window.include;
using notepad.include;
using platform.include;

namespace program.optimal
{
    public class AddFileNodeCommand : ListItem, IStream
    {
        public void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mImageUrl, @"imageUrl");
            nSerialize._serialize(ref mCommandUrl, @"commandUrl");
            nSerialize._serialize(ref mCommandName, @"commandName");
        }

        public void _runInit()
        {
        }

        public string _getCommandUrl()
        {
            return mCommandUrl;
        }

        public override string _getListItemName()
        {
            return mCommandName;
        }

        public override string _getListItemImage()
        {
            return mImageUrl;
        }

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

        public AddFileNodeCommand()
        {
            mCommandName = null;
            mCommandUrl = null;
            mImageUrl = null;
            mStreamDirty = false;
        }


        string mCommandName;
        string mCommandUrl;
        string mImageUrl;
        bool mStreamDirty;
    }
}
