namespace platform.include
{
    public interface IUdlHeader : IUrl
    {
        UdlHeadstream _getUdlHeadstream();

        string _getString(string nName);

        StringTable _getStringTable();
    }
}
