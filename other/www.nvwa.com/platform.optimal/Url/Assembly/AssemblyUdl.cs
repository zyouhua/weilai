using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

using platform.include;

namespace platform.optimal
{
    public class AssemblyUdl : Udl
    {
        public override void _runLoad(string nUrl)
        {
            base._runLoad(nUrl);
            string assemblyInfoUrl_ = nUrl + @"*$assembly.xml";
            mAssemblyInfo._runLoad(assemblyInfoUrl_);
            UdlHeadstream udlHeadstream_ = this._getUdlHeadstream();
            string fileName_ = udlHeadstream_._getFileName();
            UrlParser urlParser_ = new UrlParser(nUrl);
            string assemblyPath_ = urlParser_._urlFile(fileName_);
            AssemblyName assemblyName_ = AssemblyName.GetAssemblyName(assemblyPath_);
            AppDomain appDomain_ = AppDomain.CurrentDomain;
            Assembly[] assemblies_ = appDomain_.GetAssemblies();
            foreach (Assembly i in assemblies_)
            {
                if (string.Compare(i.FullName, assemblyName_.FullName) == 0)
                {
                    mAssembly = i;
                    return;
                }
            }
            UidSingleton uidSingleton_ = __singleton<UidSingleton>._instance();
            IEnumerable<Uid> uids_ = mAssemblyDescriptor._getUids();
            foreach (Uid i in uids_)
            {
                uidSingleton_._addUid(i);
                Uid uid_ = i._getUid();
                string uidUrl_ = uid_._getOptimal();
                this._loadAssembly(uidUrl_);
            }
            IEnumerable<Rid> rids_ = mAssemblyDescriptor._getRids();
            foreach (Rid i in rids_)
            {
                uidSingleton_._addRid(i);
            }
            IEnumerable<string> dependences_ = mAssemblyDescriptor._getDependences();
            foreach (string i in dependences_)
            {
                this._loadAssembly(i);
            }
            this._instanceAssembly(assemblyPath_);
            string namespace_ = assemblyName_.Name;
            string pluginClass_ = namespace_ + ".Plugin";
            IPlugin plugin_ = mAssembly.CreateInstance(pluginClass_) as IPlugin;
            if (null != plugin_)
            {
                plugin_._startupPlugin();
            }
        }

        public object _findClass(string nId)
        {
            object result_ = mAssembly.CreateInstance(nId);
            return result_;
        }

        void _loadAssembly(string nUrl)
        {
            UrlParser urlParser_ = new UrlParser(nUrl);
            if (urlParser_._isFile())
            {
                AssemblyUfl assemblyUfl_ = new AssemblyUfl();
                assemblyUfl_._runLoad(nUrl);
            }
            else
            {
                AssemblyUdl assemblyUdl_ = new AssemblyUdl();
                assemblyUdl_._runLoad(nUrl);
            }
        }

        void _instanceAssembly(string nAssemblyPath)
        {
            mAssembly = Assembly.LoadFrom(nAssemblyPath);
            //FileStream fileStream_ = new FileStream(nAssemblyPath, FileMode.Open);
            //int fileLength_ = (int)fileStream_.Length;
            //byte[] buf_ = new byte[fileStream_.Length];
            //int num_ = 0;
            //while (fileLength_ > 0)
            //{
            //    int n = fileStream_.Read(buf_, num_, fileLength_);
            //    if (n == 0)
            //        break;
            //    num_ += n;
            //    fileLength_ -= n;
            //}
            //fileLength_ = buf_.Length;
            //fileStream_.Close();
            //mAssembly = Assembly.Load(buf_);
        }

        public AssemblyUdl()
        {
            mAssemblyDescriptor = new AssemblyDescriptor();
            mAssemblyInfo = new StdUfl();
            mAssemblyInfo.m_tSerializeTypeSlot += mAssemblyDescriptor._serializeType;
            mAssemblyInfo.m_tStreamNameSlot += mAssemblyDescriptor._streamName;
            mAssemblyInfo.m_tHeadSerializeSlot += mAssemblyDescriptor._headSerialize;
            mAssembly = null;
        }

        AssemblyDescriptor mAssemblyDescriptor;
        StdUfl mAssemblyInfo;
        Assembly mAssembly;
    }
}
