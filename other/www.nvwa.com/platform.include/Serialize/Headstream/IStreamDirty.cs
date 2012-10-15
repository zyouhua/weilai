namespace platform.include
{
    public interface IStreamDirty
    {
        void _runStreamDirty();

        event _GetBoolSlot m_tIsStreamDirty;

        bool _isStreamDirty();

        event _RunSlot m_tRunStreamSave;

        void _runStreamSave();
    }
}
