using System.Collections.Generic;

using window.include;
using platform.include;

namespace program.optimal
{
    public class AddFileUrl : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mAddFileNodes, "addFileNodes");
            base._headSerialize(nSerialize);
        }

        public override string _streamName()
        {
            return @"addFileUrl";
        }

        public void _runInit()
        {
            foreach (AddFileNode i in mAddFileNodes)
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
            foreach (AddFileNode i in mAddFileNodes)
            {
                nTreeContain._addTreeNode(i);
            }
        }

        public AddFileUrl()
        {
            mAddFileNodes = new List<AddFileNode>();
            mStdUfl = new StdUfl();
            mStdUfl.m_tHeadSerializeSlot += this._headSerialize;
            mStdUfl.m_tStreamNameSlot += this._streamName;
        }

        List<AddFileNode> mAddFileNodes;
        StdUfl mStdUfl;
    }
}
