using System.Collections.Generic;

using window.include;
using platform.include;

namespace program.optimal
{
    public class NewFileNode : TreeNodeStream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mNodeName, @"nodeName");
            nSerialize._serialize(ref mNodeImage, @"nodeImage");
            nSerialize._serialize(ref mNewFileNodes, @"newFileNodes");
            nSerialize._serialize(ref mNewFileNodeCommands, @"newFileNodeCommands");
        }

        public void _runInit()
        {
            foreach (NewFileNodeCommand i in mNewFileNodeCommands)
            {
                i._runInit();
            }
            foreach (NewFileNode i in mNewFileNodes)
            {
                i._runInit();
            }
        }

        public override void _addTreeNode(ITreeContain nTreeContain)
        {
            foreach (NewFileNode i in mNewFileNodes)
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
            foreach (NewFileNodeCommand i in mNewFileNodeCommands)
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

        public NewFileNode()
        {
            mNewFileNodeCommands = new List<NewFileNodeCommand>();
            mNewFileNodes = new List<NewFileNode>();
            mNodeImage = null;
            mNodeName = null;
        }

        List<NewFileNodeCommand> mNewFileNodeCommands;
        List<NewFileNode> mNewFileNodes;
        string mNodeImage;
        string mNodeName;
    }
}
