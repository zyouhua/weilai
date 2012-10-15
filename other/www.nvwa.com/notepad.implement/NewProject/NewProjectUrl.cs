using System.Collections.Generic;

using window.include;
using platform.include;

namespace notepad.implement
{
    public class NewProjectUrl : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mNewProjectNodes, "newProjectNodes");
            base._headSerialize(nSerialize);
        }

        public override string _streamName()
        {
            return @"newProjectUrl";
        }

        public void _runInit()
        {
            foreach (NewProjectNode i in mNewProjectNodes)
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
            foreach (NewProjectNode i in mNewProjectNodes)
            {
                nTreeContain._addTreeNode(i);
            }
        }

        public NewProjectUrl()
        {
            mNewProjectNodes = new List<NewProjectNode>();
            mStdUfl = new StdUfl();
            mStdUfl.m_tHeadSerializeSlot += this._headSerialize;
            mStdUfl.m_tStreamNameSlot += this._streamName;
        }

        List<NewProjectNode> mNewProjectNodes;
        StdUfl mStdUfl;
    }
}
