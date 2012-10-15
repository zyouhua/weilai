using window.include;
using program.include;
using notepad.include;
using platform.include;

namespace program.optimal
{
    public class Class : DiagramAllStream, IClass
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mClassName, "className");
            nSerialize._serialize(ref mClassCanvas, "classCanvas");
            base._headSerialize(nSerialize);
        }

        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mClassId, "classId");
        }

        public override string _streamName()
        {
            return "nvwaclass";
        }

        public void _loadClass(string nProjectUrl, int nClassId)
        {
            string fileName_ = @"class" + nClassId + ".nvwaclass";
            this._openUrl(nProjectUrl, fileName_);
        }

        public void _createClass(string nProjectUrl, int nClassId)
        {
            this._setClassId(nClassId);
            string fileName_ = @"class" + nClassId + ".nvwaclass";
            UdlHeadstream udlHeadstream_ = mClassUrl._getUdlHeadstream();
            udlHeadstream_._setFileName(fileName_);
            this._createUrl(nProjectUrl, fileName_);
        }

        public void _setClassId(int nClassId)
        {
            mClassId = nClassId;
            this._runStreamDirty();
        }

        public int _getClassId()
        {
            return mClassId;
        }

        public void _setClassName(string nName)
        {
            mClassName = nName;
            this._runDirty();
        }

        public string _getClassName()
        {
            return mClassName;
        }

        public override void _firstInit()
        {
            UdlHeadstream udlHeadstream_ = mClassUrl._getUdlHeadstream();
            udlHeadstream_._setId(@"zyouhua@gmail.com:nvwaclass");
            base._firstInit();
        }

        public override void _runInit()
        {
            mClassCanvas._runInit();
            base._runInit();
        }

        private void _loadInit()
        {

        }

        public override bool _isDirty()
        {
            if (mClassCanvas._isStreamDirty())
            {
                return true;
            }
            return base._isDirty();
        }

        public override void _runSave()
        {
            mClassCanvas._runStreamSave();
            base._runSave();
        }

        public override string _getTreeNodeName()
        {
            return mClassName;
        }

        static readonly string mNvwaClassImage = @"rid://program.optimal.classImageUrl";
        public override string _getTreeNodeImage()
        {
            return mNvwaClassImage;
        }

        public override ICanvasDockWidget _getCanvasDockWidget()
        {
            return mClassCanvas;
        }

        public override string _getDockUrlName()
        {
            return mClassName;
        }

        public override IUrl _getIUrl()
        {
            return mClassUrl;
        }

        public Class()
        {
            mClassCanvas = new ClassCanvas(this);
            base._regDockWidget(mClassCanvas);
            mClassName = null;
            mClassId = default(int);
            mClassUrl = new StdUdl();
            mClassUrl.m_tHeadSerializeSlot += this._headSerialize;
            mClassUrl.m_tSerializeTypeSlot += this._serializeType;
            mClassUrl.m_tStreamNameSlot += this._streamName;
            mClassUrl.m_tLoadInit += this._loadInit;
            mClassUrl.m_tIsDirty += this._isDirty;
            mClassUrl.m_tRunSave += this._runSave;
            SaveSingleton saveSingleton_ = __singleton<SaveSingleton>._instance();
            saveSingleton_._addSave(mClassUrl);
        }

        ClassCanvas mClassCanvas;
        string mClassName;
        StdUdl mClassUrl;
        int mClassId;
    }
}
