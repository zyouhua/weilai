namespace platform.include
{
    public interface IPlatform
    {
        __t _findHeadstream<__t>(string nUrl) where __t : IHeadstream;

        void _loadHeadstream<__t>(__t nT, string nUrl) where __t : IHeadstream;

        __t _loadHeadstream<__t>(string nHeadstreamUrl, string nUrl) where __t : IHeadstream;
        
        __t _findDescriptor<__t>(string nUrl) where __t : IDescriptor;

        __t _loadDescriptor<__t>(string nDescriptorUrl, string nUrl) where __t : IDescriptor;
        
        void _newUfl<__t>(__t nT, string nUrl) where __t : IUfl;

        void _loadUfl<__t>(__t nT, string nUrl) where __t : IUfl;

        void _saveUfl<__t>(__t nT, string nUrl) where __t : IUfl;
        
        void _deleteUfl(string nUrl);

        void _newStdUfl<__t>(__t nT, string nUrl) where __t : IStdUfl;

        void _loadStdUfl<__t>(__t nT, string nUrl) where __t : IStdUfl;

        void _saveStdUfl<__t>(__t nT, string nUrl) where __t : IStdUfl;

        void _newUdl<__t>(__t nT, string nUrl) where __t : IUdl;
        
        void _loadUdl<__t>(__t nT, string nUrl) where __t : IUdl;
        
        void _saveUdl<__t>(__t nT, string nUrl) where __t : IUdl;
        
        void _deleteUdl<__t>(__t nT, string nUrl) where __t : IUdl;
        
        void _newStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl;
        
        void _loadStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl;
        
        void _saveStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl;
        
        void _deleteStdUdl<__t>(__t nT, string nUrl) where __t : IStdUdl;

        void _deleteUrl(string nUrl);

        __t _findContent<__t>(string nUrl);

        string _findContentImage(string nName);

        void _loadBindingManager(string nUrl);
        
        string[] _rootUrls();
        
        string[] _files(string nUrl);
        
        string[] _arcs(string nUrl);
        
        string[] _dirUrls(string nUrl);
        
        string[] _fileUrls(string nUrl);
        
        string _findUrl(string nUrl);
        
        __t _findInterface<__t>(string nUrl);
        
        object _findIcon(string nUrl);
        
        object _findPng(string nUrl);
        
        ICulture _currentCulture();
       
        void _sleep(int nSecond);

        IThread _createThread();

        IProcess _createProcess(string nCommand, string nArguments);

        ISerialize _getReader(SerializeType_ nSerializeType);
        
        ISerialize _getWriter(SerializeType_ nSerializeType);
    }
}
