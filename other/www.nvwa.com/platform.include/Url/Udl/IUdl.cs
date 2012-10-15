namespace platform.include
{
    public interface IUdl : IUdlHeader
    {
        event _SetStringSlot m_tUflCreate;

        void _runUflCreate(string nUrl);

        event _SetStringSlot m_tUflLoad;

        void _runUflLoad(string nUrl);

        event _SetStringSlot m_tUflSave;

        void _runUflSave(string nUrl);
    }
}
