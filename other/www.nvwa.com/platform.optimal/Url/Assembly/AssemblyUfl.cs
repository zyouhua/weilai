using System;
using System.IO;
using System.Reflection;

using platform.include;

namespace platform.optimal
{
    public class AssemblyUfl : Ufl
    {
        public override void _runLoad(string nUrl)
        {
            UrlParser urlParser_ = new UrlParser(nUrl);
            string assemblyPath_ = urlParser_._returnResult();
            AssemblyName assemblyName_ = AssemblyName.GetAssemblyName(assemblyPath_);
            AppDomain appDomain_ = AppDomain.CurrentDomain;
            Assembly[] assemblies_ = appDomain_.GetAssemblies();
            foreach (Assembly i in assemblies_)
            {
                if (string.Compare(i.FullName, assemblyName_.FullName) == 0)
                {
                    mAssembly = i;
                }
            }
            if (null == mAssembly)
            {
                this._instanceAssembly(assemblyPath_);
                string namespace_ = assemblyName_.Name;
                string pluginClass_ = namespace_ + ".Plugin";
                IPlugin plugin_ = mAssembly.CreateInstance(pluginClass_) as IPlugin;
                if (null != plugin_)
                {
                    plugin_._startupPlugin();
                }
            }
            base._runLoad(nUrl);
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

        public object _findClass(string nId)
        {
            object result_ = mAssembly.CreateInstance(nId);
            return result_;
        }

        public AssemblyUfl()
        {
            mAssembly = null;
        }

        Assembly mAssembly;
    }
}
