using System.Collections.Generic;

using window.include;
using platform.include;

namespace notepad.implement
{
    public class NewProjectNode : TreeNodeStream
    {
        public override void _serialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mNodeName, @"nodeName");
            nSerialize._serialize(ref mNodeImage, @"nodeImage");
            nSerialize._serialize(ref mNewProjectNodes, @"newProjectNodes");
            nSerialize._serialize(ref mNewProjectNodeCommands, @"newProjectNodeCommands");
        }

        public void _runInit()
        {
            foreach (NewProjectNodeCommand i in mNewProjectNodeCommands)
            {
                i._runInit();
            }
            foreach (NewProjectNode i in mNewProjectNodes)
            {
                i._runInit();
            }
        }

        public override void _addTreeNode(ITreeContain nTreeContain)
        {
            foreach (NewProjectNode i in mNewProjectNodes)
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
            foreach (NewProjectNodeCommand i in mNewProjectNodeCommands)
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

        public NewProjectNode()
        {
            mNewProjectNodeCommands = new List<NewProjectNodeCommand>();
            mNewProjectNodes = new List<NewProjectNode>();
            mNodeImage = null;
            mNodeName = null;
        }

        List<NewProjectNodeCommand> mNewProjectNodeCommands;
        List<NewProjectNode> mNewProjectNodes;
        string mNodeImage;
        string mNodeName;
    }
}
