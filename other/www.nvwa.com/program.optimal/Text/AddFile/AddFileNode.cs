using System.Collections.Generic;

using window.include;
using platform.include;

namespace program.optimal
{
    public class AddFileNode : TreeNodeStream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mNodeName, @"nodeName");
            nSerialize._serialize(ref mNodeImage, @"nodeImage");
            nSerialize._serialize(ref mAddFileNodes, @"addFileNodes");
            nSerialize._serialize(ref mAddFileNodeCommands, @"addFileNodeCommands");
        }

        public void _runInit()
        {
            foreach (AddFileNodeCommand i in mAddFileNodeCommands)
            {
                i._runInit();
            }
            foreach (AddFileNode i in mAddFileNodes)
            {
                i._runInit();
            }
        }

        public override void _addTreeNode(ITreeContain nTreeContain)
        {
            foreach (AddFileNode i in mAddFileNodes)
            {
                nTreeContain._addTreeNode(i);
            }
            base._addTreeNode(nTreeContain);
        }

        public override void _treeNodeClick(TreeNodeMouseClickEventParams nTreeNodeMouseClickEventParams)
        {
            IContain contain_ = nTreeNodeMouseClickEventParams._getcontain();
            IListView listView_ = contain_._childControl("listView1") as IListView;
            listView_._clearListItem();
            foreach (AddFileNodeCommand i in mAddFileNodeCommands)
            {
                listView_._addListItem(i);
            }
        }

        public override string _getTreeNodeName()
        {
            return mNodeName;
        }

        public override string _getTreeNodeImage()
        {
            return mNodeImage;
        }

        public AddFileNode()
        {
            mAddFileNodeCommands = new List<AddFileNodeCommand>();
            mAddFileNodes = new List<AddFileNode>();
            mNodeImage = null;
            mNodeName = null;
        }

        List<AddFileNodeCommand> mAddFileNodeCommands;
        List<AddFileNode> mAddFileNodes;
        string mNodeImage;
        string mNodeName;
    }
}
