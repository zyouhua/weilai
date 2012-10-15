namespace platform.include
{
    public interface IDescriptor : IHeadstream
    {
        UdlHeadstream _getUdlHeadstream();

        string _getString(string nName);

        StringTable _getStringTable();
    }
}
