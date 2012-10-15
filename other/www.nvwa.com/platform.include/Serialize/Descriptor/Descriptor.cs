namespace platform.include
{
    public class Descriptor : Headstream, IDescriptor
    {
        public UdlHeadstream _getUdlHeadstream()
        {
            return mUdlHeadstream;
        }

        public string _getString(string nName)
        {
            return mStringTable._getString(nName);
        }

        public StringTable _getStringTable()
        {
            return mStringTable;
        }

        public Descriptor()
        {
            mUdlHeadstream = new UdlHeadstream();
            mStringTable = new StringTable();
        }

        UdlHeadstream mUdlHeadstream;
        StringTable mStringTable;
    }
}
