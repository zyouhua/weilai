using notepad.include;
using program.include;
using platform.include;

namespace program.optimal
{
    public class TextClass : TextContentAllStream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mBuildAction, "buildAction");
            nSerialize._serialize(ref mFileName, "fileName");
        }

        public override string _getTreeNodeName()
        {
            return mFileName;
        }

        public void _setBuildAction(BuildAction_ nBuildAction)
        {
            if (nBuildAction == BuildAction_.mCompile_)
            {
                mBuildAction = "Compile";
            }
            else
            {
                mBuildAction = "None";
            }
        }

        public BuildAction_ _getBuildAction()
        {
            if ("Compile" == mBuildAction)
            {
                return BuildAction_.mCompile_;
            }
            else
            {
                return BuildAction_.mNone_;
            }
        }

        public void _setFileName(string nFileName)
        {
            mFileName = nFileName;
        }

        public string _getFileName()
        {
            return mFileName;
        }

        public override string _getTreeNodeImage()
        {
            string suffix_ = "txt";
            int pos_ = mFileName.LastIndexOf(".");
            if (pos_ > 0)
            {
                suffix_ = mFileName.Substring(pos_ + 1);
            }
            PlatformSingleton platformSingleton_ = __singleton<PlatformSingleton>._instance();
            return platformSingleton_._findContentImage(suffix_);
        }

        public override string _getDockUrlName()
        {
            return mFileName;
        }

        public override IUrl _getIUrl()
        {
            return mUfl;
        }

        public TextClass()
        {
            ITextDockWidget textDockWidget_ = this._getTextDockWidget();
            mUfl = new Ufl();
            mUfl.m_tUflCreate += textDockWidget_._runCreate;
            mUfl.m_tUflLoad += textDockWidget_._runLoad;
            mUfl.m_tUflSave += textDockWidget_._runSave;
            mUfl.m_tIsDirty += textDockWidget_._isDirty;
            SaveSingleton saveSingleton_ = __singleton<SaveSingleton>._instance();
            saveSingleton_._addSave(mUfl);
        }

        string mBuildAction;
        string mFileName;
        Ufl mUfl;
    }
}
