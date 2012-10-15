using System.Collections.Generic;

using window.include;
using program.include;
using notepad.include;
using platform.include;

namespace program.optimal
{
    public class Project : DiagramAll, IProject
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mClasses, "classes");
            nSerialize._serialize(ref mClassId, "classId");
            nSerialize._serialize(ref mProjectName, "projectName");
            nSerialize._serialize(ref mProjectCanvas, "projectCanvas");
            nSerialize._serialize(ref mProjectDockWidget, "projectProperty");
            base._headSerialize(nSerialize);
        }

        public override string _streamName()
        {
            return "nvwaProject";
        }

        public void _setApplicationType(ApplicationType_ nApplicationType)
        {
            mProjectDockWidget._setApplicationType(nApplicationType);
        }

        public override void _createUrl(string nUrl, string nName)
        {
            string projectName_ = null;
            string fileName_ = null;
            int pos_ = nName.LastIndexOf(".");
            if (pos_ < 0)
            {
                projectName_ = nName;
                fileName_ = nName + ".nvwaproject";
            }
            else
            {
                string suffix_ = nName.Substring(pos_ + 1);
                if (suffix_ != "nvwaproject")
                {
                    projectName_ = nName;
                    fileName_ = nName + ".nvwaproject";
                }
                else
                {
                    projectName_ = nName.Substring(0, pos_);
                    fileName_ = nName;
                }
            }
            UdlHeadstream udlHeadstream_ = mProjectUrl._getUdlHeadstream();
            udlHeadstream_._setFileName(fileName_);
            this._setProjectName(projectName_);
            base._createUrl(nUrl, fileName_);
        }

        public void _createClass(string nName)
        {
            Class class_ = new Class();
            class_._setClassName(nName);
            class_._firstInit();
            string projectUrl_ = mProjectUrl._getUrl();
            class_._createClass(projectUrl_, mClassId);
            mClassId++;
            class_._runInit();
            this._newChild(class_);
            mClasses.Add(class_);
            this._runDirty();
        }

        public bool _haveClass(string nName)
        {
            foreach (Class i in mClasses)
            {
                string name_ = i._getClassName();
                if (name_ == nName)
                {
                    return true;
                }
            }
            return false;
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

        public override void _firstInit()
        {
            UdlHeadstream udlHeadstream_ = mProjectUrl._getUdlHeadstream();
            udlHeadstream_._setId(@"zyouhua@gmail.com:nvwaproject");
            base._firstInit();
        }

        public override void _runInit()
        {
            mProjectDockWidget._runInit();
            WorkbenchSingleton workbenchSingleton_ = __singleton<WorkbenchSingleton>._instance();
            workbenchSingleton_._showTreeNode(this);
            mProjectCanvas._runInit();
            base._runInit();
        }

        private void _loadInit()
        {
            string projectUrl_ = mProjectUrl._getUrl();
            foreach (Class i in mClasses)
            {
                i._loadClass(projectUrl_, i._getClassId());
            }
        }

        public override bool _isDirty()
        {
            if (mProjectCanvas._isStreamDirty())
            {
                return true;
            }
            return base._isDirty();
        }

        public override void _runSave()
        {
            mProjectCanvas._runStreamSave();
            base._runSave();
        }

        public override void _addTreeNode(ITreeContain nTreeContain)
        {
            nTreeContain._addTreeNode(mReference);
            foreach (Class i in mClasses)
            {
                nTreeContain._addTreeNode(i);
            }
            base._addTreeNode(nTreeContain);
        }

        public override string _getTreeNodeName()
        {
            return mProjectName;
        }

        static readonly string mNvwaProjectImage = @"rid://program.optimal.nvwaprojectImageUrl";
        public override string _getTreeNodeImage()
        {
            return mNvwaProjectImage;
        }

        public override ICanvasDockWidget _getCanvasDockWidget()
        {
            return mProjectCanvas;
        }

        public override string _getDockUrlName()
        {
            string result_ = mProjectName;
            result_ += ".nvwaproject";
            return result_;
        }

        public override IUrl _getIUrl()
        {
            return mProjectUrl;
        }

        public Project()
        {
            mClasses = new List<Class>();
            mClassId = 1;
            mProjectCanvas = new ProjectCanvas(this);
            base._regDockWidget(mProjectCanvas);
            mProjectDockWidget = new ProjectDockWidget();
            base._regDockWidget(mProjectDockWidget);
            mReference = new Reference();
            mProjectName = null;
            mProjectUrl = new StdUdl();
            mProjectUrl.m_tHeadSerializeSlot += this._headSerialize;
            mProjectUrl.m_tSerializeTypeSlot += this._serializeType;
            mProjectUrl.m_tStreamNameSlot += this._streamName;
            mProjectUrl.m_tLoadInit += this._loadInit;
            mProjectUrl.m_tIsDirty += this._isDirty;
            mProjectUrl.m_tRunSave += this._runSave;
            SaveSingleton saveSingleton_ = __singleton<SaveSingleton>._instance();
            saveSingleton_._addSave(mProjectUrl);
        }

        List<Class> mClasses;
        int mClassId;
        ProjectDockWidget mProjectDockWidget;
        ProjectCanvas mProjectCanvas;
        string mProjectName;
        StdUdl mProjectUrl;
        Reference mReference;
    }
}
