namespace platform.include
{
    public interface IStream : IStreamDirty
    {
        void _serialize(ISerialize nSerialize);
    }
}
