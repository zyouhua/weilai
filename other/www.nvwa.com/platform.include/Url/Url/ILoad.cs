namespace platform.include
{
    public interface ILoad
    {
        void _runLoad(string nUrl);

        void _runLoad(string nUrl, string nName);

        event _RunSlot m_tLoadInit;

        void _loadInit();
    }
}
