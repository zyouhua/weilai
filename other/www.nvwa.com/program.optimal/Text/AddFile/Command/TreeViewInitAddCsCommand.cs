using window.include;
using platform.include;

namespace program.optimal
{
    public class TreeViewInitAddCsCommand : AbstractCommand
    {
        public override void _runCommand()
        {
            IContain contain_ = this._getOwner() as IContain;
            ITreeView treeView_ = contain_._childControl("treeView1") as ITreeView;
            AddFileUrl addFileUrl_ = new AddFileUrl();
            string newUrl_ = @"rid://program.optimal.addCsFileUrl";
            addFileUrl_._runLoad(newUrl_);
            addFileUrl_._runInit();
            addFileUrl_._addTreeNode(treeView_);
        }
    }
}
