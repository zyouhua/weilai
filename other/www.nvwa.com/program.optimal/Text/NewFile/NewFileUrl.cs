using System.Collections.Generic;

using window.include;
using platform.include;

namespace program.optimal
{
    public class NewFileUrl : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mNewFileNodes, "newFileNodes");
            base._headSerialize(nSerialize);
        }

        public override string _streamName()
        {
            return @"newFileUrl";
        }

        public void _runInit()
        {
            foreach (NewFileNode i in mNewFileNodes)
            {
                i._runInit();
            }
        }

        public void _runLoad(string nUrl)
        {
            mStdUfl._runLoad(nUrl);
        }

        public void _addTreeNode(ITreeContain nTreeContain)
        {
            foreach (NewFileNode i in mNewFileNodes)
            {
                nTreeContain._addTreeNode(i);
            }
        }

        public NewFileUrl()
        {
            mNewFileNodes = new List<NewFileNode>();
            mStdUfl = new StdUfl();
            mStdUfl.m_tHeadSerializeSlot += this._headSerialize;
            mStdUfl.m_tStreamNameSlot += this._streamName;
        }

        List<NewFileNode> mNewFileNodes;
        StdUfl mStdUfl;
    }
}
