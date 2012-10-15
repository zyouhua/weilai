using System.Collections.Generic;

using window.include;
using notepad.include;
using platform.include;

namespace program.optimal
{
    public abstract class TextProject : ContentAll, ITextDir
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mTextClasses, @"files");
            nSerialize._serialize(ref mTextDirs, "dirs");
            nSerialize._serialize(ref mProjectName, "projectName");
            nSerialize._serialize(ref mReference, "reference", mReference);
            base._headSerialize(nSerialize);
        }

        public override string _streamName()
        {
            return "project";
        }

        public override void _runInit()
        {
            base._runInit();

            foreach (TextClass i in mTextClasses)
            {
                i._runInit();
            }

            WorkbenchSingleton workbenchSingleton_ = __singleton<WorkbenchSingleton>._instance();
            workbenchSingleton_._showTreeNode(this);
        }

        public override void _initControl()
        {
            base._initControl();

            foreach (TextClass i in mTextClasses)
            {
                i._initControl();
            }
        }

        public string _getDirUrl()
        {
            return this._getUrl();
        }

        public string _getDirName()
        {
            return mProjectName;
        }

        public void _newTextDir()
        {
            string name_ = this._newTextDirName();
            TextDir textDir_ = new TextDir();
            textDir_._setDirName(name_);
            mTextDirs.Add(textDir_);
            base._newChild(textDir_);
            base._runDirty();
        }

        string _newTextDirName()
        {
            string dirName_ = "newFolder";
            if (this._containDir(dirName_))
            {
                int index_ = 1;
                while (this._containDir(dirName_ + index_))
                {
                    index_++;
                }
                return dirName_ + index_;
            }
            return dirName_;
        }

        bool _containDir(string nName)
        {
            foreach (TextDir i in mTextDirs)
            {
                string dirName_ = i._getDirName();
                if (dirName_ == nName)
                {
                    return true;
                }
            }
            return false;
        }

        public void _addTextClass(TextClass nTextClass)
        {
            mTextClasses.Add(nTextClass);
            base._newChild(nTextClass);
            base._runDirty();
        }

        public void _setProjectName(string nProjectName)
        {
            mProjectName = nProjectName;
            base._setTreeNodeName(nProjectName);
        }

        public string _getProjectName()
        {
            return mProjectName;
        }

        public void _setId(string nId)
        {
            UdlHeadstream udlHeadstream_ = mProjectUrl._getUdlHeadstream();
            udlHeadstream_._setId(nId);
        }

        public override void _addTreeNode(ITreeContain nTreeContain)
        {
            nTreeContain._addTreeNode(mReference);
            foreach (TextClass i in mTextClasses)
            {
                nTreeContain._addTreeNode(i);
            }
            base._addTreeNode(nTreeContain);
        }

        public override void _treeNodeDoubleClick(TreeNodeMouseClickEventParams nTreeNodeMouseClickEventParams)
        {
        }

        public override string _getTreeNodeName()
        {
            return mProjectName;
        }

        public override string _getDockUrlName()
        {
            string result_ = mProjectName + ".";
            result_ += this._fileSuffix();
            return result_;
        }

        protected abstract string _fileSuffix();

        public override IUrl _getIUrl()
        {
            return mProjectUrl;
        }

        public TextProject()
        {
            mReference = new Reference();
            mTextClasses = new List<TextClass>();
            mTextDirs = new List<TextDir>();
            mProjectName = null;
            mProjectUrl = new StdUdl();
            mProjectUrl.m_tHeadSerializeSlot += this._headSerialize;
            mProjectUrl.m_tSerializeTypeSlot += this._serializeType;
            mProjectUrl.m_tStreamNameSlot += this._streamName;
            mProjectUrl.m_tIsDirty += this._isDirty;
            SaveSingleton saveSingleton_ = __singleton<SaveSingleton>._instance();
            saveSingleton_._addSave(mProjectUrl);
        }

        List<TextClass> mTextClasses;
        List<TextDir> mTextDirs;
        string mProjectName;
        StdUdl mProjectUrl;
        Reference mReference;
    }
}
